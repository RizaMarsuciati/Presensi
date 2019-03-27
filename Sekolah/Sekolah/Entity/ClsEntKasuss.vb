Public Class ClsEntKasuss
    Private id_kasuss As String
    Private nis As String
    Private id_pelanggaran As String
    Private nama As String
    Private kasus As String
    Private point_pelanggaran As String

    Public Property idkasuss As String
        Get
            Return id_kasuss
        End Get
        Set(value As String)
            id_kasuss = value
        End Set
    End Property
    Public Property noinduksiswa As String
        Get
            Return nis
        End Get
        Set(value As String)
            nis = value
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
    Public Property namasiswa As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property ketkasus As String
        Get
            Return kasus
        End Get
        Set(value As String)
            kasus = value
        End Set
    End Property
    Public Property pointpelanggaran As String
        Get
            Return point_pelanggaran
        End Get
        Set(value As String)
            point_pelanggaran = value
        End Set
    End Property
End Class
