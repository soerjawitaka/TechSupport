Imports System.Data.SqlClient

Public Class TechSupportDataAccess
    Friend Shared Sub UpdateDatabase(ByVal dtSet As DataSet)
        Using connection As New SqlConnection(My.Resources.ConnectionString)
            Dim adapter As New SqlDataAdapter()
            Try
                connection.Open()
                adapter.Fill(dtSet)
                adapter.Update(dtSet)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

End Class
