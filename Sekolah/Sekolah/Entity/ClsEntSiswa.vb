Public Class ClsEntSiswa
    Private nis As String
    Private nama As String
    Private jenkel As String
    Private tempat_lahir As String
    Private tgl_lahir As String
    Private alamat As String
    Private no_telp As String
    Private id_kelas As String
    Private id_thang As String
    Private id_kategori As String

    Public Property noinduksiswa() As String
        Get
            Return nis
        End Get
        Set(value As String)
            nis = value
        End Set
    End Property
    Public Property namasiswa() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property jeniskelamin() As String
        Get
            Return jenkel
        End Get
        Set(value As String)
            jenkel = value
        End Set
    End Property
    Public Property tempatlahir() As String
        Get
            Return tempat_lahir
        End Get
        Set(value As String)
            tempat_lahir = value
        End Set
    End Property
    Public Property tanggallahir() As String
        Get
            Return tgl_lahir
        End Get
        Set(value As String)
            tgl_lahir = value
        End Set
    End Property
    Public Property alamatsiswa() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property
    Public Property notelp() As String
        Get
            Return no_telp
        End Get
        Set(value As String)
            no_telp = value
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
    Public Property idthang() As String
        Get
            Return id_thang
        End Get
        Set(value As String)
            id_thang = value
        End Set
    End Property
    Public Property idkategori() As String
        Get
            Return id_kategori
        End Get
        Set(value As String)
            id_kategori = value
        End Set
    End Property
End Class
