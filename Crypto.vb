Public Class Crypto
    Private Sub CryptoButton_Click(sender As Object, e As EventArgs) Handles CryptoButton.Click

        Dim myCrypto As New CryptoClass

        myCrypto.passphrase = KeyTextBox.Text
        myCrypto.Message = SourceTextBox.Text

        EncryptedTextBox.Text = myCrypto.EncryptMyMessage

        myCrypto.Message = EncryptedTextBox.Text

        DecryptedTextBox.Text = myCrypto.DecryptMyMessage

    End Sub

    Private Sub DecryptButton_Click(sender As Object, e As EventArgs) Handles DecryptButton.Click

        Dim myCrypto As New CryptoClass

        myCrypto.passphrase = KeyTextBox.Text

        myCrypto.Message = SourceTextBox.Text

        DecryptedTextBox.Text = myCrypto.DecryptMyMessage

        myCrypto.Message = DecryptedTextBox.Text

        EncryptedTextBox.Text = myCrypto.EncryptMyMessage


    End Sub


End Class
