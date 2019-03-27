Imports System.Data.OleDb
Imports Sekolah

Public Class ClsCtlRemisi : Implements InfProses

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Try
            Dim sql = "delete from REMISI where id_remisi='" + kunci + "'"
            CMD = New OleDbCommand(sql, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Try
            Dim data As New ClsEntRemisi
            data = Ob
            Dim sql = "INSERT INTO REMISI VALUES ('" + data.idremisi + "', '" + data.jumlahremisi + "', '" + data.keteranganremisi + "')"
            CMD = New OleDbCommand(sql, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select id_remisi as 'ID REMISI', jml_remisi as 'JUMLAH REMISI', ket_remisi as 'KTERANGAN REMISI' from REMISI", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Remisi")
            Dim grid As New DataView(DTS.Tables("Tabel_Remisi"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntRemisi
        data = Ob
        CMD = New OleDbCommand("Update REMISI set jml_remisi ='" & data.jumlahremisi & "',ket_remisi ='" & data.keteranganremisi & "' where id_remisi = '" & data.idremisi & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
End Class
