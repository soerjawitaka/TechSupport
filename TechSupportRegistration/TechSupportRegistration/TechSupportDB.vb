'---------------------------------------------------------
' John Soerjawitaka
' INFO 2574 - Assignment 7 - Registration Maintenance
' Created: 2/23/2017
' Last updated: 2/24/2017
' TechSupport DB Class
' This is a shared class to establish a connection 
' to TechSupport database
'----------------------------------------------------------
Imports System.Data.SqlClient

Public Class TechSupportDB
    Public Shared Function GetConnection() As SqlConnection
        Dim conString As String = My.Resources.ConnectionString
        Dim connection As New SqlConnection(conString)
        Return connection
    End Function

End Class
