Imports System.Data.Common
Imports System.IO
Imports Microsoft.SqlServer
'Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class login

    Public Shared perpustakaan As perpustakaan
    Public Shared Users As Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        perpustakaan = New perpustakaan()
        Users = New Users()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text

        'Dim Encrypted As String = Users.EncryptData(plainPassword)
        'MessageBox.Show(Encrypted)

        'diganti sama data_user
        'Dim AuthStatus As Boolean = Users.CheckAuth(plainUsername, plainPassword)
        'MessageBox.Show(AuthStatus)

        Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)
        If data_user.Count > 0 Then
            Users.GSusername = data_user(1)
            perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Password Salah")
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        register.Show()
    End Sub

    'INI MA CONTOH TRY CATCH
    'Try
    'testimage.Image = System.Drawing.Bitmap.FromFile("e:\Road.jpg")
    'Catch
    'MsgBox("Please insert the flash drive in drive E!")
    'Finally
    'MsgBox("Error handler complete")
    'End Try

    'Try
    'If TestImage.Enable = False Then Exit Try
    'TestImage.Image = System.Drawing.Bitmap.FromFile("e:\road.jpg")
    'Catch
    'tries +-1
    'f Retries <= 2 Then
    'MsgBox("Please insert the flash drive in drive E!")
    'Else
    'MsgBox("File load feature disable")
    'Button1.Enabled = False
    'End If
    'End Try


    'cek teksbox kosong apa ngga
    'if NoteTextBox.text.lenght > 0 Then

End Class