Public Class Form1

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim buka As New OpenFileDialog
        buka.Filter = "File Gambar|*.jpg;*.png;*.jpeg"

        If buka.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(buka.FileName)
        End If

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        Dim jk As String

        If rbLaki.Checked Then
            jk = "Laki-laki"
        Else
            jk = "Perempuan"
        End If

        Dim hobby As String = ""

        For Each c As Control In grpHobby.Controls
            If TypeOf c Is CheckBox Then
                If CType(c, CheckBox).Checked Then
                    hobby &= c.Text & ", "
                End If
            End If
        Next

        Form2.lblNamaKartu.Text = txtNama.Text
        Form2.lblUmurKartu.Text = txtUmur.Text
        Form2.lblTelponKartu.Text = txtTelpon.Text
        Form2.lblTanggalKartu.Text = dtTanggal.Text
        Form2.lblKelaminKartu.Text = jk
        Form2.lblHobbyKartu.Text = hobby
        Form2.lblAlamatKartu.Text = txtAlamat.Text

        Form2.picKartu.Image = picFoto.Image

        Form2.Show()

    End Sub

End Class