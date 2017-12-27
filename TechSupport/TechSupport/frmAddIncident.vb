'John Soerjawitaka
'2-14-2017
'Last modified: 2-16-2017
'Add Incident Form
'This is a form to add an incident report 
'for a customer
'------------------------------------------------------

Imports System.Data.SqlClient

Public Class frmAddIncident
    Private dateCreated As DateTime
    Friend Delegate Sub CustomerIncident()
    Friend Event ShowCustomerIncidentForm As CustomerIncident

    Private Sub frmAddIncident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler ShowCustomerIncidentForm, AddressOf frmCustomerIncident.ShowCustomerIncidentForm
        Dim custID As Integer = CInt(Me.Tag.ToString())
        Try
            Me.CustomersTableAdapter1.FillByID(Me.TechSupportDataSet.Customers, custID)
            Me.ProductsTableAdapter1.FillByCUSTOMER(Me.TechSupportDataSet.Products, custID)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        txtID.Text = custID.ToString
        dateCreated = DateTime.Today
        txtDate.Text = dateCreated.ToShortDateString()
        cboProduct.SelectedIndex = -1
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If IsValidData() Then
            Try
                Dim id As Integer = CInt(txtID.Text),
                    prodCode As String = cboProduct.SelectedValue.ToString(),
                    title As String = txtTitle.Text.ToString(),
                    desc As String = txtDescription.Text.ToString()
                Me.IncidentsTableAdapter1.InsertNewRow(id, prodCode, dateCreated, title, desc)
                Me.IncidentsTableAdapter1.Update(TechSupportDataSet.Incidents)
                RaiseEvent ShowCustomerIncidentForm()
                Me.Dispose()
            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        RaiseEvent ShowCustomerIncidentForm()
        Me.Dispose()
    End Sub

    '-----------------Private method----------------------
    Private Function IsValidData() As Boolean
        Return Validator.IsSelected(cboProduct) AndAlso
               Validator.IsPresent(txtTitle, "Title") AndAlso
               Validator.IsPresent(txtDescription, "Description")
    End Function
End Class