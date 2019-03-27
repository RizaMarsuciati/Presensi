Public Class ClsEntKelas
    Private id_kelas As String
    Private daftar_kelas As String

    Public Property idkelas() As String
        Get
            Return id_kelas
        End Get
        Set(value As String)
            id_kelas = value
        End Set
    End Property

    Public Property daftarkelas() As String
        Get
            Return daftar_kelas
        End Get
        Set(value As String)
            daftar_kelas = value
        End Set
    End Property

End Class
