Imports System.Text

Public Class FormKasir
    Private Keranjang As DataTable
    Private strukTerakhir As String = ""
    Private grandTerakhir As Decimal = 0

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModData.InitData()
        Me.Text = "Transaksi Kasir - " & ModData.NAMA_TOKO

        ' Siapkan keranjang
        Keranjang = New DataTable("Keranjang")
        Keranjang.Columns.Add("Kode", GetType(String))
        Keranjang.Columns.Add("Nama", GetType(String))
        Keranjang.Columns.Add("Harga", GetType(Decimal))
        Keranjang.Columns.Add("Qty", GetType(Integer))
        Keranjang.Columns.Add("Subtotal", GetType(Decimal))
        dgvKeranjang.DataSource = Keranjang

        ' Isi combo barang (Kode - Nama)
        cmbBarang.Items.Clear()
        For Each r As DataRow In ModData.TabelBarang.Rows
            cmbBarang.Items.Add(r("Kode").ToString() & " - " & r("Nama").ToString())
        Next
        If cmbBarang.Items.Count > 0 Then cmbBarang.SelectedIndex = 0

        HitungTotal()
    End Sub

    Private Function AmbilKodeTerpilih() As String
        If cmbBarang.SelectedItem Is Nothing Then Return ""
        Dim s As String = cmbBarang.SelectedItem.ToString()
        Return s.Split("-"c)(0).Trim()
    End Function

    Private Sub cmbBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBarang.SelectedIndexChanged
        Dim r As DataRow = ModData.CariBarang(AmbilKodeTerpilih())
        If r IsNot Nothing Then
            txtHargaSat.Text = r("Harga").ToString()
        End If
    End Sub

    Private Sub btnTambahItem_Click(sender As Object, e As EventArgs) Handles btnTambahItem.Click
        Dim kode As String = AmbilKodeTerpilih()
        If kode = "" Then
            MessageBox.Show("Pilih barang dulu.", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim master As DataRow = ModData.CariBarang(kode)
        If master Is Nothing Then Return

        Dim qty As Integer = CInt(numQty.Value)
        Dim stok As Integer = CInt(master("Stok"))
        Dim harga As Decimal = CDec(master("Harga"))

        ' Cek qty yang sudah ada di keranjang
        Dim sudah As Integer = 0
        For Each r As DataRow In Keranjang.Rows
            If r("Kode").ToString() = kode Then sudah += CInt(r("Qty"))
        Next
        If sudah + qty > stok Then
            MessageBox.Show($"Stok tidak cukup! Sisa {stok}, di keranjang {sudah}.",
                            "Stok", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim ketemu As Boolean = False
        For Each r As DataRow In Keranjang.Rows
            If r("Kode").ToString() = kode Then
                r("Qty") = CInt(r("Qty")) + qty
                r("Subtotal") = CDec(r("Harga")) * CInt(r("Qty"))
                ketemu = True
                Exit For
            End If
        Next
        If Not ketemu Then
            Dim nr As DataRow = Keranjang.NewRow()
            nr("Kode") = kode
            nr("Nama") = master("Nama")
            nr("Harga") = harga
            nr("Qty") = qty
            nr("Subtotal") = harga * qty
            Keranjang.Rows.Add(nr)
        End If
        HitungTotal()
    End Sub

    Private Sub btnHapusItem_Click(sender As Object, e As EventArgs) Handles btnHapusItem.Click
        If dgvKeranjang.CurrentRow Is Nothing Then Return
        Dim idx As Integer = dgvKeranjang.CurrentRow.Index
        If idx >= 0 AndAlso idx < Keranjang.Rows.Count Then
            Keranjang.Rows.RemoveAt(idx)
            HitungTotal()
        End If
    End Sub

    Private Sub btnBatalTrans_Click(sender As Object, e As EventArgs) Handles btnBatalTrans.Click
        If Keranjang.Rows.Count = 0 Then Return
        If MessageBox.Show("Batalkan seluruh transaksi ini?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Keranjang.Rows.Clear()
            txtBayar.Text = "0" : txtKembalian.Text = "0" : txtStruk.Clear()
            HitungTotal()
        End If
    End Sub

    Private Function GetTotal() As Decimal
        Dim t As Decimal = 0
        For Each r As DataRow In Keranjang.Rows
            t += CDec(r("Subtotal"))
        Next
        Return t
    End Function

    Private Sub HitungTotal()
        Dim total As Decimal = GetTotal()
        Dim diskonPersen As Decimal = 0
        Decimal.TryParse(txtDiskon.Text, diskonPersen)
        If diskonPersen < 0 Then diskonPersen = 0
        If diskonPersen > 100 Then diskonPersen = 100

        Dim diskonRp As Decimal = total * diskonPersen / 100
        Dim pajakRp As Decimal = (total - diskonRp) * 0.11D
        Dim grand As Decimal = total - diskonRp + pajakRp

        txtTotal.Text = total.ToString("N0")
        txtPajak.Text = pajakRp.ToString("N0")
        txtGrand.Text = grand.ToString("N0")
        grandTerakhir = grand
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        HitungTotal()
        Dim bayar As Decimal = 0
        Decimal.TryParse(txtBayar.Text, bayar)
        Dim kembali As Decimal = bayar - grandTerakhir
        txtKembalian.Text = kembali.ToString("N0")
        If bayar < grandTerakhir Then
            MessageBox.Show("Uang bayar kurang!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If Keranjang.Rows.Count = 0 Then
            MessageBox.Show("Keranjang masih kosong.", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        HitungTotal()
        Dim total As Decimal = GetTotal()
        Dim diskonPersen As Decimal = 0
        Decimal.TryParse(txtDiskon.Text, diskonPersen)
        Dim diskonRp As Decimal = total * diskonPersen / 100
        Dim pajakRp As Decimal = (total - diskonRp) * 0.11D
        Dim grand As Decimal = total - diskonRp + pajakRp

        Dim bayar As Decimal = 0
        If Not Decimal.TryParse(txtBayar.Text, bayar) Then
            MessageBox.Show("Nominal bayar harus angka.", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If bayar < grand Then
            MessageBox.Show("Uang bayar kurang dari grand total.", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Kurangi stok
        For Each kr As DataRow In Keranjang.Rows
            Dim m As DataRow = ModData.CariBarang(kr("Kode").ToString())
            If m IsNot Nothing Then
                m("Stok") = CInt(m("Stok")) - CInt(kr("Qty"))
            End If
        Next

        Dim kembali As Decimal = bayar - grand
        txtKembalian.Text = kembali.ToString("N0")

        ' Simpan transaksi
        Dim tr As New Transaksi() With {
            .NoNota = "TRX-" & DateTime.Now.ToString("yyyyMMdd-HHmmss"),
            .Tanggal = DateTime.Now,
            .Kasir = ModData.UserLogin,
            .Total = total,
            .DiskonPersen = diskonPersen,
            .DiskonRp = diskonRp,
            .PajakRp = pajakRp,
            .GrandTotal = grand,
            .Bayar = bayar,
            .Kembalian = kembali,
            .Items = Keranjang.Copy()
        }
        ModData.DaftarTransaksi.Add(tr)

        strukTerakhir = BuatStruk(tr)
        txtStruk.Text = strukTerakhir

        MessageBox.Show($"Pembayaran berhasil! Kembalian {ModData.FormatRupiah(kembali)}",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Keranjang.Rows.Clear()
        txtBayar.Text = "0"
        HitungTotal()
    End Sub

    Private Function BuatStruk(t As Transaksi) As String
        Dim sb As New StringBuilder()
        sb.AppendLine("="c & New String("="c, 38))
        sb.AppendLine("       " & ModData.NAMA_TOKO.ToUpper())
        sb.AppendLine("       " & ModData.ALAMAT_TOKO)
        sb.AppendLine("="c & New String("="c, 38))
        sb.AppendLine($"No Nota : {t.NoNota}")
        sb.AppendLine($"Tanggal : {t.Tanggal:dd/MM/yyyy HH:mm:ss}")
        sb.AppendLine($"Kasir   : {t.Kasir}")
        sb.AppendLine($"UTS     : {ModData.NIM_MHS} - {ModData.NAMA_MHS}")
        sb.AppendLine(New String("-"c, 39))
        For Each r As DataRow In t.Items.Rows
            sb.AppendLine($"{r("Nama")}")
            sb.AppendLine($"  {CDec(r("Harga")).ToString("N0")} x {r("Qty")} = {CDec(r("Subtotal")).ToString("N0")}")
        Next
        sb.AppendLine(New String("-"c, 39))
        sb.AppendLine($"Total        : {t.Total.ToString("N0")}")
        sb.AppendLine($"Diskon {t.DiskonPersen}%   : {t.DiskonRp.ToString("N0")}")
        sb.AppendLine($"Pajak 11%    : {t.PajakRp.ToString("N0")}")
        sb.AppendLine($"GRAND TOTAL  : {t.GrandTotal.ToString("N0")}")
        sb.AppendLine($"Bayar        : {t.Bayar.ToString("N0")}")
        sb.AppendLine($"Kembalian    : {t.Kembalian.ToString("N0")}")
        sb.AppendLine("="c & New String("="c, 38))
        sb.AppendLine("   Terima kasih, sampai jumpa lagi!")
        sb.AppendLine("   Tugas UTS Pemrograman Visual")
        Return sb.ToString()
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If String.IsNullOrWhiteSpace(txtStruk.Text) Then
            MessageBox.Show("Belum ada struk. Lakukan pembayaran dulu.", "Cetak",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal preview: " & ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f As New Font("Consolas", 10)
        e.Graphics.DrawString(txtStruk.Text, f, Brushes.Black, 40, 40)
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class
