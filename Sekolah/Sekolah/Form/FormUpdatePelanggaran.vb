Public Class FormUpdatePelanggaran
    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnBersihkan_Click(sender As Object, e As EventArgs) Handles BtnBersihkan.Click
        TxtIdJenisPelanggaran.Text = ""
        TxtJenisPelanggaran.Text = ""
        TxtPointPelanggaran.Text = ""
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        Dim data As New ClsEntPelanggaran
        data.idpelanggaran = TxtIdJenisPelanggaran.Text
        data.jenispelanggaran = TxtJenisPelanggaran.Text
        data.pointpelanggaran = TxtPointPelanggaran.Text
        KontrolPelanggaran.updateData(data)
        MessageBox.Show("Data telah terUpdate.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub FormUpdatePelanggaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class