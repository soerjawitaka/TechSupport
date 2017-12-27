'---------------------------------------------------------
' John Soerjawitaka
' INFO 2574 - Assignment 7 - Registration Maintenance
' Created: 2/23/2017
' Last updated: 2/24/2017
' Customer DB Class
' This is a shared class to retrieve customer list 
' from TechSupport database
'----------------------------------------------------------
Imports System.Data.SqlClient

Public Class CustomerDB
    Public Shared Function GetCustomerList() As List(Of Customer)
        Dim custList As New List(Of Customer)
        Dim connection As SqlConnection = TechSupportDB.GetConnection()
        Dim selectStatement As String = "SELECT CustomerID, Name FROM Customers"
        Dim selectCommand As New SqlCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As SqlDataReader = selectCommand.ExecuteReader()
            While reader.Read
                Dim c As New Customer()
                c.CustomerID = CInt(reader("CustomerID"))
                c.Name = reader("Name").ToString()
                custList.Add(c)
            End While
        Catch ex As SqlException
            MsgBox(ex.Message)
            custList = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
            custList = Nothing
        Finally
            connection.Close()
        End Try

        Return custList
    End Function

End Class
