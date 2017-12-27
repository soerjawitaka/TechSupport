'---------------------------------------------------------
' John Soerjawitaka
' INFO 2574 - Assignment 7 - Registration Maintenance
' Created: 2/23/2017
' Last updated: 2/24/2017
' Product Class
' This class holds information for a product
'----------------------------------------------------------
Public Class Product
    Public Property Name As String
    Public Property ProductCode As String

    Public Sub New()

    End Sub

    Public Function GetDisplayText() As String
        Return Me.ProductCode.ToString() & vbTab & Me.Name.ToString()
    End Function
End Class
