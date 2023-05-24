Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowMdi("home")
        tsUser.Text = "SUAREZ, MARC EDISON D."
        tsDT.Text = Now
    End Sub

    Private Sub msExit_Click(sender As Object, e As EventArgs) Handles msExit.Click
        If (MessageBox.Show("Do you really wish to exit the application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub msDev_Click(sender As Object, e As EventArgs) Handles msDev.Click
        Process.Start("https://github.com/sdevmarc")
    End Sub
End Class
