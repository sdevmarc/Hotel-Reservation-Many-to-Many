Public Class Reservation
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowReservation(dgvReservation)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ShowMdi("home")
    End Sub

    Private Sub btnAddbook_Click(sender As Object, e As EventArgs) Handles btnAddbook.Click
        AddReservation.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddReservation.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim searchValue As Integer
            If Integer.TryParse(txtSearch.Text, searchValue) Then
                GetReserveID(txtSearch.Text)
                MngReservation.Show()
                RetrieveReservation()
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
                GetReserveID(txtSearch.Text)
                SearchReservation(txtSearch.Text, dgvReservation)
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
        ShowReservation(dgvReservation)
        btnEdit.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Do you really wish to delete this data?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            DeleteReservation()
        End If

    End Sub
End Class