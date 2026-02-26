Public Class Form1

    ' Variabel global untuk menyimpan total dan jumlah semester
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        ' Validasi input
        If txtIPS.Text = "" Then
            MessageBox.Show("Masukkan IP Semester terlebih dahulu!")
            Exit Sub
        End If

        Dim ipSemester As Double

        If Double.TryParse(txtIPS.Text, ipSemester) Then

            ' Tambah ke total
            totalIP += ipSemester
            jumlahSemester += 1

            ' Hitung IPK (rata-rata)
            Dim ipk As Double = totalIP / jumlahSemester

            ' Tampilkan IPK (2 angka desimal)
            txtIPK.Text = Format(ipk, "0.00")

            ' Tentukan predikat
            If ipk >= 2.0 And ipk <= 2.75 Then
                lblPredikat.Text = "Cukup"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            Else
                lblPredikat.Text = "-"
            End If

            ' Kosongkan input setelah tambah
            txtIPS.Clear()
            txtIPS.Focus()

        Else
            MessageBox.Show("Input harus berupa angka!")
        End If

    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' Reset semua data
        totalIP = 0
        jumlahSemester = 0

        txtIPS.Clear()
        txtIPK.Clear()
        lblPredikat.Text = "-"

        txtIPS.Focus()

    End Sub

    Private Sub txtIPS_TextChanged(sender As Object, e As EventArgs) Handles txtIPS.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class