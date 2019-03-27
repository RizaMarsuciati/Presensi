Imports System.Data.OleDb
Imports Sekolah

Public Class ClsCtlKelas : Implements InfProses

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData

    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Try
            Dim data As New ClsEntKelas
            data = Ob
            Dim sql = "INSERT INTO KELAS VALUES ('" + data.idkelas + "', '" + data.daftarkelas + "')"
            CMD = New OleDbCommand(sql, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from KELAS", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kelas")
            Dim grid As New DataView(DTS.Tables("Tabel_Kelas"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Throw New NotImplementedException()
    End Function
    Public Function getDatacmb() As DataTable
        Try
            DTA = New OleDbDataAdapter("Select * from KELAS", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kelas")
            Dim grid As New DataView(DTS.Tables("Tabel_Kelas"))

            Return grid.ToTable
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
