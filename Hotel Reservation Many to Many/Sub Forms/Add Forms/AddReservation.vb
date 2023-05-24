Public Class AddReservation
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If (String.IsNullOrEmpty(txtCustomerNo.Text) OrElse String.IsNullOrEmpty(txtRoomNo.Text) OrElse String.IsNullOrEmpty(txtPax.Text)) Then
                MessageBox.Show("Please fill in all the fields!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If VerifyCustomer() = True Then
                    If VerifyRoom() = True Then
                        InsertReservation()
                        Reservation.Close()
                        ShowMdi("reserve")
                        Me.Close()
                    Else
                        MessageBox.Show("Room number  " + txtRoomNo.Text + " does not exist", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    MessageBox.Show("Customer number " + txtCustomerNo.Text + " does not exist", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error encountered!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class