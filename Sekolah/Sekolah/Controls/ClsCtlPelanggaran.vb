Imports System.Data.OleDb
Imports Sekolah

Public Class ClsCtlPelanggaran : Implements InfProses

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Try
            Dim sql = "delete from pelanggaran where id_pelanggaran='" + kunci + "'"
            CMD = New OleDbCommand(sql, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Try
            Dim data As New ClsEntPelanggaran
            data = Ob
            Dim sql = "INSERT INTO PELANGGARAN VALUES ('" + data.idpelanggaran + "', '" + data.jenispelanggaran + "', '" + data.pointpelanggaran + "')"
            CMD = New OleDbCommand(sql, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select id_pelanggaran as 'ID PELANGGARAN', jenis_pelanggaran as 'JENIS PELANGGARAN', poin_pelanggaran as 'POINT PELANGGARAN' from PELANGGARAN", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Pelanggaran")
            Dim grid As New DataView(DTS.Tables("Tabel_Pelanggaran"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function updateData(ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntPelanggaran
        data = ob
        CMD = New OleDbCommand("Update PELANGGARAN set jenis_pelanggaran ='" & data.jenispelanggaran & "',poin_pelanggaran ='" & data.pointpelanggaran & "' where id_pelanggaran = '" & data.idpelanggaran & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function getDatacmb() As DataTable
        Try
            DTA = New OleDbDataAdapter("Select * from PELANGGARAN", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Pelanggaran")
            Dim grid As New DataView(DTS.Tables("Tabel_Pelanggaran"))

            Return grid.ToTable
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
