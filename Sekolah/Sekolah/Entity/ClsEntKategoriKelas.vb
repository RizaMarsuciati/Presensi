Public Class ClsEntKategoriKelas
    Private id_kategori As String
    Private nama_kategori As String
    Private id_kelas As String

    Public Property idkategori() As String
        Get
            Return id_kategori
        End Get
        Set(value As String)
            id_kategori = value
        End Set
    End Property

    Public Property namakategori() As String
        Get
            Return nama_kategori
        End Get
        Set(value As String)
            nama_kategori = value
        End Set
    End Property

    Public Property idkelas() As String
        Get
            Return id_kelas
        End Get
        Set(value As String)
            id_kelas = value
        End Set
    End Property

End Class
