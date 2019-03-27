Imports System.Data.OleDb
Imports Sekolah

Public Class ClsCtlKategoriKelas : Implements InfProses

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Try
            Dim sql = "delete from kategorikelas where id_kategori='" + kunci + "'"
            CMD = New OleDbCommand(sql, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Try
            Dim data As New ClsEntKategoriKelas
            data = Ob
            Dim sql = "INSERT INTO KATEGORIKELAS VALUES ('" + data.idkategori + "', '" + data.namakategori + "', '" + data.idkelas + "')"
            CMD = New OleDbCommand(sql, BUKAKONEKSI)
            CMD.ExecuteNonQuery()


            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select a.id_kategori as 'ID KATEGORI KELAS', a.nama_kategori as 'KATEGORI KELAS', b.daftar_kelas 'KELAS' from KATEGORIKELAS a INNER JOIN KELAS b ON a.id_kelas = b.id_kelas", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_KategoriKelas")
            Dim grid As New DataView(DTS.Tables("Tabel_KategoriKelas"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntKategoriKelas
        data = Ob
        CMD = New OleDbCommand("Update KATEGORIKELAS set nama_kategori ='" & data.namakategori & "',id_kelas ='" & data.idkelas & "' where id_kategori = '" & data.idkategori & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD

    End Function

    Public Function getDatacmb() As DataTable
        Try
            DTA = New OleDbDataAdapter("Select * from KATEGORIKELAS", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_KategoriKelas")
            Dim grid As New DataView(DTS.Tables("Tabel_KategoriKelas"))

            Return grid.ToTable
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
