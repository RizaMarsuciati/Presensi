Public Class FormUpdateThang
    Private Sub FormUpdateThang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnBersihkan_Click(sender As Object, e As EventArgs) Handles BtnBersihkan.Click
        TxtIdThang.Text = ""
        TxtThang.Text = ""
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        Dim data As New ClsEntThang
        data.idthang = TxtIdThang.Text
        data.tahunangkatan = TxtThang.Text
        KontrolThang.updateData(data)
        MessageBox.Show("Data telah terUpdate.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class