<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKasir
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

    Friend WithEvents lblPilih As Label
    Friend WithEvents cmbBarang As ComboBox
    Friend WithEvents lblHargaSat As Label
    Friend WithEvents txtHargaSat As TextBox
    Friend WithEvents lblQty As Label
    Friend WithEvents numQty As NumericUpDown
    Friend WithEvents btnTambahItem As Button
    Friend WithEvents dgvKeranjang As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblDiskon As Label
    Friend WithEvents txtDiskon As TextBox
    Friend WithEvents lblPajak As Label
    Friend WithEvents txtPajak As TextBox
    Friend WithEvents lblGrand As Label
    Friend WithEvents txtGrand As TextBox
    Friend WithEvents lblBayar As Label
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents lblKembalian As Label
    Friend WithEvents txtKembalian As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnBayar As Button
    Friend WithEvents btnHapusItem As Button
    Friend WithEvents btnBatalTrans As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents txtStruk As TextBox
    Friend WithEvents lblStruk As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        lblPilih = New Label()
        cmbBarang = New ComboBox()
        lblHargaSat = New Label()
        txtHargaSat = New TextBox()
        lblQty = New Label()
        numQty = New NumericUpDown()
        btnTambahItem = New Button()
        dgvKeranjang = New DataGridView()
        lblTotal = New Label()
        txtTotal = New TextBox()
        lblDiskon = New Label()
        txtDiskon = New TextBox()
        lblPajak = New Label()
        txtPajak = New TextBox()
        lblGrand = New Label()
        txtGrand = New TextBox()
        lblBayar = New Label()
        txtBayar = New TextBox()
        lblKembalian = New Label()
        txtKembalian = New TextBox()
        btnHitung = New Button()
        btnBayar = New Button()
        btnHapusItem = New Button()
        btnBatalTrans = New Button()
        btnCetak = New Button()
        btnTutup = New Button()
        txtStruk = New TextBox()
        lblStruk = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        CType(numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'lblPilih
        '
        lblPilih.AutoSize = True
        lblPilih.Location = New Point(20, 15)
        lblPilih.Name = "lblPilih"
        lblPilih.Size = New Size(92, 20)
        lblPilih.Text = "Pilih Barang"
        '
        'cmbBarang
        '
        cmbBarang.DropDownStyle = ComboBoxStyle.DropDownList
        cmbBarang.FormattingEnabled = True
        cmbBarang.Location = New Point(20, 38)
        cmbBarang.Name = "cmbBarang"
        cmbBarang.Size = New Size(260, 28)
        cmbBarang.TabIndex = 0
        '
        'lblHargaSat
        '
        lblHargaSat.AutoSize = True
        lblHargaSat.Location = New Point(295, 15)
        lblHargaSat.Name = "lblHargaSat"
        lblHargaSat.Size = New Size(93, 20)
        lblHargaSat.Text = "Harga Satuan"
        '
        'txtHargaSat
        '
        txtHargaSat.Location = New Point(295, 38)
        txtHargaSat.Name = "txtHargaSat"
        txtHargaSat.ReadOnly = True
        txtHargaSat.Size = New Size(130, 27)
        txtHargaSat.TabIndex = 1
        '
        'lblQty
        '
        lblQty.AutoSize = True
        lblQty.Location = New Point(435, 15)
        lblQty.Name = "lblQty"
        lblQty.Size = New Size(31, 20)
        lblQty.Text = "Qty"
        '
        'numQty
        '
        numQty.Location = New Point(435, 38)
        numQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numQty.Name = "numQty"
        numQty.Size = New Size(70, 27)
        numQty.TabIndex = 2
        numQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnTambahItem
        '
        btnTambahItem.Location = New Point(515, 34)
        btnTambahItem.Name = "btnTambahItem"
        btnTambahItem.Size = New Size(105, 32)
        btnTambahItem.TabIndex = 3
        btnTambahItem.Text = "+ Keranjang"
        btnTambahItem.UseVisualStyleBackColor = True
        '
        'dgvKeranjang
        '
        dgvKeranjang.AllowUserToAddRows = False
        dgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKeranjang.Location = New Point(20, 80)
        dgvKeranjang.Name = "dgvKeranjang"
        dgvKeranjang.ReadOnly = True
        dgvKeranjang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKeranjang.Size = New Size(600, 230)
        dgvKeranjang.TabIndex = 4
        '
        'lblTotal
        '
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(640, 80)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(85, 20)
        lblTotal.Text = "Total (Rp)"
        '
        'txtTotal
        '
        txtTotal.Location = New Point(760, 77)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(180, 27)
        txtTotal.TabIndex = 5
        txtTotal.Text = "0"
        '
        'lblDiskon
        '
        lblDiskon.AutoSize = True
        lblDiskon.Location = New Point(640, 115)
        lblDiskon.Name = "lblDiskon"
        lblDiskon.Size = New Size(84, 20)
        lblDiskon.Text = "Diskon (%)"
        '
        'txtDiskon
        '
        txtDiskon.Location = New Point(760, 112)
        txtDiskon.Name = "txtDiskon"
        txtDiskon.Size = New Size(180, 27)
        txtDiskon.TabIndex = 6
        txtDiskon.Text = "0"
        '
        'lblPajak
        '
        lblPajak.AutoSize = True
        lblPajak.Location = New Point(640, 150)
        lblPajak.Name = "lblPajak"
        lblPajak.Size = New Size(110, 20)
        lblPajak.Text = "Pajak 11% (Rp)"
        '
        'txtPajak
        '
        txtPajak.Location = New Point(760, 147)
        txtPajak.Name = "txtPajak"
        txtPajak.ReadOnly = True
        txtPajak.Size = New Size(180, 27)
        txtPajak.TabIndex = 7
        txtPajak.Text = "0"
        '
        'lblGrand
        '
        lblGrand.AutoSize = True
        lblGrand.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblGrand.Location = New Point(640, 185)
        lblGrand.Name = "lblGrand"
        lblGrand.Size = New Size(104, 20)
        lblGrand.Text = "Grand Total"
        '
        'txtGrand
        '
        txtGrand.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        txtGrand.Location = New Point(760, 182)
        txtGrand.Name = "txtGrand"
        txtGrand.ReadOnly = True
        txtGrand.Size = New Size(180, 30)
        txtGrand.TabIndex = 8
        txtGrand.Text = "0"
        '
        'lblBayar
        '
        lblBayar.AutoSize = True
        lblBayar.Location = New Point(640, 222)
        lblBayar.Name = "lblBayar"
        lblBayar.Size = New Size(77, 20)
        lblBayar.Text = "Bayar (Rp)"
        '
        'txtBayar
        '
        txtBayar.Location = New Point(760, 219)
        txtBayar.Name = "txtBayar"
        txtBayar.Size = New Size(180, 27)
        txtBayar.TabIndex = 9
        txtBayar.Text = "0"
        '
        'lblKembalian
        '
        lblKembalian.AutoSize = True
        lblKembalian.Location = New Point(640, 257)
        lblKembalian.Name = "lblKembalian"
        lblKembalian.Size = New Size(86, 20)
        lblKembalian.Text = "Kembalian"
        '
        'txtKembalian
        '
        txtKembalian.Location = New Point(760, 254)
        txtKembalian.Name = "txtKembalian"
        txtKembalian.ReadOnly = True
        txtKembalian.Size = New Size(180, 27)
        txtKembalian.TabIndex = 10
        txtKembalian.Text = "0"
        '
        'btnHitung
        '
        btnHitung.Location = New Point(640, 292)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(145, 35)
        btnHitung.TabIndex = 11
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        '
        'btnBayar
        '
        btnBayar.BackColor = Color.ForestGreen
        btnBayar.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBayar.ForeColor = Color.White
        btnBayar.Location = New Point(795, 292)
        btnBayar.Name = "btnBayar"
        btnBayar.Size = New Size(145, 35)
        btnBayar.TabIndex = 12
        btnBayar.Text = "Bayar"
        btnBayar.UseVisualStyleBackColor = False
        '
        'btnHapusItem
        '
        btnHapusItem.Location = New Point(20, 318)
        btnHapusItem.Name = "btnHapusItem"
        btnHapusItem.Size = New Size(140, 32)
        btnHapusItem.TabIndex = 13
        btnHapusItem.Text = "Hapus Item"
        btnHapusItem.UseVisualStyleBackColor = True
        '
        'btnBatalTrans
        '
        btnBatalTrans.Location = New Point(170, 318)
        btnBatalTrans.Name = "btnBatalTrans"
        btnBatalTrans.Size = New Size(140, 32)
        btnBatalTrans.TabIndex = 14
        btnBatalTrans.Text = "Batal Transaksi"
        btnBatalTrans.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        btnCetak.Location = New Point(640, 560)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(145, 35)
        btnCetak.TabIndex = 15
        btnCetak.Text = "Preview Struk"
        btnCetak.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        btnTutup.Location = New Point(795, 560)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(145, 35)
        btnTutup.TabIndex = 16
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        '
        'txtStruk
        '
        txtStruk.Font = New Font("Consolas", 9.0F)
        txtStruk.Location = New Point(20, 380)
        txtStruk.Multiline = True
        txtStruk.Name = "txtStruk"
        txtStruk.ReadOnly = True
        txtStruk.ScrollBars = ScrollBars.Vertical
        txtStruk.Size = New Size(600, 215)
        txtStruk.TabIndex = 17
        '
        'lblStruk
        '
        lblStruk.AutoSize = True
        lblStruk.Location = New Point(20, 357)
        lblStruk.Name = "lblStruk"
        lblStruk.Size = New Size(106, 20)
        lblStruk.Text = "Preview Struk:"
        '
        'PrintPreviewDialog1
        '
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        '
        'FormKasir
        '
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(965, 610)
        Controls.Add(lblPilih)
        Controls.Add(cmbBarang)
        Controls.Add(lblHargaSat)
        Controls.Add(txtHargaSat)
        Controls.Add(lblQty)
        Controls.Add(numQty)
        Controls.Add(btnTambahItem)
        Controls.Add(dgvKeranjang)
        Controls.Add(lblTotal)
        Controls.Add(txtTotal)
        Controls.Add(lblDiskon)
        Controls.Add(txtDiskon)
        Controls.Add(lblPajak)
        Controls.Add(txtPajak)
        Controls.Add(lblGrand)
        Controls.Add(txtGrand)
        Controls.Add(lblBayar)
        Controls.Add(txtBayar)
        Controls.Add(lblKembalian)
        Controls.Add(txtKembalian)
        Controls.Add(btnHitung)
        Controls.Add(btnBayar)
        Controls.Add(btnHapusItem)
        Controls.Add(btnBatalTrans)
        Controls.Add(btnCetak)
        Controls.Add(btnTutup)
        Controls.Add(txtStruk)
        Controls.Add(lblStruk)
        Name = "FormKasir"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Transaksi Kasir"
        CType(numQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(dgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
