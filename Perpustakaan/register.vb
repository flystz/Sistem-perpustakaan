Public Class register
    Private Sub BtnRegistrasi_Click(sender As Object, e As EventArgs) Handles BtnRegistrasi.Click
        If TxtUsername.Text.Length > 0 And TxtPassword.Text.Length > 0 Then

            'login.Users.AddUserDatabase(TxtUsername.Text, TxtPassword.Text)
            login.Users.AddUserDatabase(TxtUsername.Text, TxtPassword.Text)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
        'login.Users.setUserPassKoleksi(TxtUsername.Text, TxtPassword.Text)
        'TxtUsername.Select()
        'TxtUsername.Text = ""
        'TxtPassword.Text = ""
        'Me.Close()

    End Sub

    Private Sub lbllog_Click(sender As Object, e As EventArgs) Handles lbllog.Click
        login.Show()
        Me.Close()
    End Sub

    'Private Sub register_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    ' TxtUsername.Select()
    'TxtUsername.Text = ""
    'TxtPassword.Text = ""

    'End Sub

    Private Sub tbpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        TxtPassword.PasswordChar = "*"c

    End Sub


End Class