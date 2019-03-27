Public Class ClsEntThang
    Private id_thang As String
    Private tahun_angkatan As String

    Public Property idthang() As String
        Get
            Return id_thang
        End Get
        Set(value As String)
            id_thang = value
        End Set
    End Property

    Public Property tahunangkatan() As String
        Get
            Return tahun_angkatan
        End Get
        Set(value As String)
            tahun_angkatan = value
        End Set
    End Property
End Class
