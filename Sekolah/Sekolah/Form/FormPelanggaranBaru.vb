Public Class FormPelanggaranBaru
    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        FormPelanggaran.Show()
        Me.Close()
    End Sub
    Private Sub FormPelanggaranBaru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCMB()
    End Sub
    Private Sub BtnBersihkan_Click(sender As Object, e As EventArgs) Handles BtnBersihkan.Click
        TxtNIS.Text = ""
        TxtNama.Text = ""
        RtbKasus.Text = ""
        CmbJenisPelanggaran.SelectedItem = ""
        TxtPoinPelanggaran.Text = ""
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim data As New ClsEntKasuss
        data.noinduksiswa = TxtNIS.Text
        data.idpelanggaran = CmbJenisPelanggaran.SelectedValue.ToString
        data.namasiswa = TxtNama.Text
        data.ketkasus = RtbKasus.Text
        data.pointpelanggaran = TxtPoinPelanggaran.Text
        KontrolKasuss.InsertData(data)
        MessageBox.Show("Data telah terInput.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function fillCMB()
        Try
            CmbJenisPelanggaran.Items.Clear()
            Dim Data = KontrolPelanggaran.getDatacmb.Rows.Count
            Dim member = New Dictionary(Of String, String)
            For i = 0 To Data - 1
                member.Add(KontrolPelanggaran.getDatacmb.Rows.Item(i).Item(0).ToString, KontrolPelanggaran.getDatacmb.Rows.Item(i).Item(1).ToString)
            Next
            CmbJenisPelanggaran.DataSource = New BindingSource(member, Nothing)
            CmbJenisPelanggaran.DisplayMember = "Value"
            CmbJenisPelanggaran.ValueMember = "key"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
        End Try

    End Function


End Class