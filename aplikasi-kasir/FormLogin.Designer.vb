<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
    Friend WithEvents lblSub As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents lblInfo As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJudul = New Label()
        lblSub = New Label()
        lblUser = New Label()
        lblPass = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        btnLogin = New Button()
        btnBatal = New Button()
        lblInfo = New Label()
        SuspendLayout()
        '
        'lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblJudul.Location = New Point(40, 20)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(320, 37)
        lblJudul.Text = "APLIKASI KASIR"
        '
        'lblSub
        '
        lblSub.AutoSize = True
        lblSub.Location = New Point(42, 60)
        lblSub.Name = "lblSub"
        lblSub.Size = New Size(330, 20)
        lblSub.Text = "Toko Berkah Jaya - Silakan login terlebih dahulu"
        '
        'lblUser
        '
        lblUser.AutoSize = True
        lblUser.Location = New Point(42, 110)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(75, 20)
        lblUser.Text = "Username"
        '
        'lblPass
        '
        lblPass.AutoSize = True
        lblPass.Location = New Point(42, 165)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(70, 20)
        lblPass.Text = "Password"
        '
        'txtUser
        '
        txtUser.Location = New Point(150, 107)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(220, 27)
        txtUser.Text = "admin"
        '
        'txtPass
        '
        txtPass.Location = New Point(150, 162)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(220, 27)
        txtPass.UseSystemPasswordChar = True
        txtPass.Text = "admin"
        '
        'btnLogin
        '
        btnLogin.Location = New Point(150, 210)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(105, 35)
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        btnBatal.Location = New Point(265, 210)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(105, 35)
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        lblInfo.AutoSize = True
        lblInfo.ForeColor = Color.Gray
        lblInfo.Location = New Point(42, 265)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(340, 20)
        lblInfo.Text = "Demo UTS: admin/admin  atau  kasir/kasir123"
        '
        'FormLogin
        '
        AcceptButton = btnLogin
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(420, 310)
        Controls.Add(lblJudul)
        Controls.Add(lblSub)
        Controls.Add(lblUser)
        Controls.Add(lblPass)
        Controls.Add(txtUser)
        Controls.Add(txtPass)
        Controls.Add(btnLogin)
        Controls.Add(btnBatal)
        Controls.Add(lblInfo)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login - Aplikasi Kasir (UTS)"
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
