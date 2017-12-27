'------------------------------------------------------
'John Soerjawitaka
'2-14-2017
'Last modified: 2-16-2017
'Find Customer Form
'This is a form that displays Customer 
'information based on user's search by Customer state
'------------------------------------------------------

Imports System.Data.SqlClient

Public Class frmFindCustomerByState
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TechSupportDataSet)

    End Sub

    Private Sub FillLikeSTATEToolStripButton_Click(sender As Object, e As EventArgs) Handles FillLikeSTATEToolStripButton.Click
        If IsValidData() Then
            Try
                Me.CustomersTableAdapter.FillLikeSTATE(Me.TechSupportDataSet.Customers, STATEToolStripTextBox.Text + "%")
                If CustomersBindingSource.Count = 0 Then
                    MessageBox.Show("No customers for state code " & STATEToolStripTextBox.Text.ToString(), "ATTENTION")
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
        End If
    End Sub

    Private Function IsValidData() As Boolean
        Dim state As String = STATEToolStripTextBox.Text
        Return Validator.IsPresent(state) AndAlso
               Validator.IsWithinRange(state.Length.ToString, 1, 2, "State code is the two character abreviation of the state." & vbCrLf & "Please re-enter the State-Code", False)
    End Function

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click, CustomersDataGridView.CellDoubleClick
        Dim selectedCustomerID As String = CustomersDataGridView.SelectedCells(0).OwningRow.Cells(0).Value.ToString()
        Me.Tag = CustomersDataGridView.SelectedCells(0).OwningRow.Cells(0).Value.ToString()
        Me.Dispose()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub CustomersDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles CustomersDataGridView.DataError
        Dim row As Integer = e.RowIndex + 1
        Dim errorMessage As String = "A data error occured." & vbCrLf &
                                     "Row: " & row & vbCrLf &
                                     "Error: " & e.Exception.Message
        MessageBox.Show(errorMessage, "Data Error")
    End Sub
End Class