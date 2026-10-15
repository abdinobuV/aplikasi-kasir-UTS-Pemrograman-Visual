<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblIdentitas As Label
    Friend WithEvents lblUserKasir As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabBarang As TabPage
    Friend WithEvents TabLaporan As TabPage
    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents lblKode As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblStok As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents dgvRiwayat As DataGridView
    Friend WithEvents lblOmzet As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBukaKasir As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnKeluar As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblJudul = New Label()
        lblIdentitas = New Label()
        lblUserKasir = New Label()
        lblJam = New Label()
        Timer1 = New Timer(components)
        TabControl1 = New TabControl()
        TabBarang = New TabPage()
        dgvBarang = New DataGridView()
        lblKode = New Label()
        lblNama = New Label()
        lblHarga = New Label()
        lblStok = New Label()
        txtKode = New TextBox()
        txtNama = New TextBox()
        txtHarga = New TextBox()
        txtStok = New TextBox()
        btnTambah = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnReset = New Button()
        TabLaporan = New TabPage()
        dgvRiwayat = New DataGridView()
        lblOmzet = New Label()
        btnRefresh = New Button()
        btnBukaKasir = New Button()
        btnLogout = New Button()
        btnKeluar = New Button()
        TabControl1.SuspendLayout()
        TabBarang.SuspendLayout()
        CType(dgvBarang, ComponentModel.ISupportInitialize).BeginInit()
        TabLaporan.SuspendLayout()
        CType(dgvRiwayat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblJudul.Location = New Point(20, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(326, 45)
        lblJudul.TabIndex = 1
        lblJudul.Text = "TOKO BERKAH JAYA"
        ' 
        ' lblIdentitas
        ' 
        lblIdentitas.AutoSize = True
        lblIdentitas.Location = New Point(22, 55)
        lblIdentitas.Name = "lblIdentitas"
        lblIdentitas.Size = New Size(340, 25)
        lblIdentitas.TabIndex = 2
        lblIdentitas.Text = "NIM: 5253151026 - Abdi Raihan Wibowo"
        ' 
        ' lblUserKasir
        ' 
        lblUserKasir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblUserKasir.AutoSize = True
        lblUserKasir.Location = New Point(620, 20)
        lblUserKasir.Name = "lblUserKasir"
        lblUserKasir.Size = New Size(108, 25)
        lblUserKasir.TabIndex = 3
        lblUserKasir.Text = "Kasir: admin"
        ' 
        ' lblJam
        ' 
        lblJam.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblJam.AutoSize = True
        lblJam.Location = New Point(620, 50)
        lblJam.Name = "lblJam"
        lblJam.Size = New Size(102, 25)
        lblJam.TabIndex = 4
        lblJam.Text = "Jam: --:--:--"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabBarang)
        TabControl1.Controls.Add(TabLaporan)
        TabControl1.Location = New Point(20, 90)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(840, 380)
        TabControl1.TabIndex = 0
        ' 
        ' TabBarang
        ' 
        TabBarang.Controls.Add(dgvBarang)
        TabBarang.Controls.Add(lblKode)
        TabBarang.Controls.Add(lblNama)
        TabBarang.Controls.Add(lblHarga)
        TabBarang.Controls.Add(lblStok)
        TabBarang.Controls.Add(txtKode)
        TabBarang.Controls.Add(txtNama)
        TabBarang.Controls.Add(txtHarga)
        TabBarang.Controls.Add(txtStok)
        TabBarang.Controls.Add(btnTambah)
        TabBarang.Controls.Add(btnUbah)
        TabBarang.Controls.Add(btnHapus)
        TabBarang.Controls.Add(btnReset)
        TabBarang.Location = New Point(4, 34)
        TabBarang.Name = "TabBarang"
        TabBarang.Padding = New Padding(10)
        TabBarang.Size = New Size(832, 342)
        TabBarang.TabIndex = 0
        TabBarang.Text = "Data Barang"
        TabBarang.UseVisualStyleBackColor = True
        ' 
        ' dgvBarang
        ' 
        dgvBarang.AllowUserToAddRows = False
        dgvBarang.AllowUserToDeleteRows = False
        dgvBarang.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBarang.Location = New Point(280, 15)
        dgvBarang.Name = "dgvBarang"
        dgvBarang.ReadOnly = True
        dgvBarang.RowHeadersWidth = 62
        dgvBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBarang.Size = New Size(535, 315)
        dgvBarang.TabIndex = 0
        ' 
        ' lblKode
        ' 
        lblKode.AutoSize = True
        lblKode.Location = New Point(15, 20)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(53, 25)
        lblKode.TabIndex = 1
        lblKode.Text = "Kode"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(15, 60)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(119, 25)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama Barang"
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Location = New Point(15, 100)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(60, 25)
        lblHarga.TabIndex = 3
        lblHarga.Text = "Harga"
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Location = New Point(15, 140)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(47, 25)
        lblStok.TabIndex = 4
        lblStok.Text = "Stok"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(120, 17)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(145, 31)
        txtKode.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(120, 57)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(145, 31)
        txtNama.TabIndex = 2
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(120, 97)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(145, 31)
        txtHarga.TabIndex = 3
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(120, 137)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(145, 31)
        txtStok.TabIndex = 4
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(15, 185)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(120, 32)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(145, 185)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(120, 32)
        btnUbah.TabIndex = 6
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(15, 225)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(120, 32)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(145, 225)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(120, 32)
        btnReset.TabIndex = 8
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' TabLaporan
        ' 
        TabLaporan.Controls.Add(dgvRiwayat)
        TabLaporan.Controls.Add(lblOmzet)
        TabLaporan.Controls.Add(btnRefresh)
        TabLaporan.Location = New Point(4, 34)
        TabLaporan.Name = "TabLaporan"
        TabLaporan.Padding = New Padding(10)
        TabLaporan.Size = New Size(832, 342)
        TabLaporan.TabIndex = 1
        TabLaporan.Text = "Laporan Penjualan"
        TabLaporan.UseVisualStyleBackColor = True
        ' 
        ' dgvRiwayat
        ' 
        dgvRiwayat.AllowUserToAddRows = False
        dgvRiwayat.AllowUserToDeleteRows = False
        dgvRiwayat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRiwayat.Location = New Point(15, 15)
        dgvRiwayat.Name = "dgvRiwayat"
        dgvRiwayat.ReadOnly = True
        dgvRiwayat.RowHeadersWidth = 62
        dgvRiwayat.Size = New Size(800, 270)
        dgvRiwayat.TabIndex = 0
        ' 
        ' lblOmzet
        ' 
        lblOmzet.AutoSize = True
        lblOmzet.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblOmzet.Location = New Point(15, 295)
        lblOmzet.Name = "lblOmzet"
        lblOmzet.Size = New Size(198, 30)
        lblOmzet.TabIndex = 1
        lblOmzet.Text = "Total Omzet: Rp 0"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRefresh.Location = New Point(690, 292)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(125, 32)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnBukaKasir
        ' 
        btnBukaKasir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnBukaKasir.BackColor = Color.SteelBlue
        btnBukaKasir.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnBukaKasir.ForeColor = Color.White
        btnBukaKasir.Location = New Point(20, 485)
        btnBukaKasir.Name = "btnBukaKasir"
        btnBukaKasir.Size = New Size(220, 45)
        btnBukaKasir.TabIndex = 1
        btnBukaKasir.Text = "Buka Transaksi Kasir"
        btnBukaKasir.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnLogout.Location = New Point(640, 485)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(105, 45)
        btnLogout.TabIndex = 2
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnKeluar.Location = New Point(755, 485)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(105, 45)
        btnKeluar.TabIndex = 3
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 545)
        Controls.Add(TabControl1)
        Controls.Add(lblJudul)
        Controls.Add(lblIdentitas)
        Controls.Add(lblUserKasir)
        Controls.Add(lblJam)
        Controls.Add(btnBukaKasir)
        Controls.Add(btnLogout)
        Controls.Add(btnKeluar)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu Utama - Aplikasi Kasir (UTS)"
        TabControl1.ResumeLayout(False)
        TabBarang.ResumeLayout(False)
        TabBarang.PerformLayout()
        CType(dgvBarang, ComponentModel.ISupportInitialize).EndInit()
        TabLaporan.ResumeLayout(False)
        TabLaporan.PerformLayout()
        CType(dgvRiwayat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
