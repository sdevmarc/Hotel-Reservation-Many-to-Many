Public Class MngReservation
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If (String.IsNullOrEmpty(txtCustomerNo.Text) OrElse String.IsNullOrEmpty(txtRoomNo.Text) OrElse String.IsNullOrEmpty(txtPax.Text)) Then
                MessageBox.Show("Please fill in all the fields!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                UpdateReservation()
                Reservation.Close()
                ShowMdi("reserve")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error encountered!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class