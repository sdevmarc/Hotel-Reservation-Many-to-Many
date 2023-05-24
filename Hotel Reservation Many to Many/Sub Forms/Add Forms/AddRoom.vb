Public Class AddRoom
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If (String.IsNullOrEmpty(txtRoomNo.Text) OrElse String.IsNullOrEmpty(txtRName.Text)) Then
                MessageBox.Show("Please fill in all the fields!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                InsertRoom()
                Room.Close()
                ShowMdi("room")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error encountered!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class