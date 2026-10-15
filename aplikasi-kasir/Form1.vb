Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModData.InitData()
        lblJudul.Text = ModData.NAMA_TOKO.ToUpper()
        lblIdentitas.Text = $"NIM: {ModData.NIM_MHS} - {ModData.NAMA_MHS}"
        lblUserKasir.Text = "Kasir: " & ModData.UserLogin
        RefreshBarang()
        RefreshLaporan()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblJam.Text = "Jam: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    ' ===== MASTER BARANG (CRUD In-Memory) =====
    Private Sub RefreshBarang()
        dgvBarang.DataSource = Nothing
        dgvBarang.DataSource = ModData.TabelBarang
        dgvBarang.Columns("Kode").Width = 90
        dgvBarang.Columns("Nama").Width = 220
        dgvBarang.Columns("Harga").DefaultCellStyle.Format = "N0"
    End Sub

    Private Function ValidasiInput(ByRef harga As Decimal, ByRef stok As Integer) As Boolean
        If txtKode.Text.Trim() = "" OrElse txtNama.Text.Trim() = "" Then
            MessageBox.Show("Kode dan Nama wajib diisi.", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If Not Decimal.TryParse(txtHarga.Text, harga) OrElse harga <= 0 Then
            MessageBox.Show("Harga harus angka > 0.", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHarga.Focus()
            Return False
        End If
        If Not Integer.TryParse(txtStok.Text, stok) OrElse stok < 0 Then
            MessageBox.Show("Stok harus angka >= 0.", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStok.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim harga As Decimal, stok As Integer
        If Not ValidasiInput(harga, stok) Then Return
        If ModData.CariBarang(txtKode.Text.Trim()) IsNot Nothing Then
            MessageBox.Show("Kode sudah ada. Gunakan kode lain / gunakan Ubah.", "Duplikat",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim r As DataRow = ModData.TabelBarang.NewRow()
        r("Kode") = txtKode.Text.Trim()
        r("Nama") = txtNama.Text.Trim()
        r("Harga") = harga
        r("Stok") = stok
        ModData.TabelBarang.Rows.Add(r)
        RefreshBarang()
        BersihkanInput()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim harga As Decimal, stok As Integer
        If Not ValidasiInput(harga, stok) Then Return
        Dim r As DataRow = ModData.CariBarang(txtKode.Text.Trim())
        If r Is Nothing Then
            MessageBox.Show("Kode tidak ditemukan.", "Ubah",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        r("Nama") = txtNama.Text.Trim()
        r("Harga") = harga
        r("Stok") = stok
        RefreshBarang()
        BersihkanInput()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKode.Text.Trim() = "" Then
            MessageBox.Show("Isi / pilih Kode dulu.", "Hapus",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim r As DataRow = ModData.CariBarang(txtKode.Text.Trim())
        If r Is Nothing Then
            MessageBox.Show("Kode tidak ditemukan.", "Hapus",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If MessageBox.Show($"Hapus {r("Kode")} - {r("Nama")} ?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ModData.TabelBarang.Rows.Remove(r)
            RefreshBarang()
            BersihkanInput()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        BersihkanInput()
        RefreshBarang()
    End Sub

    Private Sub BersihkanInput()
        txtKode.Clear() : txtNama.Clear() : txtHarga.Clear() : txtStok.Clear()
        txtKode.Focus()
    End Sub

    Private Sub dgvBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellClick
        If e.RowIndex < 0 Then Return
        Dim row As DataGridViewRow = dgvBarang.Rows(e.RowIndex)
        txtKode.Text = row.Cells("Kode").Value.ToString()
        txtNama.Text = row.Cells("Nama").Value.ToString()
        txtHarga.Text = row.Cells("Harga").Value.ToString()
        txtStok.Text = row.Cells("Stok").Value.ToString()
    End Sub

    ' ===== LAPORAN =====
    Private Sub RefreshLaporan()
        Dim dt As New DataTable()
        dt.Columns.Add("NoNota", GetType(String))
        dt.Columns.Add("Tanggal", GetType(String))
        dt.Columns.Add("Kasir", GetType(String))
        dt.Columns.Add("GrandTotal", GetType(Decimal))
        dt.Columns.Add("Bayar", GetType(Decimal))
        dt.Columns.Add("Kembalian", GetType(Decimal))
        For Each t In ModData.DaftarTransaksi
            dt.Rows.Add(t.NoNota, t.Tanggal.ToString("dd/MM/yyyy HH:mm"), t.Kasir,
                        t.GrandTotal, t.Bayar, t.Kembalian)
        Next
        dgvRiwayat.DataSource = dt
        lblOmzet.Text = "Total Omzet: " & ModData.FormatRupiah(ModData.TotalOmzet()) &
                        $"  ({ModData.DaftarTransaksi.Count} transaksi)"
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshLaporan()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabLaporan Then RefreshLaporan()
    End Sub

    ' ===== NAVIGASI =====
    Private Sub btnBukaKasir_Click(sender As Object, e As EventArgs) Handles btnBukaKasir.Click
        Using f As New FormKasir()
            f.ShowDialog()
        End Using
        RefreshBarang()
        RefreshLaporan()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close() ' kembali ke FormLogin (karena dibuka via ShowDialog)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MessageBox.Show("Keluar aplikasi?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub lblIdentitas_Click(sender As Object, e As EventArgs) Handles lblIdentitas.Click

    End Sub
End Class
