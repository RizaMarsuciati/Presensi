Public Class FormUpdateSiswa
    Private Sub FormUpdateSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCMB()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnBersihkan_Click(sender As Object, e As EventArgs) Handles BtnBersihkan.Click
        TxtNIS.Text = ""
        TxtNama.Text = ""
        TxtNoTlp.Text = ""
        TxtAlamat.Text = ""
        TxtTempatLahir.Text = ""
        CmbJenisKelamin.SelectedItem = ""
        CmbKategoriKelas.SelectedItem = ""
        CmbKelas.SelectedItem = ""
        CmbTahunAngkatan.SelectedItem = ""
    End Sub

    Private Function fillCMB()
        Try
            CmbKelas.Items.Clear()
            CmbKategoriKelas.Items.Clear()
            CmbTahunAngkatan.Items.Clear()
            Dim data = KontrolKelas.getDatacmb.Rows.Count
            Dim member As New Dictionary(Of String, String)
            For i = 0 To data - 1
                member.Add(KontrolKelas.getDatacmb.Rows.Item(i).Item(0).ToString, KontrolKelas.getDatacmb.Rows.Item(i).Item(1).ToString)
            Next
            CmbKelas.DataSource = New BindingSource(member, Nothing)
            CmbKelas.DisplayMember = "Value"
            CmbKelas.ValueMember = "key"

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
            CmbTahunAngkatan.DataSource = New BindingSource(member, Nothing)
            CmbTahunAngkatan.DisplayMember = "Value"
            CmbTahunAngkatan.ValueMember = "key"


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

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        Dim data As New ClsEntSiswa
        data.noinduksiswa = TxtNIS.Text
        data.idkelas = CmbKelas.SelectedValue.ToString
        data.idkategori = CmbKategoriKelas.SelectedValue.ToString
        data.idthang = CmbTahunAngkatan.SelectedValue.ToString
        data.namasiswa = TxtNama.Text
        data.jeniskelamin = CmbJenisKelamin.SelectedValue.ToString
        data.tempatlahir = TxtTempatLahir.Text
        data.tanggallahir = DateTimePicker1.Text
        data.notelp = TxtNoTlp.Text
        data.alamatsiswa = TxtAlamat.Text
        MessageBox.Show(DateTimePicker1.Value + "," + DateTimePicker1.Text)
        KontrolSiswa.updateData(data)
        MessageBox.Show("Data telah terUpdate.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class