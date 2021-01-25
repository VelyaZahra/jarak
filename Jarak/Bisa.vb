Public Class Bisa
    Private _kecepatan As Single
    Private _waktu As Single
    Private _hasil As Single

    Public Property Kecepatan() As Integer
        Get
            Return _kecepatan
        End Get
        Set(ByVal value As Integer)
            _kecepatan = value
        End Set
    End Property

    Public Property Waktu() As Integer
        Get
            Return _waktu
        End Get
        Set(ByVal value As Integer)
            _waktu = value
        End Set
    End Property

    Public Function Hasil() As Single
        _hasil = _kecepatan * _waktu
        Return _hasil
    End Function

End Class
