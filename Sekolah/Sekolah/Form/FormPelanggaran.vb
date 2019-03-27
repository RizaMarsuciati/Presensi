Public Class FormPelanggaran
    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BtnInputPelanggaran_Click(sender As Object, e As EventArgs) Handles BtnInputPelanggaran.Click
        FormPelanggaranBaru.Show()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        FormBeranda.Show()
        Me.Close()
    End Sub

    Private Sub BtnPeraturan_Click(sender As Object, e As EventArgs) Handles BtnPeraturan.Click
        FormPengumuman.Show()
    End Sub

    Private Sub BtnDataPelanggar_Click(sender As Object, e As EventArgs) Handles BtnDataPelanggar.Click
        FormTampilDataPelanggar.Show()
    End Sub
End Class