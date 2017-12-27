'---------------------------------------------------------
' John Soerjawitaka
' INFO 2574 - Assignment 7 - Registration Maintenance
' Created: 2/23/2017
' Last updated: 2/24/2017
' Registration Maintenance Form
' This form Displays information about Product to 
' Customer registration with the options to 
' add or delete registered product on a Customer
'----------------------------------------------------------

Public Class frmRegistrationMaintenance
    Private Sub frmRegistrationMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim custList As List(Of Customer) = CustomerDB.GetCustomerList()
        Dim prodList As List(Of Product) = ProductDB.GetProductList()

        cboCustomer.DataSource = custList
        cboCustomer.DisplayMember = "Name"
        cboCustomer.ValueMember = "CustomerID"
        cboCustomer.SelectedIndex = -1

        cboProduct.DataSource = prodList
        cboProduct.DisplayMember = "Name"
        cboProduct.ValueMember = "ProductCode"
        cboProduct.SelectedIndex = -1

        Me.txtDate.Text = DateTime.Today.ToShortDateString()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If cboCustomer.SelectedIndex = -1 Then
            MessageBox.Show("Please select a customer to assign a product", "No Customer Selected")
            cboCustomer.SelectedIndex = 0
            cboCustomer.Focus()
        Else
            If cboProduct.SelectedIndex = -1 Then
                MessageBox.Show("Please select a product to be assigned", "No Product Selected")
                cboProduct.SelectedIndex = 0
                cboProduct.Focus()
            Else
                Dim registration As New Registration()
                registration.CustomerID = CInt(cboCustomer.SelectedValue)
                registration.ProductCode = cboProduct.SelectedValue.ToString()
                registration.RegistrationDate = DateTime.Today
                Dim selectedCust As Customer = CType(cboCustomer.SelectedItem, Customer)
                Dim selectedProd As Product = CType(cboProduct.SelectedItem, Product)

                If RegistrationDB.VerifyRegistration(registration) Then
                    If RegistrationDB.AddRegistration(registration) Then
                        MessageBox.Show("New Registration was succesfully added for " & vbCrLf &
                                        selectedProd.Name.ToString() & " assigned to " &
                                        selectedCust.Name.ToString() & ".", "Registration Success")
                    End If
                Else
                    MessageBox.Show(selectedProd.Name.ToString() & " is already assigned to " &
                                    selectedCust.Name.ToString() & vbCrLf &
                                    "Please select a different customer and/or different product",
                                    "Registration Found")
                End If
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If cboCustomer.SelectedIndex = -1 Then
            MessageBox.Show("Please select a customer to delete a Registration.", "No Customer Selected")
            cboCustomer.SelectedIndex = 0
            cboCustomer.Focus()
        Else
            If cboProduct.SelectedIndex = -1 Then
                MessageBox.Show("Please select a product to delete a Registration", "No Product Selected")
                cboProduct.SelectedIndex = 0
                cboProduct.Focus()
            Else
                Dim registration As New Registration()
                registration.CustomerID = CInt(cboCustomer.SelectedValue)
                registration.ProductCode = cboProduct.SelectedValue.ToString()
                Dim selectedCust As Customer = CType(cboCustomer.SelectedItem, Customer)
                Dim selectedProd As Product = CType(cboProduct.SelectedItem, Product)

                If Not RegistrationDB.VerifyRegistration(registration) Then
                    Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove the following registration?" & vbCrLf &
                                                                 selectedCust.Name.ToString() & " for product: " &
                                                                 selectedProd.Name.ToString(),
                                                                 "Delete Confirmation",
                                                                 MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        If RegistrationDB.DeleteRegistration(registration) Then
                            MessageBox.Show(“The registration has been deleted for: " & vbCrLf &
                                            selectedCust.Name.ToString() & " for product: " &
                                            selectedProd.Name.ToString(),
                                            "Delete Successful")
                            ClearTheForm()
                        Else
                            MessageBox.Show(“The following registration has not been deleted for: " & vbCrLf &
                                            selectedCust.Name.ToString() & " for product: " &
                                            selectedProd.Name.ToString(),
                                            "Delete Failed")
                            cboProduct.Focus()
                        End If
                    End If
                Else
                    MessageBox.Show("There is no matching registration found to be deleted for: " & vbCrLf &
                                    selectedCust.Name.ToString() & " for product: " &
                                    selectedProd.Name.ToString())
                End If
            End If
        End If
    End Sub

    Private Sub ClearTheForm()
        Me.cboCustomer.SelectedIndex = -1
        Me.cboCustomer.Focus()
        Me.cboProduct.SelectedIndex = -1
        Me.txtDate.Text = DateTime.Today.ToShortDateString()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearTheForm()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
End Class
