'---------------------------------------------------------
' John Soerjawitaka
' INFO 2574 - Assignment 7 - Registration Maintenance
' Created: 2/23/2017
' Last updated: 2/28/2017
' Registration DB Class
' This is a shared class with multiple methods to 
' interact with the TechSupport database
'----------------------------------------------------------
Imports System.Data.SqlClient
Imports System.Data.DbType

Public Class RegistrationDB
    Public Shared Function AddRegistration(ByVal registration As Registration) As Boolean
        Dim connection As SqlConnection = TechSupportDB.GetConnection()
        Dim isSuccesful As Boolean
        Dim insertStatement As String = "INSERT INTO Registrations" &
                                        "(CustomerID, ProductCode, RegistrationDate)" &
                                        "VALUES (@custId, @prodCode, @regDate)"
        Dim insertCommand As New SqlCommand(insertStatement, connection)
        insertCommand.Parameters.AddWithValue("@custID", registration.CustomerID)
        insertCommand.Parameters.AddWithValue("@prodCode", registration.ProductCode)
        insertCommand.Parameters.AddWithValue("@regDate", registration.RegistrationDate)

        Try
            connection.Open()
            insertCommand.ExecuteNonQuery()
            isSuccesful = True
        Catch ex As SqlException
            MsgBox(ex.Message)
            isSuccesful = False
        Catch ex As Exception
            MsgBox(ex.Message)
            isSuccesful = False
        Finally
            connection.Close()
        End Try
        Return isSuccesful
    End Function

    Public Shared Function DeleteRegistration(ByVal registration As Registration) As Boolean
        Dim connection As SqlConnection = TechSupportDB.GetConnection()
        Dim isSuccesful As Boolean
        Dim deleteStatement As String = "DELETE FROM Registrations " &
                                        "WHERE CustomerID = @custID AND " &
                                        "ProductCode = @prodCode;"
        Dim deleteCommand As New SqlCommand(deleteStatement, connection)
        deleteCommand.Parameters.AddWithValue("@custID", registration.CustomerID)
        deleteCommand.Parameters.AddWithValue("@prodCode", registration.ProductCode.ToString())

        Try
            connection.Open()
            Dim count As Integer = deleteCommand.ExecuteNonQuery()
            If count > 0 Then
                isSuccesful = True
            End If
        Catch ex As SqlException
            MsgBox(ex.Message)
            isSuccesful = False
        Catch ex As Exception
            MsgBox(ex.Message)
            isSuccesful = False
        Finally
            connection.Close()
        End Try
        Return isSuccesful
    End Function

    Public Shared Function VerifyRegistration(ByVal registration As Registration) As Boolean
        Dim retrievedReg As New Registration()
        Dim isVerified As Boolean
        Dim connection As SqlConnection = TechSupportDB.GetConnection()
        Dim selectStatement As String = "SELECT * FROM Registrations " &
                                        "WHERE CustomerID = @CustomerID AND ProductCode = @ProductCode"
        Dim selectCommand As New SqlCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("@CustomerID", registration.CustomerID)
        selectCommand.Parameters.AddWithValue("@ProductCode", registration.ProductCode)

        Try
            connection.Open()
            Dim reader As SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                retrievedReg.CustomerID = CInt(reader("CustomerID"))
                retrievedReg.ProductCode = reader("ProductCode").ToString()
                retrievedReg.RegistrationDate = CType(reader("RegistrationDate"), DateTime)
            Else
                retrievedReg = Nothing
            End If

            If retrievedReg Is Nothing Then
                isVerified = True
            Else
                isVerified = False
            End If
        Catch ex As SqlException
            MsgBox(ex.Message & "this one")
            isVerified = False
        Catch ex As Exception
            MsgBox(ex.Message)
            isVerified = False
        End Try
        Return isVerified
    End Function

End Class
