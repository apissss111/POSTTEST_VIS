Imports MySql.Data.MySqlClient
Imports System.Data

Module DataModule

    Function GetAllEvent() As DataTable
        Dim dt As New DataTable
        koneksi()
        Dim da As New MySqlDataAdapter("SELECT * FROM tbevent", conn)
        da.Fill(dt)
        Return dt
    End Function

    Function InsertEvent(nama As String, lokasi As String, tanggal As Date) As Boolean
        Try
            koneksi()
            Dim cmd As New MySqlCommand("INSERT INTO tbevent(nama_event,lokasi,tanggal) VALUES(@n,@l,@t)", conn)
            cmd.Parameters.AddWithValue("@n", nama)
            cmd.Parameters.AddWithValue("@l", lokasi)
            cmd.Parameters.AddWithValue("@t", tanggal)
            cmd.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function

    Function DeleteEvent(id As Integer) As Boolean
        Try
            koneksi()
            Dim cmd As New MySqlCommand("DELETE FROM tbevent WHERE id_event=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function

    Function SearchEvent(key As String) As DataTable
        Dim dt As New DataTable
        koneksi()
        Dim da As New MySqlDataAdapter("SELECT * FROM tbevent WHERE nama_event LIKE '%" & key & "%'", conn)
        da.Fill(dt)
        Return dt
    End Function

    Function InsertVolunteer(nama As String, hp As String, alamat As String, idevent As Integer) As Boolean
        Try
            koneksi()
            Dim cmd As New MySqlCommand("INSERT INTO tbvolunteer VALUES(NULL,@n,@h,@a,@e)", conn)
            cmd.Parameters.AddWithValue("@n", nama)
            cmd.Parameters.AddWithValue("@h", hp)
            cmd.Parameters.AddWithValue("@a", alamat)
            cmd.Parameters.AddWithValue("@e", idevent)
            cmd.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function

End Module