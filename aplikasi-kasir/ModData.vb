Imports System.Data

' Module global pengganti database (In-Memory) untuk tugas UTS.
' Berisi: data barang, user login, riwayat transaksi, identitas mahasiswa.
Public Module ModData

    Public NAMA_TOKO As String = "Toko Berkah Jaya"
    Public ALAMAT_TOKO As String = "Jl. Merdeka No. 10, Telp 0812-3456-7890"
    ' TODO UTS: ganti dengan NIM & Nama kamu sebelum demo
    Public NIM_MHS As String = "5253151026"
    Public NAMA_MHS As String = "Abdi Raihan Wibowo"

    Public UserLogin As String = ""
    Public TabelBarang As DataTable
    Public DaftarTransaksi As New List(Of Transaksi)()

    ' Dipanggil sekali saat aplikasi mulai (dari FormLogin_Load)
    Public Sub InitData()
        If TabelBarang IsNot Nothing Then Return

        TabelBarang = New DataTable("Barang")
        TabelBarang.Columns.Add("Kode", GetType(String))
        TabelBarang.Columns.Add("Nama", GetType(String))
        TabelBarang.Columns.Add("Harga", GetType(Decimal))
        TabelBarang.Columns.Add("Stok", GetType(Integer))
        TabelBarang.PrimaryKey = New DataColumn() {TabelBarang.Columns("Kode")}

        TambahSeed("BRG001", "Indomie Goreng", 3500, 100)
        TambahSeed("BRG002", "Kopi Kapal Api", 12000, 50)
        TambahSeed("BRG003", "Aqua 600ml", 4000, 80)
        TambahSeed("BRG004", "Beras 5kg", 65000, 20)
        TambahSeed("BRG005", "Gula Pasir 1kg", 17500, 30)
        TambahSeed("BRG006", "Minyak Goreng 2L", 45000, 25)
        TambahSeed("BRG007", "Teh Botol", 5000, 60)
        TambahSeed("BRG008", "Roti Tawar", 15000, 40)
    End Sub

    Private Sub TambahSeed(kode As String, nama As String, harga As Decimal, stok As Integer)
        Dim r As DataRow = TabelBarang.NewRow()
        r("Kode") = kode
        r("Nama") = nama
        r("Harga") = harga
        r("Stok") = stok
        TabelBarang.Rows.Add(r)
    End Sub

    ' Login sederhana: admin/admin dan kasir/kasir123
    Public Function ValidasiLogin(user As String, pass As String) As Boolean
        user = user.Trim().ToLower()
        If (user = "admin" AndAlso pass = "admin") OrElse
           (user = "kasir" AndAlso pass = "kasir123") Then
            UserLogin = user
            Return True
        End If
        Return False
    End Function

    Public Function FormatRupiah(nilai As Decimal) As String
        Return "Rp " & nilai.ToString("N0")
    End Function

    Public Function TotalOmzet() As Decimal
        Dim total As Decimal = 0
        For Each t In DaftarTransaksi
            total += t.GrandTotal
        Next
        Return total
    End Function

    Public Function CariBarang(kode As String) As DataRow
        Dim found() As DataRow = TabelBarang.Select("Kode = '" & kode.Replace("'", "''") & "'")
        If found.Length > 0 Then Return found(0)
        Return Nothing
    End Function

End Module

' Satu nota transaksi yang tersimpan di memori
Public Class Transaksi
    Public Property NoNota As String
    Public Property Tanggal As DateTime
    Public Property Kasir As String
    Public Property Total As Decimal
    Public Property DiskonPersen As Decimal
    Public Property DiskonRp As Decimal
    Public Property PajakRp As Decimal
    Public Property GrandTotal As Decimal
    Public Property Bayar As Decimal
    Public Property Kembalian As Decimal
    Public Property Items As DataTable
End Class
