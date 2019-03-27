Imports System.Data.OleDb
Imports Sekolah

Public Class ClsCtlKasuss : Implements InfProses

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function kodeBaru() As String
        DTA = New OleDbDataAdapter("select max(right(id_kasuss,5)) from kasuss", BUKAKONEKSI)
        DTS = New DataSet()
        DTA.Fill(DTS, "max_kode")
        Dim kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
        Dim baru = "KS" & Strings.Right("00" & kodeakhir + 1, 5) 'Strings.Right("00" & kodeakhir + 1, 5)

        Return baru
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Try
            Dim data As New ClsEntKasuss
            data = Ob
            Dim sql = "INSERT INTO KASUSS VALUES ('" + kodeBaru() + "', '" + data.noinduksiswa + "', '" + data.idpelanggaran + "', '" + data.namasiswa + "', '" + data.ketkasus + "', '" + data.pointpelanggaran + "')"
            CMD = New OleDbCommand(sql, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select b.nis as 'NIS', a.nama as 'NAMA',a.kasus as 'KASUS',c.jenis_pelanggaran as 'PELANGGARAN',a.point_pelanggaran as 'POIN PELANGGARAN' from KASUSS a INNER JOIN SISWA b ON a.nis = b.nis INNER JOIN PELANGGARAN c ON a.id_pelanggaran = c.id_pelanggaran", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kasuss")
            Dim grid As New DataView(DTS.Tables("Tabel_Kasuss"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Throw New NotImplementedException()
    End Function
End Class
