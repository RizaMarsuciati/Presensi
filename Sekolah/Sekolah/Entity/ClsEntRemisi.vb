Public Class ClsEntRemisi
    Private id_remisi As String
    Private id_pelanggaran As String
    Private jml_remisi As String
    Private ket_remisi As String

    Public Property idremisi As String
        Get
            Return id_remisi
        End Get
        Set(value As String)
            id_remisi = value
        End Set
    End Property
    Public Property idpelanggaran As String
        Get
            Return id_pelanggaran
        End Get
        Set(value As String)
            id_pelanggaran = value
        End Set
    End Property
    Public Property jumlahremisi As String
        Get
            Return jml_remisi
        End Get
        Set(value As String)
            jml_remisi = value
        End Set
    End Property
    Public Property keteranganremisi As String
        Get
            Return ket_remisi
        End Get
        Set(value As String)
            ket_remisi = value
        End Set
    End Property
End Class
