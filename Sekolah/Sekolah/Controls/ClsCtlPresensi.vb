Imports System.Data.OleDb
Imports Sekolah

Public Class ClsCtlPresensi : Implements InfProses
    Private id_kelas As String
    Private id_kategori As String

    Public Property idkelas() As String
        Get
            Return id_kelas
        End Get
        Set(value As String)
            id_kelas = value
        End Set
    End Property

    Public Property idkategori() As String
        Get
            Return id_kategori
        End Get
        Set(value As String)
            id_kategori = value
        End Set
    End Property

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select a.nama As 'Nama', a.jenkel as 'Gender', b.tgl_presensi as 'Tanggal', b.Status as 'Status', b.ket as 'keterangan' from siswa a inner join PRESENSI b on a.nis = b.nis Where a.Nama like '%" + kunci + "%' OR a.alamat like '%" + kunci + "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Presensi")
            Dim grid As New DataView(DTS.Tables("Tabel_Presensi"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ShowData(kelas As String, kategori As String) As DataView
        Try
            DTA = New OleDbDataAdapter("Select a.nis as 'NIS',a.nama as 'NAMA', a.jenkel as 'JENIS KELAMIN', a.tgl_lahir as 'TANGGAL LAHIR', a.alamat as 'ALAMAT' from SISWA a where a.nis not IN(select nis from PRESENSI where tgl_presensi = CONVERT(date, CURRENT_TIMESTAMP)) AND a.id_kelas= '" + kelas + "' AND a.id_kategori = '" + kategori + "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Presensi")
            Dim grid As New DataView(DTS.Tables("Tabel_Presensi"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function kodeBaru() As String
        DTA = New OleDbDataAdapter("select max(right(id_presensi,5)) from presensi", BUKAKONEKSI)
        DTS = New DataSet()
        DTA.Fill(DTS, "max_kode")
        Dim kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
        Dim baru = "PR" & Strings.Right("0000" & kodeakhir + 1, 5) 'Strings.Right("000" & kodeakhir + 1, 5)

        Return baru
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Try
            Dim data As New ClsEntPresensi
            data = Ob
            Dim sql = "INSERT INTO PRESENSI VALUES ('" + kodeBaru() + "', '" + data.idpetugas + "', '" + data.noinduksiswa + "', '" + data.tanggalpresensi + "', '" + data.statuspresensi + "', '" + data.keterangan + "')"
            CMD = New OleDbCommand(sql, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select a.nis as 'NIS',a.nama as 'NAMA', a.jenkel as 'JENIS KELAMIN', a.tgl_lahir as 'TANGGAL LAHIR', a.alamat as 'ALAMAT' from SISWA a where a.nis not IN(select nis from PRESENSI where tgl_presensi = CONVERT(date, CURRENT_TIMESTAMP)) AND a.id_kelas= '" + id_kelas + "' AND a.id_kategori = '" + id_kategori + "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Presensi")
            Dim grid As New DataView(DTS.Tables("Tabel_Presensi"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Throw New NotImplementedException()
    End Function
End Class
