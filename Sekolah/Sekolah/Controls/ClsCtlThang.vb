Imports System.Data.OleDb
Imports Sekolah

Public Class ClsCtlThang : Implements InfProses

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Try
            Dim sql = "delete from thang where id_thang='" + kunci + "'"
            CMD = New OleDbCommand(sql, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Try
            Dim data As New ClsEntThang
            data = Ob
            Dim sql = "INSERT INTO THANG VALUES ('" + data.idthang + "', '" + data.tahunangkatan + "')"
            CMD = New OleDbCommand(sql, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select id_thang as 'ID TAHUN ANGKATAN', tahun as 'TAHUN ANGKATAN' from THANG", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Thang")
            Dim grid As New DataView(DTS.Tables("Tabel_Thang"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntThang
        data = Ob
        CMD = New OleDbCommand("Update THANG set tahun ='" & data.tahunangkatan & "' where id_thang = '" & data.idthang & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function getDatacmb() As DataTable
        Try
            DTA = New OleDbDataAdapter("Select * from THANG", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Thang")
            Dim grid As New DataView(DTS.Tables("Tabel_Thang"))

            Return grid.ToTable
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
