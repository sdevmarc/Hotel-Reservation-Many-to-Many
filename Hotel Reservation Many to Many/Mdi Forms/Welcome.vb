Public Class Welcome
    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        ShowMdi("reserve")
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        ShowMdi("customer")
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        ShowMdi("room")
    End Sub
End Class