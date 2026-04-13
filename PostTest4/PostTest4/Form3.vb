Imports MySql.Data.MySqlClient
Imports System.Data
'mysql connection saya gabisa bang depedenci nya jadi pake mysqlclient

Public Class Form3

    Sub LoadEvent()
        ComboBox1.Items.Clear()

        Dim dt As DataTable = GetAllEvent()

        For Each r As DataRow In dt.Rows
            ComboBox1.Items.Add(r("id_event"))
        Next
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEvent()
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click

        If ComboBox1.Text = "" Then
            MessageBox.Show("Pilih event!")
            Exit Sub
        End If

        If InsertVolunteer(txtNama.Text, txtHP.Text, txtAlamat.Text, Val(ComboBox1.Text)) Then
            MessageBox.Show("Berhasil daftar")
        End If

    End Sub

End Class