Imports MySql.Data.MySqlClient
Imports System.Data
'mysql connection saya gabisa bang depedenci nya jadi pake mysqlclient

Public Class Form2

    Sub LoadData()
        DataGridView1.DataSource = GetAllEvent()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        txtID.Visible = False
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If InsertEvent(txtNama.Text, txtLokasi.Text, DateTimePicker1.Value) Then
            MessageBox.Show("Berhasil tambah")
            LoadData()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DeleteEvent(txtID.Text) Then
            MessageBox.Show("Berhasil hapus")
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            txtID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        DataGridView1.DataSource = SearchEvent(txtCari.Text)
    End Sub

End Class