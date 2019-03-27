Public Class FormKategoriKelas
    Public petugas As String
    Public _kelas As String
    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        FormDaftarKelas.Show()
        Me.Hide()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnMasukA_Click(sender As Object, e As EventArgs) Handles BtnMasukA.Click
        With FormDaftarPresensi
            .LblKelas.Text = LblA.Text
            .petugas = petugas
            .kelas = _kelas
            .kategorikelas = "KK001"
        End With
        FormDaftarPresensi.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMasukB_Click(sender As Object, e As EventArgs) Handles BtnMasukB.Click
        With FormDaftarPresensi
            .LblKelas.Text = LblB.Text
            .petugas = petugas
            .kelas = _kelas
            .kategorikelas = "KK002"
        End With
        FormDaftarPresensi.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMasukC_Click(sender As Object, e As EventArgs) Handles BtnMasukC.Click
        With FormDaftarPresensi
            .LblKelas.Text = LblC.Text
            .petugas = petugas
            .kelas = _kelas
            .kategorikelas = "KK003"
        End With
        FormDaftarPresensi.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMasukD_Click(sender As Object, e As EventArgs) Handles BtnMasukD.Click
        With FormDaftarPresensi
            .LblKelas.Text = LblD.Text
            .petugas = petugas
            .kelas = _kelas
            .kategorikelas = "KK004"
        End With
        FormDaftarPresensi.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMasukE_Click(sender As Object, e As EventArgs) Handles BtnMasukE.Click
        With FormDaftarPresensi
            .LblKelas.Text = LblE.Text
            .petugas = petugas
            .kelas = _kelas
            .kategorikelas = "KK005"
        End With
        FormDaftarPresensi.Show()
        Me.Hide()
    End Sub
End Class