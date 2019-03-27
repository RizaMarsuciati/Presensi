Public Class FormUpdateRemisi
    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnBersihkan_Click(sender As Object, e As EventArgs) Handles BtnBersihkan.Click
        TxtIdRemisi.Text = ""
        TxtJenisRemisi.Text = ""
        TxtPointRemisi.Text = ""
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        Dim data As New ClsEntRemisi
        data.idremisi = TxtIdRemisi.Text
        data.keteranganremisi = TxtJenisRemisi.Text
        data.jumlahremisi = TxtPointRemisi.Text
        KontrolRemisi.updateData(data)
        MessageBox.Show("Data telah terUpdate.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class