Imports System.Data.OleDb
Public Class FormDaftarPresensi
    Private id As String
    Public petugas As String
    Public kelas As String
    Public kategorikelas As String
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnBeranda_Click(sender As Object, e As EventArgs) Handles BtnBeranda.Click
        FormBeranda.Show()
        Me.Close()
    End Sub

    Private Sub Radio_Click(sender As Object, e As EventArgs) Handles RdbHadir.Click, RdbTanpaKet.Click, RdbSakit.Click, RdbIzin.Click

        If sender.Equals(RdbHadir) Then
            RtbKeterangan.Enabled = False
            RtbKeterangan.Text = ""
        ElseIf sender.Equals(RdbIzin) Then
            RtbKeterangan.Enabled = True
            RtbKeterangan.Text = ""
        ElseIf sender.Equals(RdbSakit) Then
            RtbKeterangan.Enabled = True
            RtbKeterangan.Text = ""
        ElseIf sender.Equals(RdbTanpaKet) Then
            RtbKeterangan.Enabled = False
            RtbKeterangan.Text = ""
        End If
    End Sub

    Private Sub FormDaftarPresensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RtbKeterangan.Enabled = False
        GroupPresensi.Visible = False
        LblTanggal.Text = "Tanggal : " + DateTime.Now.ToString("yyyy-MM-dd")
        'MessageBox.Show("kelas: " + kelas + "\nkategori: " + kategorikelas)
        RefreshGridSiswa()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        EntitasPresensi = New ClsEntPresensi
        If RdbHadir.Checked Then
            EntitasPresensi.statuspresensi = "Hadir"
        ElseIf RdbIzin.Checked Then
            EntitasPresensi.statuspresensi = "Izin"
        ElseIf RdbSakit.Checked Then
            EntitasPresensi.statuspresensi = "Sakit"
        ElseIf RdbTanpaKet.Checked Then
            EntitasPresensi.statuspresensi = "Absen"
        End If
        EntitasPresensi.noinduksiswa = id
        EntitasPresensi.keterangan = RtbKeterangan.Text
        EntitasPresensi.tanggalpresensi = DateTime.Now.ToString("yyyy-MM-dd")
        EntitasPresensi.idpetugas = petugas

        KontrolPresensi.InsertData(EntitasPresensi)
        MessageBox.Show("Data telah terInput.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        RefreshGridSiswa()
        GroupPresensi.Visible = False
    End Sub
    Private Sub RefreshGridSiswa()
        DTGrid = KontrolPresensi.ShowData(kelas, kategorikelas).ToTable
        DGDaftarPresensi.DataSource = DTGrid

        DGDaftarPresensi.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGDaftarPresensi.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGDaftarPresensi.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGDaftarPresensi.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGDaftarPresensi.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Private Sub DGDaftarPresensi_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDaftarPresensi.CellDoubleClick
        GroupPresensi.Visible = True
        Dim i = DGDaftarPresensi.CurrentRow.Index
        id = DGDaftarPresensi.Item(0, i).Value
    End Sub

    Private Sub LblKelas_Click(sender As Object, e As EventArgs) Handles LblKelas.Click

    End Sub
End Class