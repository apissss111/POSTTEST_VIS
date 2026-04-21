<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnTambah = New Button()
        btnHapus = New Button()
        DataGridView1 = New DataGridView()
        Label6 = New Label()
        txtCari = New TextBox()
        txtNama = New TextBox()
        txtLokasi = New TextBox()
        txtKuota = New TextBox()
        txtDesk = New TextBox()
        txtID = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 32)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(55, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 32)
        Label2.TabIndex = 1
        Label2.Text = "Lokasi"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(55, 259)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 32)
        Label3.TabIndex = 2
        Label3.Text = "Tanggal"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(55, 342)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 32)
        Label4.TabIndex = 3
        Label4.Text = "Kuota"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(55, 415)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 32)
        Label5.TabIndex = 4
        Label5.Text = "Desk"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(68, 510)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(150, 46)
        btnTambah.TabIndex = 6
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(302, 510)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 46)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(55, 572)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.Size = New Size(973, 251)
        DataGridView1.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(678, 224)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 32)
        Label6.TabIndex = 9
        Label6.Text = "Cari"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(756, 224)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(200, 39)
        txtCari.TabIndex = 10
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(198, 107)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 39)
        txtNama.TabIndex = 11
        ' 
        ' txtLokasi
        ' 
        txtLokasi.Location = New Point(198, 171)
        txtLokasi.Name = "txtLokasi"
        txtLokasi.Size = New Size(200, 39)
        txtLokasi.TabIndex = 12
        ' 
        ' txtKuota
        ' 
        txtKuota.Location = New Point(198, 335)
        txtKuota.Name = "txtKuota"
        txtKuota.Size = New Size(200, 39)
        txtKuota.TabIndex = 14
        ' 
        ' txtDesk
        ' 
        txtDesk.Location = New Point(198, 408)
        txtDesk.Name = "txtDesk"
        txtDesk.Size = New Size(200, 39)
        txtDesk.TabIndex = 15
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(828, 572)
        txtID.Name = "txtID"
        txtID.Size = New Size(200, 39)
        txtID.TabIndex = 16
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(198, 259)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(400, 39)
        DateTimePicker1.TabIndex = 17
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(1084, 835)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtID)
        Controls.Add(txtDesk)
        Controls.Add(txtKuota)
        Controls.Add(txtLokasi)
        Controls.Add(txtNama)
        Controls.Add(txtCari)
        Controls.Add(Label6)
        Controls.Add(DataGridView1)
        Controls.Add(btnHapus)
        Controls.Add(btnTambah)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents txtKuota As TextBox
    Friend WithEvents txtDesk As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
