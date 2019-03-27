Public Class FormAdmin

    Private Sub BtnSimpanThang_Click(sender As Object, e As EventArgs) Handles BtnSimpanThang.Click
        Dim data As New ClsEntThang
        data.idthang = TxtIdThang.Text
        data.tahunangkatan = TxtThang.Text

        KontrolThang.InsertData(data)
        MessageBox.Show("Data telah terInput.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        FormLogin.Show()
        Me.Close()
    End Sub


    Private Sub BtnSimpanKategoriKelas_Click(sender As Object, e As EventArgs) Handles BtnSimpanKategoriKelas.Click
        Dim data As New ClsEntKategoriKelas
        data.idkategori = TxtIdKategoriKelas.Text
        data.namakategori = TxtKategoriKelas.Text
        data.idkelas = CmbKelas.SelectedValue.ToString
        KontrolKategoriKelas.InsertData(data)
        MessageBox.Show("Data telah terInput.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnBersihkanKategoriKelas_Click(sender As Object, e As EventArgs) Handles BtnBersihkanKategoriKelas.Click
        TxtIdKategoriKelas.Text = ""
        TxtKategoriKelas.Text = ""
        CmbKelas.SelectedItem = ""
    End Sub

    Private Sub BtnSimpanPelanggaran_Click(sender As Object, e As EventArgs) Handles BtnSimpanPelanggaran.Click
        Dim data As New ClsEntPelanggaran
        data.idpelanggaran = TxtIdJenisPelanggaran.Text
        data.jenispelanggaran = TxtJenisPelanggaran.Text
        data.pointpelanggaran = TxtPointPelanggaran.Text

        KontrolPelanggaran.InsertData(data)
        MessageBox.Show("Data telah terInput.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnBersihkanPelanggaran_Click(sender As Object, e As EventArgs) Handles BtnBersihkanPelanggaran.Click
        TxtIdJenisPelanggaran.Text = ""
        TxtJenisPelanggaran.Text = ""
        TxtPointPelanggaran.Text = ""
    End Sub

    Private Sub BtnSimpanSiswa_Click(sender As Object, e As EventArgs) Handles BtnSimpanSiswa.Click
        Dim data As New ClsEntSiswa
        data.noinduksiswa = TxtNIS.Text
        data.idkelas = CmbKelas1.SelectedValue.ToString
        data.idkategori = CmbKategoriKelas.SelectedValue.ToString
        data.idthang = CmbThang.SelectedValue.ToString
        data.namasiswa = TxtNama.Text
        data.jeniskelamin = CmbJenisKelamin.SelectedValue.ToString
        data.tempatlahir = TxtTempatLahir.Text
        data.tanggallahir = DateTimePicker1.Text
        data.notelp = TxtNoTelp.Text
        data.alamatsiswa = TxtAlamat.Text
        MessageBox.Show(DateTimePicker1.Value + "," + DateTimePicker1.Text)
        KontrolSiswa.InsertData(data)
        MessageBox.Show("Data telah terInput.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnLihatThang_Click(sender As Object, e As EventArgs) Handles BtnLihatThang.Click
        With FormTampil
            .pilihan = "Tahun Angkatan"
        End With
        FormTampil.Show()
    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCMB()


    End Sub

    Private Sub BtnBersihkanThang_Click(sender As Object, e As EventArgs) Handles BtnBersihkanThang.Click
        TxtIdThang.Text = ""
        TxtThang.Text = ""
    End Sub

    Private Sub BtnBersihkanSiswa_Click(sender As Object, e As EventArgs) Handles BtnBersihkanSiswa.Click
        TxtNIS.Text = ""
        CmbKelas.SelectedItem = ""
        CmbKategoriKelas.SelectedItem = ""
        CmbThang.SelectedItem = ""
        TxtNama.Text = ""
        CmbJenisKelamin.SelectedItem = ""
        TxtNoTelp.Text = ""
        TxtAlamat.Text = ""
        TxtTempatLahir.Text = ""

    End Sub

    Private Sub BtnLihat_Click(sender As Object, e As EventArgs) Handles BtnLihat.Click
        With FormTampil
            .pilihan = "Kategori Kelas"
        End With
        FormTampil.Show()
    End Sub

    Private Sub BtnLihatPelanggan_Click(sender As Object, e As EventArgs) Handles BtnLihatPelanggan.Click
        With FormTampil
            .pilihan = "Pelanggaran"
        End With
        FormTampil.Show()
    End Sub

    Private Sub BtnLihatSiswa_Click(sender As Object, e As EventArgs) Handles BtnLihatSiswa.Click
        With FormTampil
            .pilihan = "Siswa"
        End With
        FormTampil.Show()
    End Sub

    Private Sub BtnLihatRemisi_Click(sender As Object, e As EventArgs) Handles BtnLihatRemisi.Click
        With FormTampil
            .pilihan = "Remisi"
        End With
        FormTampil.Show()
    End Sub

    Private Sub BtnSimpanRemisi_Click(sender As Object, e As EventArgs) Handles BtnSimpanRemisi.Click
        Dim data As New ClsEntRemisi
        data.idremisi = TxtIdRemisi.Text
        data.jumlahremisi = TxtJmlRemisi.Text
        data.keteranganremisi = TxtKetRemisi.Text

        KontrolRemisi.InsertData(data)
        MessageBox.Show("Data telah terInput.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnBersihkanRemisi_Click(sender As Object, e As EventArgs) Handles BtnBersihkanRemisi.Click
        TxtIdRemisi.Text = ""
        TxtKetRemisi.Text = ""
        TxtJmlRemisi.Text = ""
    End Sub

    Private Function fillCMB()
        Try
            CmbKelas.Items.Clear()
            CmbKelas1.Items.Clear()
            CmbKategoriKelas.Items.Clear()
            Dim data = KontrolKelas.getDatacmb.Rows.Count
            Dim member As New Dictionary(Of String, String)
            For i = 0 To data - 1
                member.Add(KontrolKelas.getDatacmb.Rows.Item(i).Item(0).ToString, KontrolKelas.getDatacmb.Rows.Item(i).Item(1).ToString)
            Next
            CmbKelas.DataSource = New BindingSource(member, Nothing)
            CmbKelas.DisplayMember = "Value"
            CmbKelas.ValueMember = "key"

            data = KontrolKelas.getDatacmb.Rows.Count
            member = New Dictionary(Of String, String)
            For i = 0 To data - 1
                member.Add(KontrolKelas.getDatacmb.Rows.Item(i).Item(0).ToString, KontrolKelas.getDatacmb.Rows.Item(i).Item(1).ToString)
            Next
            CmbKelas1.DataSource = New BindingSource(member, Nothing)
            CmbKelas1.DisplayMember = "Value"
            CmbKelas1.ValueMember = "key"

            data = KontrolKategoriKelas.getDatacmb.Rows.Count
            member = New Dictionary(Of String, String)
            For i = 0 To data - 1
                member.Add(KontrolKategoriKelas.getDatacmb.Rows.Item(i).Item(0).ToString, KontrolKategoriKelas.getDatacmb.Rows.Item(i).Item(1).ToString)
            Next
            CmbKategoriKelas.DataSource = New BindingSource(member, Nothing)
            CmbKategoriKelas.DisplayMember = "Value"
            CmbKategoriKelas.ValueMember = "key"


            data = KontrolThang.getDatacmb.Rows.Count
            member = New Dictionary(Of String, String)
            For i = 0 To data - 1
                member.Add(KontrolThang.getDatacmb.Rows.Item(i).Item(0).ToString, KontrolThang.getDatacmb.Rows.Item(i).Item(1).ToString)
            Next
            CmbThang.DataSource = New BindingSource(member, Nothing)
            CmbThang.DisplayMember = "Value"
            CmbThang.ValueMember = "key"

            member = New Dictionary(Of String, String)
            member.Add("0", "<Choose One>")
            member.Add("L", "Laki-Laki")
            member.Add("P", "Perempuan")
            CmbJenisKelamin.DataSource = New BindingSource(member, Nothing)
            CmbJenisKelamin.DisplayMember = "Value"
            CmbJenisKelamin.ValueMember = "key"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
        End Try


    End Function


End Class