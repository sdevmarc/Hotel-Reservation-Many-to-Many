Public Class Customer
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowCustomers(dgvCustomers)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ShowMdi("home")
    End Sub

    Private Sub btnAddbook_Click(sender As Object, e As EventArgs) Handles btnAddbook.Click
        AddCustomer.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddCustomer.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim searchValue As Integer
            If Integer.TryParse(txtSearch.Text, searchValue) Then
                GetCustomerID(txtSearch.Text)
                MngCustomer.Show()
                RetrieveCustomer()
            ElseIf (txtSearch.Text = "") Then
                MessageBox.Show("Please fill the search box!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Please enter a valid id number!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error Encountered!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchValue As Integer
            If Integer.TryParse(txtSearch.Text, searchValue) Then
                GetCustomerID(txtSearch.Text)
                dgvCustomers.Rows.Clear()
                SearchCustomer(txtSearch.Text, dgvCustomers)
                btnEdit.Enabled = True
            ElseIf (txtSearch.Text = "") Then
                MessageBox.Show("Please fill the search box!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Please enter a valid id number!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error Encountered!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Text = ""
        ShowCustomers(dgvCustomers)
        btnEdit.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Do you really wish to delete this data?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            DeleteCustomer()
        End If
    End Sub
End Class