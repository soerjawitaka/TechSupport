'------------------------------------------------------
'John Soerjawitaka
'2-14-2017
'Last modified: 2-15-2017
'Customer Incident Form
'This is a form for Customer and Incident database
'maintenance
'------------------------------------------------------

Imports System.Data.SqlClient

Public Class frmCustomerIncident

    Private Sub FillByIDToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByIDToolStripButton.Click
        Try
            Me.CustomersTableAdapter.FillByID(Me.TechSupportDataSet.Customers, CType(IDToolStripTextBox.Text, Integer))
            If CustomersBindingSource.Count = 0 Then
                MessageBox.Show("No Customer with ID '" & IDToolStripTextBox.Text.ToString() & "'", "ATTENTION")
                IDToolStripTextBox.Focus()
                IDToolStripTextBox.SelectAll()
            End If
        Catch ex As DBConcurrencyException
            MessageBox.Show("A concurrency error occured. " & vbCrLf &
                            "Some rows were not updated.", "Concurrency Error")
        Catch ex As DataException
            MessageBox.Show(ex.Message & vbCrLf & ex.GetType().ToString())
        Catch ex As SqlException
            MessageBox.Show("Database error # " & ex.Number & vbCrLf &
                            "Error Type : " & ex.GetType().ToString() & vbCrLf &
                            ex.Message, "SQL Error")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByCUSTOMERToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByIDToolStripButton.Click
        Try
            Me.IncidentsTableAdapter.FillByCUSTOMER(Me.TechSupportDataSet.Incidents, CType(IDToolStripTextBox.Text, Integer))
            If IncidentsBindingSource.Count = 0 Then
                MessageBox.Show("No Incident/s recorded for this customer.", "ATTENTION")
            End If
        Catch ex As DBConcurrencyException
            MessageBox.Show("A concurrency error occured. " & vbCrLf &
                            "Some rows were not updated.", "Concurrency Error")
        Catch ex As DataException
            MessageBox.Show(ex.Message & vbCrLf & ex.GetType().ToString())
        Catch ex As SqlException
            MessageBox.Show("Database error # " & ex.Number & vbCrLf &
                            "Error Type : " & ex.GetType().ToString() & vbCrLf &
                            ex.Message, "SQL Error")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If CustomerIDTextBox.Text = "" Then
            MessageBox.Show("Please select a customer", "ATTENTION")
        Else
            Dim addIncident As New frmAddIncident()
            addIncident.Tag = CustomerIDTextBox.Text.ToString()
            addIncident.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ToolStripbtnFindCustByState_Click(sender As Object, e As EventArgs) Handles ToolStripbtnFindCustByState.Click
        Dim findCustByState As New frmFindCustomerByState()
        findCustByState.ShowDialog()
        If findCustByState.Tag IsNot Nothing Then
            IDToolStripTextBox.Text = findCustByState.Tag.ToString()
            FillByIDToolStripButton.PerformClick()
        End If

    End Sub

    Private Sub IncidentsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) 
        Dim row As Integer = e.RowIndex + 1
        Dim errorMessage As String = "A data error occured." & vbCrLf &
                                     "Row: " & row & vbCrLf &
                                     "Error: " & e.Exception.Message
        MessageBox.Show(errorMessage, "Data Error")
    End Sub

    Private Sub IDToolStripTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles IDToolStripTextBox.KeyDown
        If Not Validator.KeycodeByteNumericOnly(Convert.ToByte(e.KeyCode)) Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Friend Sub ShowCustomerIncidentForm()
        Me.Show()
        FillByIDToolStripButton.PerformClick()
    End Sub
End Class
