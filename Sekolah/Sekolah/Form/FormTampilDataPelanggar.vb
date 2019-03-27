Imports System.Data.OleDb

Public Class FormTampilDataPelanggar

    Private Sub RefreshGrid()
        DTGrid = KontrolKasuss.tampilData.ToTable
        DGTampil.DataSource = DTGrid
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormPelanggaran.Show()
        Me.Close()
    End Sub
    Private Sub FormTampilDataPelanggar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub
End Class