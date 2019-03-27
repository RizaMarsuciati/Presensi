Imports System.Data.OleDb

Public Class FormTampil
    Public pilihan As String
    Private id As String
    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub RefreshGridSiswa()
        DTGrid = KontrolSiswa.tampilData.ToTable
        DGTampil.DataSource = DTGrid

        DGTampil.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub RefreshGridThang()
        DTGrid = KontrolThang.tampilData.ToTable
        DGTampil.DataSource = DTGrid

        DGTampil.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub RefreshGridJenisPelanggaran()
        DTGrid = KontrolPelanggaran.tampilData.ToTable
        DGTampil.DataSource = DTGrid

        DGTampil.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub RefreshGridKategoriKelas()
        DTGrid = KontrolKategoriKelas.tampilData.ToTable
        DGTampil.DataSource = DTGrid

        DGTampil.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub RefreshGridRemisi()
        DTGrid = KontrolRemisi.tampilData.ToTable
        DGTampil.DataSource = DTGrid

        DGTampil.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGTampil.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Form Tampil " + pilihan
        Label1.Text = "Data " + pilihan
        Select Case pilihan
            Case "Kategori Kelas"
                RefreshGridKategoriKelas()
            Case "Siswa"
                RefreshGridSiswa()
            Case "Tahun Angkatan"
                RefreshGridThang()
            Case "Pelanggaran"
                RefreshGridJenisPelanggaran()
            Case "Remisi"
                RefreshGridRemisi()
        End Select
    End Sub

    Private Sub DGTampil_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTampil.CellDoubleClick
        Dim i = DGTampil.CurrentRow.Index
        id = DGTampil.Item(0, i).Value
        MessageBox.Show("Selected Item's Primary key: " + id, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        If id = "" Then
            MessageBox.Show("No Data Selected.!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Select Case pilihan
                Case "Kategori Kelas"
                    KontrolKategoriKelas.deleteData(id)
                    RefreshGridKategoriKelas()
                Case "Siswa"
                    KontrolSiswa.deleteData(id)
                    RefreshGridSiswa()
                Case "Tahun Angkatan"
                    KontrolThang.deleteData(id)
                    RefreshGridThang()
                Case "Pelanggaran"
                    KontrolPelanggaran.deleteData(id)
                    RefreshGridJenisPelanggaran()
                Case "Remisi"
                    KontrolRemisi.deleteData(id)
                    RefreshGridRemisi()
            End Select
        End If

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        Select Case pilihan
            Case "Kategori Kelas"
                FormUpdateKategoriKelas.Show()
                Me.Close()
            Case "Siswa"
                FormUpdateSiswa.Show()
                Me.Close()
            Case "Tahun Angkatan"
                FormUpdateThang.Show()
                Me.Close()
            Case "Pelanggaran"
                FormUpdatePelanggaran.Show()
                Me.Close()
            Case "Remisi"
                FormUpdateRemisi.Show()
                Me.Close()
        End Select
    End Sub
End Class