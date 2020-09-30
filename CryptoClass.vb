Imports System.Security
Imports System.Security.Cryptography

Public Class CryptoClass

    Public Property passphrase As String

    Public Property Message As String

    Public ReadOnly Property EncryptMyMessage As String
        Get
            Dim myResult As String = "--"

            If passphrase.Length > 0 And Message.Length > 0 Then
                Dim Results As Byte()
                Dim UTF8 As System.Text.UTF8Encoding = New System.Text.UTF8Encoding()
                Dim HashProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
                Dim TDESKey As Byte() = HashProvider.ComputeHash(UTF8.GetBytes(passphrase))
                Dim TDESAlgorithm As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
                TDESAlgorithm.Key = TDESKey
                TDESAlgorithm.Mode = CipherMode.ECB
                TDESAlgorithm.Padding = PaddingMode.PKCS7
                Dim DataToEncrypt As Byte() = UTF8.GetBytes(Message)

                Try
                    Dim Encryptor As ICryptoTransform = TDESAlgorithm.CreateEncryptor()
                    Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length)
                Finally
                    TDESAlgorithm.Clear()
                    HashProvider.Clear()
                End Try

                myResult = Convert.ToBase64String(Results)

            End If

            Return myResult
        End Get
    End Property

    Public ReadOnly Property DecryptMyMessage As String
        Get
            Dim myResult As String = "--"

            If passphrase.Length > 0 And Message.Length > 0 Then
                Try
                    Dim Results As Byte()
                    Dim UTF8 As System.Text.UTF8Encoding = New System.Text.UTF8Encoding()
                    Dim HashProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
                    Dim TDESKey As Byte() = HashProvider.ComputeHash(UTF8.GetBytes(passphrase))
                    Dim TDESAlgorithm As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
                    TDESAlgorithm.Key = TDESKey
                    TDESAlgorithm.Mode = CipherMode.ECB
                    TDESAlgorithm.Padding = PaddingMode.PKCS7
                    Dim DataToDecrypt As Byte() = Convert.FromBase64String(Message)

                    Try
                        Dim Decryptor As ICryptoTransform = TDESAlgorithm.CreateDecryptor()
                        Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length)
                    Finally
                        TDESAlgorithm.Clear()
                        HashProvider.Clear()
                    End Try

                    myResult = UTF8.GetString(Results)

                Catch ex As Exception
                    MsgBox("Not Valid message for this key!", MsgBoxStyle.Exclamation, "Failed!")
                End Try
            End If

            Return myResult
        End Get
    End Property

End Class
