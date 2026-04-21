Imports MySql.Data.MySqlClient
'mysql connection saya gabisa bang depedenci nya jadi pake mysqlclient

Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        koneksi()

        Dim cmd As New MySqlCommand("SELECT * FROM tbuser WHERE username=@u AND password=@p", conn)
        cmd.Parameters.AddWithValue("@u", txtUser.Text)
        cmd.Parameters.AddWithValue("@p", txtPass.Text)

        Dim rd As MySqlDataReader = cmd.ExecuteReader()

        If rd.Read() Then
            rd.Close()

            If rd("role").ToString() = "admin" Then
                Form2.Show()
            Else
                Form3.Show()
            End If

            Me.Hide()
        Else
            rd.Close()
            MessageBox.Show("Login gagal")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class