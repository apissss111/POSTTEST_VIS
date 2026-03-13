<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        picFoto = New PictureBox()
        btnBrowse = New Button()
        lblNama = New Label()
        lblUmur = New Label()
        lblTelpon = New Label()
        lblTanggal = New Label()
        lblAlamat = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelpon = New TextBox()
        txtAlamat = New TextBox()
        dtTanggal = New DateTimePicker()
        grpKelamin = New GroupBox()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        grpHobby = New GroupBox()
        cbMembaca = New CheckBox()
        cbGaming = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMusik = New CheckBox()
        cbTravel = New CheckBox()
        cbCoding = New CheckBox()
        cbMenonton = New CheckBox()
        cbFoto = New CheckBox()
        cbMasak = New CheckBox()
        cbGambar = New CheckBox()
        btnCetak = New Button()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpKelamin.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(12, 23)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(256, 442)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(71, 492)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(120, 94)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        ' 
        ' lblNama
        ' 
        lblNama.Location = New Point(279, 23)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(94, 39)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.Location = New Point(279, 89)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(87, 37)
        lblUmur.TabIndex = 4
        lblUmur.Text = "Umur"
        ' 
        ' lblTelpon
        ' 
        lblTelpon.Location = New Point(279, 222)
        lblTelpon.Name = "lblTelpon"
        lblTelpon.Size = New Size(141, 53)
        lblTelpon.TabIndex = 6
        lblTelpon.Text = "No Telpon"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.Location = New Point(279, 149)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(193, 73)
        lblTanggal.TabIndex = 8
        lblTanggal.Text = "Tanggal Lahir"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.Location = New Point(286, 341)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(126, 53)
        lblAlamat.TabIndex = 10
        lblAlamat.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(426, 23)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(507, 39)
        txtNama.TabIndex = 3
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(426, 86)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(504, 39)
        txtUmur.TabIndex = 5
        ' 
        ' txtTelpon
        ' 
        txtTelpon.Location = New Point(426, 222)
        txtTelpon.Name = "txtTelpon"
        txtTelpon.Size = New Size(504, 39)
        txtTelpon.TabIndex = 7
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(436, 329)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(427, 78)
        txtAlamat.TabIndex = 11
        ' 
        ' dtTanggal
        ' 
        dtTanggal.Location = New Point(475, 149)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(455, 39)
        dtTanggal.TabIndex = 9
        ' 
        ' grpKelamin
        ' 
        grpKelamin.Controls.Add(rbLaki)
        grpKelamin.Controls.Add(rbPerempuan)
        grpKelamin.Location = New Point(286, 472)
        grpKelamin.Name = "grpKelamin"
        grpKelamin.Size = New Size(273, 126)
        grpKelamin.TabIndex = 12
        grpKelamin.TabStop = False
        grpKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbLaki
        ' 
        rbLaki.Location = New Point(26, 31)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(159, 47)
        rbLaki.TabIndex = 0
        rbLaki.Text = "Laki-laki"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.Location = New Point(26, 71)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(174, 55)
        rbPerempuan.TabIndex = 1
        rbPerempuan.Text = "Perempuan"
        ' 
        ' grpHobby
        ' 
        grpHobby.Controls.Add(cbMembaca)
        grpHobby.Controls.Add(cbGaming)
        grpHobby.Controls.Add(cbOlahraga)
        grpHobby.Controls.Add(cbMusik)
        grpHobby.Controls.Add(cbTravel)
        grpHobby.Controls.Add(cbCoding)
        grpHobby.Controls.Add(cbMenonton)
        grpHobby.Controls.Add(cbFoto)
        grpHobby.Controls.Add(cbMasak)
        grpHobby.Controls.Add(cbGambar)
        grpHobby.Location = New Point(696, 451)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(713, 239)
        grpHobby.TabIndex = 13
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' cbMembaca
        ' 
        cbMembaca.Location = New Point(374, 36)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(171, 65)
        cbMembaca.TabIndex = 0
        cbMembaca.Text = "Membaca"
        ' 
        ' cbGaming
        ' 
        cbGaming.Location = New Point(196, 31)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(152, 68)
        cbGaming.TabIndex = 1
        cbGaming.Text = "Gaming"
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.Location = New Point(6, 38)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(156, 54)
        cbOlahraga.TabIndex = 2
        cbOlahraga.Text = "Olahraga"
        ' 
        ' cbMusik
        ' 
        cbMusik.Location = New Point(6, 111)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(116, 34)
        cbMusik.TabIndex = 3
        cbMusik.Text = "Musik"
        ' 
        ' cbTravel
        ' 
        cbTravel.Location = New Point(196, 111)
        cbTravel.Name = "cbTravel"
        cbTravel.Size = New Size(115, 34)
        cbTravel.TabIndex = 4
        cbTravel.Text = "Travel"
        ' 
        ' cbCoding
        ' 
        cbCoding.Location = New Point(374, 110)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(130, 37)
        cbCoding.TabIndex = 5
        cbCoding.Text = "Coding"
        ' 
        ' cbMenonton
        ' 
        cbMenonton.Location = New Point(6, 160)
        cbMenonton.Name = "cbMenonton"
        cbMenonton.Size = New Size(161, 55)
        cbMenonton.TabIndex = 6
        cbMenonton.Text = "Menonton"
        ' 
        ' cbFoto
        ' 
        cbFoto.Location = New Point(196, 176)
        cbFoto.Name = "cbFoto"
        cbFoto.Size = New Size(152, 39)
        cbFoto.TabIndex = 7
        cbFoto.Text = "Fotografi"
        ' 
        ' cbMasak
        ' 
        cbMasak.Location = New Point(374, 176)
        cbMasak.Name = "cbMasak"
        cbMasak.Size = New Size(148, 42)
        cbMasak.TabIndex = 8
        cbMasak.Text = "Memasak"
        ' 
        ' cbGambar
        ' 
        cbGambar.Location = New Point(510, 88)
        cbGambar.Name = "cbGambar"
        cbGambar.Size = New Size(196, 78)
        cbGambar.TabIndex = 9
        cbGambar.Text = "Menggambar"
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(250, 696)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(1137, 70)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak Kartu"
        ' 
        ' Form1
        ' 
        ClientSize = New Size(1418, 778)
        Controls.Add(picFoto)
        Controls.Add(btnBrowse)
        Controls.Add(lblNama)
        Controls.Add(txtNama)
        Controls.Add(lblUmur)
        Controls.Add(txtUmur)
        Controls.Add(lblTelpon)
        Controls.Add(txtTelpon)
        Controls.Add(txtAlamat)
        Controls.Add(lblTanggal)
        Controls.Add(dtTanggal)
        Controls.Add(lblAlamat)
        Controls.Add(grpKelamin)
        Controls.Add(grpHobby)
        Controls.Add(btnCetak)
        Name = "Form1"
        Text = "Form Input"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        grpKelamin.ResumeLayout(False)
        grpHobby.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button

    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTelpon As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblAlamat As Label

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelpon As TextBox
    Friend WithEvents txtAlamat As TextBox

    Friend WithEvents dtTanggal As DateTimePicker

    Friend WithEvents grpKelamin As GroupBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton

    Friend WithEvents grpHobby As GroupBox

    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbTravel As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbMenonton As CheckBox
    Friend WithEvents cbFoto As CheckBox
    Friend WithEvents cbMasak As CheckBox
    Friend WithEvents cbGambar As CheckBox

    Friend WithEvents btnCetak As Button

End Class