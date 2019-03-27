Imports System.Data.OleDb
Imports System.IO
Public Class FormCari
    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        DGCari.DataSource = KontrolPresensi.cariData(TxtCari.Text).ToTable()
    End Sub
    Private Sub RefreshGrid()
        DTGrid = tampilData.ToTable
        DGCari.DataSource = DTGrid
    End Sub

    Public Function tampilData() As DataView
        Try
            DTA = New OleDbDataAdapter("Select a.nama As 'Nama', a.jenkel as 'Gender', b.tgl_presensi as 'Tanggal', b.status as 'Status', b.ket as 'keterangan' from siswa a inner join PRESENSI b on a.nis = b.nis", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Presensi")
            Dim grid As New DataView(DTS.Tables("Tabel_Presensi"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Private Sub FormCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub
    Dim FlNm As String
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If DGCari.RowCount = 0 Then Return

        Application.DoEvents()

        FlNm = "D:\Bismillah FP\sekolah v2\sekolah v2\Report\Report" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
        If File.Exists(FlNm) Then File.Delete(FlNm)
        ExportToExcel(DGCari)


        Process.Start("D:\Bismillah FP\sekolah v2\sekolah v2\Report\Report" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls")


    End Sub

    Private Sub ExportToExcel(DGV As DataGridView)
        Try
            Dim writer As TextWriter = New StreamWriter(FlNm)
            writer.Write(vbTab & "NO")
            For Each column As DataGridViewColumn _
                In DGCari.Columns
                writer.Write(vbTab & column.HeaderText)
            Next

            writer.WriteLine("")
            For i As Integer = 0 To DGV.Rows.Count - 1 Step +1
                writer.Write(vbTab & i + 1)
                For j As Integer = 0 To DGV.Columns.Count - 1 Step +1

                    writer.Write(vbTab & DGV.Rows(i).Cells(j).Value.ToString())

                Next

                writer.WriteLine("")

            Next
            writer.Close()
            MessageBox.Show("Data Exported")

        Catch ex As Exception
            MessageBox.Show("error-message : " + ex.Message)
            MessageBox.Show("error-trace : " + ex.StackTrace)
        End Try
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        FormBeranda.Show()
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged

    End Sub
End Class