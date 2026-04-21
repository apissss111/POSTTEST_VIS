Imports MySql.Data.MySqlClient

Module Module1
    Public conn As MySqlConnection

    Sub koneksi()
        If conn Is Nothing Then
            conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_volunteer")
        End If

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module