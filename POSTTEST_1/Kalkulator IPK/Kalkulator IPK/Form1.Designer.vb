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
        lblIPS = New Label()
        lblIPK = New Label()
        btnTambah = New Button()
        btnReset = New Button()
        txtIPS = New TextBox()
        txtIPK = New TextBox()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' lblIPS
        ' 
        lblIPS.AutoSize = True
        lblIPS.Location = New Point(284, 150)
        lblIPS.Name = "lblIPS"
        lblIPS.Size = New Size(139, 32)
        lblIPS.TabIndex = 0
        lblIPS.Text = "IP Semester"
        ' 
        ' lblIPK
        ' 
        lblIPK.AutoSize = True
        lblIPK.Location = New Point(284, 263)
        lblIPK.Name = "lblIPK"
        lblIPK.Size = New Size(143, 32)
        lblIPK.TabIndex = 1
        lblIPK.Text = "IP Kumulatif"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(676, 150)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(150, 46)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(284, 411)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(150, 46)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' txtIPS
        ' 
        txtIPS.Location = New Point(458, 150)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(200, 39)
        txtIPS.TabIndex = 4
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(458, 263)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(200, 39)
        txtIPK.TabIndex = 5
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(458, 338)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(0, 32)
        lblPredikat.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1077, 592)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(txtIPS)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(lblIPK)
        Controls.Add(lblIPS)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIPS As Label
    Friend WithEvents lblIPK As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredikat As Label

End Class
