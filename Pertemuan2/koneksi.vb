Imports MySql.Data.MySqlClient
Public Class koneksi
    Private conn As MySqlConnection

    ' Fungsi untuk mengambil objek koneksi
    Public Function GetConn() As MySqlConnection
        Dim connString As String = "Server=localhost;Database=pemvisdatabase;Uid=root;Pwd=;"
        conn = New MySqlConnection(connString)
        Return conn
    End Function

    ' Sub/Method untuk tes apakah database sudah berhasil terkoneksi
    Public Sub CekKoneksi()
        Dim db As MySqlConnection = GetConn()
        Try
            db.Open()
            MessageBox.Show("Koneksi ke Database MySQL Berhasil!", "Status Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            db.Close() ' Tutup kembali setelah tes selesai
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal! Pesan Error: " & ex.Message, "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
