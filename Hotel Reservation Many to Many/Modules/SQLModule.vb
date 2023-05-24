Imports System.Runtime.Remoting
Imports MySql.Data.MySqlClient
Module SQLModule
    Private Cusid, Roomid, Reserveid As Integer


    Dim constring As String = "server = localhost; user = root; password = 1234; database = hotel_forreal"
    Dim con As New MySqlConnection(constring)
    Dim cmd As MySqlCommand

    'SHOW DATA
    Sub ShowReservation(grid As Object)
        con.Open()
        grid.Rows.Clear()
        cmd = New MySqlCommand("select * from reservation left join room on reservation.reservation_id = room.room_no left join customer on reservation.reservation_id = customer.customer_id", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            grid.Rows.Add(read("reservation_id"), read("lastname"), read("firstname"), read("pax"), read("date_from"), read("date_to"))
        End While
        read.Close()
        con.Close()
    End Sub

    Sub ShowRooms(grid As Object)
        con.Open()
        grid.Rows.Clear()
        cmd = New MySqlCommand("select * from room", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            grid.Rows.Add(read("room_no"), read("room_type"))
        End While
        read.Close()
        con.Close()
    End Sub

    Sub ShowCustomers(grid As Object)
        con.Open()
        grid.Rows.Clear()
        cmd = New MySqlCommand("select * from customer", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            grid.Rows.Add(read("customer_id"), read("lastname"), read("firstname"), read("age"), read("email"), read("contact_number"))
        End While
        read.Close()
        con.Close()
    End Sub


    'INSERT DATA
    Sub InsertCustomer()
        con.Open()
        cmd = New MySqlCommand("Insert into customer (lastname, firstname, age, email, contact_number) values (@LN, @FN, @AGE, @EMAIL, @CONTACT)", con)
        cmd.Parameters.AddWithValue("@LN", AddCustomer.txtLN.Text)
        cmd.Parameters.AddWithValue("@FN", AddCustomer.txtFN.Text)
        cmd.Parameters.AddWithValue("@AGE", AddCustomer.txtAge.Text)
        cmd.Parameters.AddWithValue("@EMAIL", AddCustomer.txtEmail.Text)
        cmd.Parameters.AddWithValue("@CONTACT", AddCustomer.txtContact.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Customer has been added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub

    Sub InsertRoom()
        con.Open()
        cmd = New MySqlCommand("Insert into room (room_no, room_type) values (@RN, @RT)", con)
        cmd.Parameters.AddWithValue("@RN", AddRoom.txtRoomNo.Text)
        cmd.Parameters.AddWithValue("@RT", AddRoom.txtRName.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Room has been added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub

    Sub InsertReservation()
        con.Open()
        cmd = New MySqlCommand("Insert into reservation (customer_no, room_num, pax, date_from, date_to) values (@CN, @RN, @PAX, @FROM, @TO)", con)
        cmd.Parameters.AddWithValue("@CN", AddReservation.txtCustomerNo.Text)
        cmd.Parameters.AddWithValue("@RN", AddReservation.txtRoomNo.Text)
        cmd.Parameters.AddWithValue("@PAX", AddReservation.txtPax.Text)
        cmd.Parameters.AddWithValue("@FROM", AddReservation.dtpFrom.Text)
        cmd.Parameters.AddWithValue("@TO", AddReservation.dtpTo.Text)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub


    'DELETE DATA
    Sub DeleteCustomer()
        con.Open()
        cmd = New MySqlCommand("Delete from customer where customer_id = @CI", con)
        cmd.Parameters.AddWithValue("@CI", Cusid)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Customer data has been deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub
    Sub DeleteRoom()
        con.Open()
        cmd = New MySqlCommand("Delete from room where room_no = @RN", con)
        cmd.Parameters.AddWithValue("@RN", Roomid)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Room data has been deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub
    Sub DeleteReservation()
        con.Open()
        cmd = New MySqlCommand("Delete from reservation where reservation_id = @RI", con)
        cmd.Parameters.AddWithValue("@RI", Reserveid)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Customer reservation data has been deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub


    'SEARCH DATA
    Sub SearchCustomer(ID As Object, grid As Object)
        con.Open()
        grid.Rows.Clear()
        cmd = New MySqlCommand("select * from customer where customer_id like '%" & ID & "%'", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            grid.Rows.Add(read("customer_id"), read("lastname"), read("firstname"), read("age"), read("email"), read("contact_number"))
        End While
        read.Close()
        con.Close()
    End Sub

    Sub SearchRoom(ID As Object, grid As Object)
        con.Open()
        grid.Rows.Clear()
        cmd = New MySqlCommand("select * from room where room_no like '%" & ID & "%'", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            grid.Rows.Add(read("room_no"), read("room_type"))
        End While
        read.Close()
        con.Close()
    End Sub

    Sub SearchCustomerInReservation(ID As Object, grid As Object)
        con.Open()
        grid.Rows.Clear()
        cmd = New MySqlCommand("select * from customer where customer_id like '%" & ID & "%'", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            grid.Rows.Add(read("customer_id"), read("lastname"), read("firstname"), read("age"), read("email"), read("contact_number"))
        End While
        read.Close()
        con.Close()
    End Sub

    Sub SearchReservation(ID As Object, grid As Object)
        con.Open()
        grid.Rows.Clear()
        cmd = New MySqlCommand("select * from reservation left join customer on reservation_id = customer_id left join room on reservation_id = room_no where reservation_id like '%" & ID & "%'", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            grid.Rows.Add(read("reservation_id"), read("lastname"), read("firstname"), read("pax"), read("date_from"), read("date_to"))
        End While
        read.Close()
        con.Close()
    End Sub

    Sub GetCustomerID(inp As Object)
        Cusid = inp
    End Sub

    Sub GetRoomID(inp As Object)
        Roomid = inp
    End Sub

    Sub GetReserveID(inp As Object)
        Reserveid = inp
    End Sub

    'RETRIEVE DATA
    Sub RetrieveCustomer()
        con.Open()
        cmd = New MySqlCommand("SELECT * FROM customer WHERE customer_id = @ID", con)
        cmd.Parameters.AddWithValue("@ID", Cusid)
        Dim read As MySqlDataReader = cmd.ExecuteReader()
        If read.Read() Then
            MngCustomer.txtLN.Text = read.GetString("lastname")
            MngCustomer.txtFN.Text = read.GetString("firstname")
            MngCustomer.txtAge.Text = read.GetString("age")
            MngCustomer.txtEmail.Text = read.GetString("email")
            MngCustomer.txtContact.Text = read.GetString("contact_number")
        End If
        read.Close()
        con.Close()
    End Sub

    Sub RetrieveRoom()
        con.Open()
        cmd = New MySqlCommand("select * from room where room_no = @ID", con)
        cmd.Parameters.AddWithValue("@ID", Roomid)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            MngRoom.txtRoomNo.Text = read.GetString("room_no")
            MngRoom.txtRoomName.Text = read.GetString("room_type")
        End While
        read.Close()
        con.Close()
    End Sub

    Sub RetrieveReservation()
        con.Open()
        cmd = New MySqlCommand("select * from reservation left join room on reservation.reservation_id = room.room_no left join customer on reservation.reservation_id = customer.customer_id where reservation_id = @ID", con)
        cmd.Parameters.AddWithValue("@ID", Reserveid)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            MngReservation.txtCustomerNo.Text = read.GetString("customer_no")
            MngReservation.txtRoomNo.Text = read.GetString("room_num")
            MngReservation.txtPax.Text = read.GetString("pax")
            MngReservation.dtpFrom.Value = read.GetString("date_from")
            MngReservation.dtpTo.Value = read.GetString("date_to")
        End While
        read.Close()
        con.Close()
    End Sub

    'UPDATE
    Sub UpdateCustomer()
        con.Open()
        cmd = New MySqlCommand("update customer set lastname = @LN, firstname = @FN, age = @AGE, email = @EMAIL, contact_number = @CN where customer_id = @CI", con)
        cmd.Parameters.AddWithValue("@LN", MngCustomer.txtLN.Text)
        cmd.Parameters.AddWithValue("@FN", MngCustomer.txtFN.Text)
        cmd.Parameters.AddWithValue("@AGE", MngCustomer.txtAge.Text)
        cmd.Parameters.AddWithValue("@EMAIL", MngCustomer.txtEmail.Text)
        cmd.Parameters.AddWithValue("@CN", MngCustomer.txtContact.Text)
        cmd.Parameters.AddWithValue("@CI", Cusid)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Customer data has been updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub

    Sub UpdateRoom()
        con.Open()
        cmd = New MySqlCommand("update room set room_no = @RN, room_type = @RT where room_no = @RNum", con)
        cmd.Parameters.AddWithValue("@RN", MngRoom.txtRoomNo.Text)
        cmd.Parameters.AddWithValue("@RT", MngRoom.txtRoomName.Text)
        cmd.Parameters.AddWithValue("@RNum", Roomid)
        cmd.ExecuteNonQuery()
        MessageBox.Show("The room has been updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub

    Sub UpdateReservation()
        con.Open()
        cmd = New MySqlCommand("update reservation set customer_no = @CN, room_num = @RN, date_from = @DF, date_to = @DT where reservation_id = @RI", con)
        cmd.Parameters.AddWithValue("@CN", MngReservation.txtCustomerNo.Text)
        cmd.Parameters.AddWithValue("@RN", MngReservation.txtRoomNo.Text)
        cmd.Parameters.AddWithValue("@DF", MngReservation.dtpFrom.Text)
        cmd.Parameters.AddWithValue("@DT", MngReservation.dtpTo.Text)
        cmd.Parameters.AddWithValue("@RI", Reserveid)
        cmd.ExecuteNonQuery()
        MessageBox.Show("The reservation been updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub

    'VERIFY
    Function VerifyCustomer() As Boolean
        con.Open()
        cmd = New MySqlCommand("Select * from customer where customer_id = @CI", con)
        cmd.Parameters.AddWithValue("@CI", AddReservation.txtCustomerNo.Text)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        If read.Read() Then
            read.Close()
            con.Close()
            Return True
        Else
            read.Close()
            con.Close()
            Return False
        End If
        read.Close()
        con.Close()
    End Function

    Function VerifyRoom() As Boolean
        con.Open()
        cmd = New MySqlCommand("Select * from room where room_no = @RN", con)
        cmd.Parameters.AddWithValue("@RN", AddReservation.txtRoomNo.Text)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        If read.Read() Then
            read.Close()
            con.Close()
            Return True
        Else
            read.Close()
            con.Close()
            Return False
        End If
        read.Close()
        con.Close()
    End Function

    Function VerifyReservation() As Boolean
        con.Open()
        cmd = New MySqlCommand("Select * from reservation where reservation_id = @RN", con)
        cmd.Parameters.AddWithValue("@RN", AddReservation.txtRoomNo.Text)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        If read.Read() Then
            read.Close()
            con.Close()
            Return True
        Else
            read.Close()
            con.Close()
            Return False
        End If
        read.Close()
        con.Close()
    End Function
End Module
