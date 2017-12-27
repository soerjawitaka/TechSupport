'---------------------------------------------------------
' John Soerjawitaka
' INFO 2574 - Assignment 7 - Registration Maintenance
' Created: 2/23/2017
' Last updated: 2/24/2017
' Product DB Class
' This is a shared class to retrieve product list 
' from TechSupport database
'----------------------------------------------------------
Imports System.Data.SqlClient

Public Class ProductDB
    Public Shared Function GetProductList() As List(Of Product)
        Dim prodList As New List(Of Product)

        Dim connection As SqlConnection = TechSupportDB.GetConnection()
        Dim selectStatement As String = "SELECT ProductCode, Name FROM Products"
        Dim selectCommand As New SqlCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As SqlDataReader = selectCommand.ExecuteReader()
            While reader.Read
                Dim p As New Product()
                p.ProductCode = reader("ProductCode").ToString()
                p.Name = reader("Name").ToString()
                prodList.Add(p)
            End While
        Catch ex As SqlException
            MsgBox(ex.Message)
            prodList = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
            prodList = Nothing
        Finally
            connection.Close()
        End Try

        Return prodList
    End Function

End Class
