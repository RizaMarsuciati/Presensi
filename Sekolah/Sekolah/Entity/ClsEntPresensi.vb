Public Class ClsEntPresensi
    Private id_presensi As String
    Private status As String
    Private tgl_presensi As String
    Private id_petugas As String
    Private nis As String
    Private ket As String

    Public Property idpresensi As String
        Get
            Return id_presensi
        End Get
        Set(value As String)
            id_presensi = value
        End Set
    End Property
    Public Property statuspresensi As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property
    Public Property tanggalpresensi As String
        Get
            Return tgl_presensi
        End Get
        Set(value As String)
            tgl_presensi = value
        End Set
    End Property
    Public Property idpetugas As String
        Get
            Return id_petugas
        End Get
        Set(value As String)
            id_petugas = value
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
    Public Property keterangan As String
        Get
            Return ket
        End Get
        Set(value As String)
            ket = value
        End Set
    End Property
End Class
