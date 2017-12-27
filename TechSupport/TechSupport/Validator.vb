'------------------------------------------------------
'John Soerjawitaka
'1-6-2017
'Last modified: 2-17-2017
'Validator Class
'Shared functions to validate data that returns boolean
'------------------------------------------------------

Public Class Validator

    '----------------------------------------------------------
    ' String Entry validators
    '----------------------------------------------------------
    Public Overloads Shared Function IsPresent(ByVal text As String) As Boolean
        Dim isValid As Boolean
        If text = "" Or IsNothing(text) Then
            isValid = False
            MsgBox("Input is required", MsgBoxStyle.OkOnly, "No Input")
        Else
            isValid = True
        End If
        Return isValid
    End Function

    Public Overloads Shared Function IsInteger(ByVal text As String) As Boolean
        Dim isValid As Boolean,
            number As Integer

        isValid = IsPresent(text) AndAlso IsNumeric(text)
        If isValid Then
            isValid = Integer.TryParse(text, number)
            If Not isValid Then
                MsgBox("Input must be an Integer", MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If

        Return isValid
    End Function

    Public Overloads Shared Function IsInteger(ByVal text As String, message As String) As Boolean
        Dim isValid As Boolean,
            number As Integer

        isValid = IsPresent(text) AndAlso IsNumeric(text)
        If isValid Then
            isValid = Integer.TryParse(text, number)
            If Not isValid Then
                MsgBox(message, MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If

        Return isValid
    End Function

    Public Overloads Shared Function IsDouble(ByVal text As String) As Boolean
        Dim isValid As Boolean,
            number As Double

        isValid = IsPresent(text) AndAlso IsNumeric(text)
        If isValid Then
            isValid = Double.TryParse(text, number)
            If Not isValid Then
                MsgBox("Input must be a Double", MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If

        Return isValid
    End Function

    Public Overloads Shared Function IsDecimal(ByVal text As String) As Boolean
        Dim isValid As Boolean,
            number As Decimal

        isValid = IsPresent(text) AndAlso IsNumeric(text)
        If isValid Then
            isValid = Decimal.TryParse(text, number)
            If Not isValid Then
                MsgBox("Input must be an Decimal", MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If

        Return isValid
    End Function

    Public Overloads Shared Function IsWithinRange(ByRef text As String, min As Integer, max As Integer) As Boolean
        Dim isValid As Boolean
        If IsInteger(text) Then
            Dim number As Integer = CInt(text)
            If number >= min AndAlso number <= max Then
                isValid = True
            Else
                isValid = False
                MsgBox("Input must be between " + min.ToString() + " and " + max.ToString(), MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If
        Return isValid
    End Function

    Public Overloads Shared Function IsWithinRange(ByRef text As String, min As Integer, max As Integer, message As String, withRangeSpecification As Boolean) As Boolean
        Dim isValid As Boolean
        If IsInteger(text) Then
            Dim number As Integer = CInt(text)
            If number >= min AndAlso number <= max Then
                isValid = True
            Else
                isValid = False
                If withRangeSpecification Then
                    MsgBox(message & " must be between " & min.ToString() & " and " + max.ToString(), MsgBoxStyle.OkOnly, "Invalid Input")
                Else
                    MsgBox(message)
                End If
            End If
        End If
        Return isValid
    End Function

    Public Overloads Shared Function IsWithinRange(ByRef text As String, min As Double, max As Double) As Boolean
        Dim isValid As Boolean
        If IsDouble(text) Then
            Dim number As Double = CDbl(text)
            If number >= min AndAlso number <= max Then
                isValid = True
            Else
                isValid = False
                MsgBox("Input must be between " + min.ToString() + " and " + max.ToString(), MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If
        Return isValid
    End Function

    Public Overloads Shared Function IsWithinRange(ByRef text As String, min As Decimal, max As Decimal) As Boolean
        Dim isValid As Boolean
        If IsDecimal(text) Then
            Dim number As Decimal = CDec(text)
            If number >= min AndAlso number <= max Then
                isValid = True
            Else
                isValid = False
                MsgBox("Input must be between " + min.ToString() + " and " + max.ToString(), MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If
        Return isValid
    End Function

    '---------------------------------------------------
    ' Key-press Char validator
    '---------------------------------------------------

    Public Shared Function KeycodeCharNumericOnly(ByRef c As Char) As Boolean
        Dim isNumeric As Boolean
        If Not ((Convert.ToByte(c) > 47 AndAlso Convert.ToByte(c) < 58) Or (Convert.ToByte(c) > 95 AndAlso Convert.ToByte(c) < 106)) AndAlso Convert.ToByte(c) <> 8 Then
            isNumeric = False
        Else
            isNumeric = True
        End If
        Return isNumeric
    End Function

    Public Shared Function KeycodeByteNumericOnly(ByRef b As Byte) As Boolean
        Dim isNumeric As Boolean
        If Not ((b > 47 AndAlso b < 58) Or (b > 95 AndAlso b < 106)) AndAlso b <> 8 Then
            isNumeric = False
        Else
            isNumeric = True
        End If
        Return isNumeric
    End Function

    '----------------------------------------------------------
    ' Text Box Entry validators
    '----------------------------------------------------------
    Public Overloads Shared Function IsPresent(ByVal txtBox As TextBox) As Boolean
        Dim isValid As Boolean
        If txtBox.Text = "" Or IsNothing(txtBox.Text) Then
            isValid = False
            txtBox.Focus()
            MsgBox("Input is required", MsgBoxStyle.OkOnly, "No Input")
        Else
            isValid = True
        End If
        Return isValid
    End Function

    Public Overloads Shared Function IsInteger(ByVal txtBox As TextBox) As Boolean
        Dim isValid As Boolean,
            number As Integer

        isValid = IsPresent(txtBox)
        If isValid Then
            isValid = Integer.TryParse(txtBox.Text, number)
            If Not isValid Then
                txtBox.Focus()
                txtBox.SelectAll()
                MsgBox("Input must be an Integer", MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If

        Return isValid
    End Function

    Public Overloads Shared Function IsDouble(ByVal txtBox As TextBox) As Boolean
        Dim isValid As Boolean,
            number As Double

        isValid = IsPresent(txtBox)
        If isValid Then
            isValid = Double.TryParse(txtBox.Text, number)
            If Not isValid Then
                txtBox.Focus()
                txtBox.SelectAll()
                MsgBox("Input must be a Double", MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If

        Return isValid
    End Function

    Public Overloads Shared Function IsDecimal(ByVal txtBox As TextBox) As Boolean
        Dim isValid As Boolean,
            number As Decimal

        isValid = IsPresent(txtBox)
        If isValid Then
            isValid = Decimal.TryParse(txtBox.Text, number)
            If Not isValid Then
                txtBox.Focus()
                txtBox.SelectAll()
                MsgBox("Input must be an Decimal", MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If

        Return isValid
    End Function

    Public Overloads Shared Function IsWithinRange(ByRef txtBox As TextBox, min As Integer, max As Integer) As Boolean
        Dim isValid As Boolean
        If IsInteger(txtBox) Then
            Dim number As Integer = CInt(txtBox.Text)
            If number >= min AndAlso number <= max Then
                isValid = True
            Else
                isValid = False
                txtBox.Focus()
                txtBox.SelectAll()
                MsgBox("Input must be between " + min.ToString() + " and " + max.ToString(), MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If
        Return isValid
    End Function

    Public Overloads Shared Function IsWithinRange(ByRef txtBox As TextBox, min As Double, max As Double) As Boolean
        Dim isValid As Boolean
        If IsDouble(txtBox) Then
            Dim number As Double = CDbl(txtBox.Text)
            If number >= min AndAlso number <= max Then
                isValid = True
            Else
                isValid = False
                txtBox.Focus()
                txtBox.SelectAll()
                MsgBox("Input must be between " + min.ToString() + " and " + max.ToString(), MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If
        Return isValid
    End Function

    Public Overloads Shared Function IsWithinRange(ByRef txtBox As TextBox, min As Decimal, max As Decimal) As Boolean
        Dim isValid As Boolean
        If IsDecimal(txtBox) Then
            Dim number As Decimal = CDec(txtBox.Text)
            If number >= min AndAlso number <= max Then
                isValid = True
            Else
                isValid = False
                txtBox.Focus()
                txtBox.SelectAll()
                MsgBox("Input must be between " + min.ToString() + " and " + max.ToString(), MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If
        Return isValid
    End Function

    '------------With Custom Text---------------------------

    Public Overloads Shared Function IsPresent(ByVal txtBox As TextBox, message As String) As Boolean
        Dim isValid As Boolean
        If txtBox.Text = "" Or IsNothing(txtBox.Text) Then
            isValid = False
            txtBox.Focus()
            MsgBox(message, MsgBoxStyle.OkOnly, "No Input")
        Else
            isValid = True
        End If
        Return isValid
    End Function

    Public Overloads Shared Function IsInteger(ByVal txtBox As TextBox, message As String) As Boolean
        Dim isValid As Boolean,
            number As Integer

        isValid = IsPresent(txtBox, message)
        If isValid Then
            isValid = Integer.TryParse(txtBox.Text, number)
            If Not isValid Then
                txtBox.Focus()
                txtBox.SelectAll()
                MsgBox(message, MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If

        Return isValid
    End Function

    Public Overloads Shared Function IsDouble(ByVal txtBox As TextBox, message As String) As Boolean
        Dim isValid As Boolean,
            number As Double

        isValid = IsPresent(txtBox, message)
        If isValid Then
            isValid = Double.TryParse(txtBox.Text, number)
            If Not isValid Then
                txtBox.Focus()
                txtBox.SelectAll()
                MsgBox(message, MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If

        Return isValid
    End Function

    Public Overloads Shared Function IsDecimal(ByVal txtBox As TextBox, message As String) As Boolean
        Dim isValid As Boolean,
            number As Decimal

        isValid = IsPresent(txtBox, message)
        If isValid Then
            isValid = Decimal.TryParse(txtBox.Text, number)
            If Not isValid Then
                txtBox.Focus()
                txtBox.SelectAll()
                MsgBox(message, MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If

        Return isValid
    End Function

    Public Overloads Shared Function IsWithinRange(ByRef txtBox As TextBox, min As Integer, max As Integer, inputName As String) As Boolean
        Dim isValid As Boolean
        If IsInteger(txtBox) Then
            Dim number As Integer = CInt(txtBox.Text)
            If number >= min AndAlso number <= max Then
                isValid = True
            Else
                isValid = False
                txtBox.Focus()
                txtBox.SelectAll()
                MsgBox(inputName & " must be between " & min.ToString() & " and " + max.ToString(), MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If
        Return isValid
    End Function

    Public Overloads Shared Function IsWithinRange(ByRef txtBox As TextBox, min As Double, max As Double, inputName As String) As Boolean
        Dim isValid As Boolean
        If IsDouble(txtBox) Then
            Dim number As Double = CDbl(txtBox.Text)
            If number >= min AndAlso number <= max Then
                isValid = True
            Else
                isValid = False
                txtBox.Focus()
                txtBox.SelectAll()
                MsgBox(inputName & " must be between " & min.ToString() & " and " & max.ToString(), MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If
        Return isValid
    End Function

    Public Overloads Shared Function IsWithinRange(ByRef txtBox As TextBox, min As Decimal, max As Decimal, inputName As String) As Boolean
        Dim isValid As Boolean
        If IsDecimal(txtBox) Then
            Dim number As Decimal = CDec(txtBox.Text)
            If number >= min AndAlso number <= max Then
                isValid = True
            Else
                isValid = False
                txtBox.Focus()
                txtBox.SelectAll()
                MsgBox(inputName & " must be between " & min.ToString() & " and " & max.ToString(), MsgBoxStyle.OkOnly, "Invalid Input")
            End If
        End If
        Return isValid
    End Function

    Public Shared Function IsOperator(ByVal txtBox As TextBox) As Boolean
        Dim isValid As Boolean
        Dim operator1 As String = txtBox.Text
        Select Case operator1
            Case "+"
                isValid = True
            Case "-"
                isValid = True
            Case "*"
                isValid = True
            Case "/"
                isValid = True
            Case "^"
                isValid = True
            Case Else
                isValid = False
                txtBox.Focus()
                txtBox.SelectAll()
                MsgBox("Invalid operator, please enter a correct operator!")
        End Select
        Return isValid
    End Function

    '-------------------------------------------------
    ' Selection
    '-------------------------------------------------

    '---------------ListBox------------------------
    Public Overloads Shared Function IsSelected(ByVal lstBox As ListBox, Optional message As String = "No item selected. Please make your selection") As Boolean
        Dim selectedIndex As Integer = lstBox.SelectedIndex
        Dim isValid As Boolean
        If selectedIndex = -1 Then
            isValid = False
            MsgBox(message, MsgBoxStyle.OkOnly, "No Selection")
        Else
            isValid = True
        End If
        Return isValid
    End Function

    '----------------ComboBox-------------------------
    Public Overloads Shared Function IsSelected(ByVal cboBox As ComboBox, Optional message As String = "No item selected. Please make your selection") As Boolean
        Dim selectedIndex As Integer = cboBox.SelectedIndex
        Dim isValid As Boolean
        If selectedIndex = -1 Then
            isValid = False
            cboBox.Focus()
            cboBox.SelectAll()
            MsgBox(message, MsgBoxStyle.OkOnly, "No Selection")
        Else
            isValid = True
        End If
        Return isValid
    End Function
End Class
