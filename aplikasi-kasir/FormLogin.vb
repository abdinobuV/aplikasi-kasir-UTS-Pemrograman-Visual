Public Class FormLogin
    Private gagal As Integer = 0

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModData.InitData()
        lblSub.Text = ModData.NAMA_TOKO & " - Silakan login terlebih dahulu"
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text.Trim() = "" OrElse txtPass.Text = "" Then
            MessageBox.Show("Username dan password wajib diisi.", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ModData.ValidasiLogin(txtUser.Text, txtPass.Text) Then
            Me.Hide()
            Using utama As New Form1()
                utama.ShowDialog()
            End Using
            Me.Close()
        Else
            gagal += 1
            MessageBox.Show($"Login gagal ({gagal}x). Coba lagi.", "Login Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPass.Clear()
            txtPass.Focus()
            If gagal >= 3 Then
                MessageBox.Show("3x gagal. Aplikasi ditutup.", "Keamanan",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class
