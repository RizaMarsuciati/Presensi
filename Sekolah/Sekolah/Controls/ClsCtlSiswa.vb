Imports System.Data.OleDb
Imports Sekolah

Public Class ClsCtlSiswa : Implements InfProses


    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Try
            Dim sql = "delete from siswa where nis='" + kunci + "'"
            CMD = New OleDbCommand(sql, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Try
            Dim data As New ClsEntSiswa
            data = Ob
            Dim sql = "INSERT INTO SISWA VALUES ('" + data.noinduksiswa + "', '" + data.idkelas + "', '" + data.idthang + "', '" + data.namasiswa + "', '" + data.jeniskelamin + "', '" + data.tempatlahir + "', '" + data.tanggallahir + "','" + data.alamatsiswa + "','" + data.notelp + "', '" + data.idkategori + "')"
            CMD = New OleDbCommand(sql, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select a.nis as 'NIS', a.nama as 'NAMA',a.jenkel as 'JENIS KELAMIN',a.tempat_lahir as 'TEMPAT LAHIR',a.tgl_lahir as 'TANGGAL LAHIR',a.alamat as 'ALAMAT',a.no_telp as 'NO TELP', b.daftar_kelas as 'KELAS', c.tahun as 'TAHUN ANGKATAN', d.nama_kategori as 'NAMA KELAS' from SISWA a INNER JOIN KELAS b ON a.id_kelas = b.id_kelas INNER JOIN THANG c ON a.id_thang = c.id_thang INNER JOIN KATEGORIKELAS d ON a.id_kategori = d.id_kategori", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Siswa")
            Dim grid As New DataView(DTS.Tables("Tabel_Siswa"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntSiswa
        data = Ob
        CMD = New OleDbCommand("Update SISWA set id_kelas ='" & data.idkelas & "',id_thang ='" & data.idthang & "',nama ='" & data.namasiswa & "',jenkel ='" & data.jeniskelamin & "',tempat_lahir ='" & data.tempatlahir & "',tgl_lahir ='" & data.tanggallahir & "',alamat ='" & data.alamatsiswa & "',no_telp ='" & data.notelp & "',id_kategori ='" & data.idkategori & "' where nis = '" & data.noinduksiswa & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
End Class
