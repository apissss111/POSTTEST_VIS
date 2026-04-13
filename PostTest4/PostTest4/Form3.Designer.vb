<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        txtNama = New TextBox()
        txtHP = New TextBox()
        txtAlamat = New TextBox()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(73, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 32)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(73, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 32)
        Label2.TabIndex = 1
        Label2.Text = "No.HP"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(73, 271)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 32)
        Label3.TabIndex = 2
        Label3.Text = "Alamat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(73, 358)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 32)
        Label4.TabIndex = 3
        Label4.Text = "Event"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(244, 99)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 39)
        txtNama.TabIndex = 4
        ' 
        ' txtHP
        ' 
        txtHP.Location = New Point(244, 180)
        txtHP.Name = "txtHP"
        txtHP.Size = New Size(200, 39)
        txtHP.TabIndex = 5
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(244, 271)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(200, 39)
        txtAlamat.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(244, 370)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(242, 40)
        ComboBox1.TabIndex = 7
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(802, 484)
        Controls.Add(ComboBox1)
        Controls.Add(txtAlamat)
        Controls.Add(txtHP)
        Controls.Add(txtNama)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHP As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
