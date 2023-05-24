Module OBJModule

    Sub ShowMdi(inp As Object)
        If (inp = "reserve") Then
            inp = New Reservation
            inp.MdiParent = Main
            inp.show()
            Customer.Close()
            Room.Close()
            Welcome.Close()
        ElseIf (inp = "customer") Then
            inp = New Customer
            inp.MdiParent = Main
            inp.show()
            Reservation.Close()
            Room.Close()
            Welcome.Close()
        ElseIf (inp = "room") Then
            inp = New Room
            inp.MdiParent = Main
            inp.show()
            Customer.Close()
            Reservation.Close()
            Welcome.Close()
        ElseIf (inp = "home") Then
            inp = New Welcome
            inp.MdiParent = Main
            inp.show()
            Customer.Close()
            Room.Close()
            Reservation.Close()
        End If
    End Sub
End Module
