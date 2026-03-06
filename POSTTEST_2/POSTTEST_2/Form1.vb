Public Class Form1

    'FUNCTION menampilkan daftar buku
    Function TampilBuku() As String

        Dim hasil As String = ""

        For i As Integer = 0 To jumlah - 1
            hasil &= judulBuku(i) & " (" & genreBuku(i) & ")" & vbCrLf
        Next

        Return hasil

    End Function


    'PROCEDURE tambah buku (ByVal)
    Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        judulBuku(jumlah) = judul
        genreBuku(jumlah) = genre
        jumlah += 1

    End Sub


    'PROCEDURE hapus buku
    Sub HapusBuku(ByVal judul As String)

        For i As Integer = 0 To jumlah - 1

            If judulBuku(i).ToLower = judul.ToLower Then

                For j As Integer = i To jumlah - 2
                    judulBuku(j) = judulBuku(j + 1)
                    genreBuku(j) = genreBuku(j + 1)
                Next

                jumlah -= 1
                Exit For

            End If

        Next

    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If txtJudul.Text = "" Or txtGenre.Text = "" Then
            MessageBox.Show("Isi judul dan genre buku")
            Exit Sub
        End If

        TambahBuku(txtJudul.Text, txtGenre.Text)

        txtDaftar.Text = TampilBuku()

        txtJudul.Clear()
        txtGenre.Clear()

    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If txtHapus.Text = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus")
            Exit Sub
        End If

        HapusBuku(txtHapus.Text)

        txtDaftar.Text = TampilBuku()

        txtHapus.Clear()

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Data awal seperti di gambar soal
        TambahBuku("Harry Potter", "Fantasi")
        TambahBuku("Sherlock Holmes", "Misteri")

        txtDaftar.Text = TampilBuku()

    End Sub

End Class