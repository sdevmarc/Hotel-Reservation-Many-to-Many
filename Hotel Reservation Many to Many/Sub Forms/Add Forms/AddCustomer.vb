Public Class AddCustomer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If (String.IsNullOrEmpty(txtLN.Text) OrElse String.IsNullOrEmpty(txtFN.Text) OrElse String.IsNullOrEmpty(txtEmail.Text) OrElse String.IsNullOrEmpty(txtContact.Text) OrElse String.IsNullOrEmpty(txtAge.Text)) Then
                MessageBox.Show("Please fill in all the fields!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                InsertCustomer()
                Customer.Close()
                ShowMdi("customer")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error encountered!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class