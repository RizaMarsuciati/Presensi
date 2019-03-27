Public Class FormUpdateKategoriKelas
    Private Sub BtnBersihkan_Click(sender As Object, e As EventArgs) Handles BtnBersihkan.Click
        TxtIDKategoriKelas.Text = ""
        TxtKategoriKelas.Text = ""
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        Dim data As New ClsEntKategoriKelas
        data.idkategori = TxtIDKategoriKelas.Text
        data.namakategori = TxtKategoriKelas.Text
        data.idkelas = CmbKelas.SelectedValue.ToString
        KontrolKategoriKelas.updateData(data)
        MessageBox.Show("Data telah terUpdate.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Function fillCMB()
        Try
            CmbKelas.Items.Clear()
            Dim Data = KontrolKelas.getDatacmb.Rows.Count
            Dim member = New Dictionary(Of String, String)
            For i = 0 To Data - 1
                member.Add(KontrolKelas.getDatacmb.Rows.Item(i).Item(0).ToString, KontrolKelas.getDatacmb.Rows.Item(i).Item(1).ToString)
            Next
            CmbKelas.DataSource = New BindingSource(member, Nothing)
            CmbKelas.DisplayMember = "Value"
            CmbKelas.ValueMember = "key"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
        End Try

    End Function

    Private Sub FormUpdateKategoriKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCMB()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class