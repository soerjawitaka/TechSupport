'---------------------------------------------------------
' John Soerjawitaka
' INFO 2574 - Assignment 7 - Registration Maintenance
' Created: 2/23/2017
' Last updated: 2/24/2017
' Customer Class
' This class holds information for a customer
'----------------------------------------------------------

Public Class Customer
    Public Property CustomerID As Integer
    Public Property Name As String

    Public Sub New()

    End Sub

    Public Function GetDisplayText() As String
        Return Me.CustomerID.ToString() & vbTab & Me.Name.ToString()
    End Function
End Class
