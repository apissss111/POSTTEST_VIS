<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtJudul = New TextBox()
        Label2 = New Label()
        txtGenre = New TextBox()
        btnTambah = New Button()
        Label3 = New Label()
        txtHapus = New TextBox()
        btnHapus = New Button()
        txtDaftar = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(188, 182)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 32)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(358, 179)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(200, 39)
        txtJudul.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(188, 261)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 32)
        Label2.TabIndex = 2
        Label2.Text = "Genre"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(358, 261)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(200, 39)
        txtGenre.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(188, 369)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(150, 46)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(922, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 32)
        Label3.TabIndex = 5
        Label3.Text = "Judul Buku"
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(1114, 182)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(200, 39)
        txtHapus.TabIndex = 6
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(922, 369)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(175, 46)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' txtDaftar
        ' 
        txtDaftar.Location = New Point(542, 517)
        txtDaftar.Multiline = True
        txtDaftar.Name = "txtDaftar"
        txtDaftar.Size = New Size(290, 189)
        txtDaftar.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(314, 77)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 32)
        Label4.TabIndex = 10
        Label4.Text = "Tambah Buku"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(1040, 77)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 32)
        Label5.TabIndex = 11
        Label5.Text = "Hapus Buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1403, 824)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtDaftar)
        Controls.Add(btnHapus)
        Controls.Add(txtHapus)
        Controls.Add(Label3)
        Controls.Add(btnTambah)
        Controls.Add(txtGenre)
        Controls.Add(Label2)
        Controls.Add(txtJudul)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtDaftar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
