Public Class FormDaftarKelas
    Public petugas As String
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)
    End Sub

    Private Sub BtnMasuk7_Click(sender As Object, e As EventArgs) Handles BtnMasuk7.Click
        With FormKategoriKelas
            .LblA.Text = "VII A"
            .LblB.Text = "VII B"
            .LblC.Text = "VII C"
            .LblD.Text = "VII D"
            .LblE.Text = "VII E"
            ._kelas = "k001"
        End With
        With FormKategoriKelas
            .petugas = petugas
        End With
        FormKategoriKelas.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMasuk8_Click(sender As Object, e As EventArgs) Handles BtnMasuk8.Click
        With FormKategoriKelas
            .LblA.Text = "VIII A"
            .LblB.Text = "VIII B"
            .LblC.Text = "VIII C"
            .LblD.Text = "VIII D"
            .LblE.Text = "VIII E"
            ._kelas = "k002"
        End With
        With FormKategoriKelas
            .petugas = petugas
        End With
        FormKategoriKelas.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMasuk9_Click(sender As Object, e As EventArgs) Handles BtnMasuk9.Click
        With FormKategoriKelas
            .LblA.Text = "IX A"
            .LblB.Text = "IX B"
            .LblC.Text = "IX C"
            .LblD.Text = "IX D"
            .LblE.Text = "IX E"
            ._kelas = "k003"
        End With
        With FormKategoriKelas
            .petugas = petugas
        End With
        FormKategoriKelas.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        FormBeranda.Show()
        Me.Hide()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class