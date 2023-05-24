Public Class Room
    Private Sub Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowRooms(dgvRoom)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ShowMdi("home")
    End Sub

    Private Sub btnAddbook_Click(sender As Object, e As EventArgs) Handles btnAddbook.Click
        AddRoom.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddRoom.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim searchValue As Integer
            If Integer.TryParse(txtSearch.Text, searchValue) Then
                GetRoomID(txtSearch.Text)
                MngRoom.Show()
                RetrieveRoom()
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
                GetRoomID(txtSearch.Text)
                dgvRoom.Rows.Clear()
                SearchRoom(txtSearch.Text, dgvRoom)
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
        ShowRooms(dgvRoom)
        btnEdit.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Do you really wish to delete this data?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            DeleteRoom()
        End If

    End Sub
End Class