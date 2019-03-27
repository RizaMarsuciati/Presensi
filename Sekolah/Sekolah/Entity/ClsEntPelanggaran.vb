Public Class ClsEntPelanggaran
    Private id_pelanggaran As String
    Private jenis_pelanggaran As String
    Private point_pelanggaran As String


    Public Property idpelanggaran() As String
        Get
            Return id_pelanggaran
        End Get
        Set(value As String)
            id_pelanggaran = value
        End Set
    End Property
    Public Property jenispelanggaran() As String
        Get
            Return jenis_pelanggaran
        End Get
        Set(value As String)
            jenis_pelanggaran = value
        End Set
    End Property
    Public Property pointpelanggaran() As String
        Get
            Return point_pelanggaran
        End Get
        Set(value As String)
            point_pelanggaran = value
        End Set
    End Property
End Class
