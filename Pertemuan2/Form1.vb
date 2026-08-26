Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Items.Add("Jakarta")
        ComboBox1.Items.Add("Bandung")
        ComboBox1.Items.Add("Surabaya")
        ComboBox1.Items.Add("Medan")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nama As String = TextBox1.Text
        Dim gender As String = ""
        If RadioButton1.Checked Then
            gender = "Laki-laki"
        ElseIf RadioButton2.Checked Then
            gender = "Perempuan"
        End If

        Dim hobi As String = ""
        If CheckBox1.Checked Then hobi &= "Membaca"
        If CheckBox2.Checked Then hobi &= "Menulis"
        If CheckBox3.Checked Then hobi &= "Tiduran"
        If CheckBox4.Checked Then hobi &= "Olahraga"

        Dim kota As String = ComboBox1.Text
        MessageBox.Show("Nama: " & nama & vbCrLf & "Jenis Kelamin: " & gender & vbCrLf & "Hobi: " & hobi & vbCrLf & "Kota: " & kota, "Data pendaftaran")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
