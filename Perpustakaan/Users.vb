Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Users

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "perpustakaan"

    Private username As String
    Private password As String
    Private KoleksiUsers As New ArrayList()

    Private TripleDes As New TripleDESCryptoServiceProvider

    Public Property GSusername() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property GSpassword() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    'fungsi enskripsi data
    Public Function EncryptData(ByVal plaintext As String) As String

        'konversi plaintext string ke byte array
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        'buat stream
        Dim ms As New System.IO.MemoryStream

        'buat encoder dari write ke stream
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        'gunakan crypto stream untuk menulis byte array ke stream
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        'konversi encrypsi stream ke printable string
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function CheckAuth(username As String, ByVal plaintextPassword As String) As String
        'password static
        Dim realPassword As String = EncryptData("1234")
        Dim realUsername As String = "Dhiza"

        If String.Compare(username, realUsername) = 0 And String.Compare(EncryptData(plaintextPassword), realPassword) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function setUserPassKoleksi(username As String, pass As String) As Boolean

        pass = EncryptData(pass)
        KoleksiUsers.Add({username, pass})

    End Function

    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Function AddUserDatabase(username_regist As String, password_regist As String)
        Try
            Dim today = Date.Now()

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO USERS(username, password, registered_at) VALUE('" _
                & username_regist & "', '" _
                & EncryptMD5(password_regist) & "', '" _
                & today.ToString("yyyy/MM/dd") & "')"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
            + "password=" + password_db + ";" + "database =" + database

            dbConn.Open()

            sqlCommand.Connection = dbConn
            Dim queryAuth = "SELECT id_user, username FORM users
                       WHERE username='" & username_login & " ' AND password=' " & EncryptMD5(password_login) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

End Class
