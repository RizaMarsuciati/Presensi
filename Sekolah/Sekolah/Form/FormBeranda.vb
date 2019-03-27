Public Class FormBeranda
    Public petugas As String
    Private Sub BtnMasukPresensi_Click(sender As Object, e As EventArgs) Handles BtnPresensi.Click
        With FormDaftarKelas
            .petugas = petugas
        End With
        FormDaftarKelas.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPelanggaran_Click(sender As Object, e As EventArgs) Handles BtnPelanggaran.Click
        FormPelanggaran.Show()
        Me.Hide()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        FormLogin.Show()
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRemisi.Click
        FormRemisi.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        FormCari.Show()
        Me.Hide()
    End Sub
End Class