Module ValidationModule

    Function IsEmpty(text As String) As Boolean
        If text.Trim = "" Then
            MessageBox.Show("Tidak boleh kosong!")
            Return True
        End If
        Return False
    End Function

End Module