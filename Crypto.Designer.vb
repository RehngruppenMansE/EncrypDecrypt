<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crypto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SourceTextBox = New System.Windows.Forms.TextBox()
        Me.EncryptedTextBox = New System.Windows.Forms.TextBox()
        Me.DecryptedTextBox = New System.Windows.Forms.TextBox()
        Me.KeyTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CryptoButton = New System.Windows.Forms.Button()
        Me.DecryptButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SourceTextBox
        '
        Me.SourceTextBox.Location = New System.Drawing.Point(36, 73)
        Me.SourceTextBox.Multiline = True
        Me.SourceTextBox.Name = "SourceTextBox"
        Me.SourceTextBox.Size = New System.Drawing.Size(416, 91)
        Me.SourceTextBox.TabIndex = 0
        '
        'EncryptedTextBox
        '
        Me.EncryptedTextBox.Location = New System.Drawing.Point(36, 183)
        Me.EncryptedTextBox.Multiline = True
        Me.EncryptedTextBox.Name = "EncryptedTextBox"
        Me.EncryptedTextBox.Size = New System.Drawing.Size(416, 99)
        Me.EncryptedTextBox.TabIndex = 1
        '
        'DecryptedTextBox
        '
        Me.DecryptedTextBox.Location = New System.Drawing.Point(36, 301)
        Me.DecryptedTextBox.Multiline = True
        Me.DecryptedTextBox.Name = "DecryptedTextBox"
        Me.DecryptedTextBox.Size = New System.Drawing.Size(416, 91)
        Me.DecryptedTextBox.TabIndex = 2
        '
        'KeyTextBox
        '
        Me.KeyTextBox.Location = New System.Drawing.Point(556, 66)
        Me.KeyTextBox.Name = "KeyTextBox"
        Me.KeyTextBox.Size = New System.Drawing.Size(199, 20)
        Me.KeyTextBox.TabIndex = 3
        Me.KeyTextBox.Text = "!@ZuR3FIL3SyNC..123!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(556, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Key"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Source"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Encrypted"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Decrypted"
        '
        'CryptoButton
        '
        Me.CryptoButton.Location = New System.Drawing.Point(559, 107)
        Me.CryptoButton.Name = "CryptoButton"
        Me.CryptoButton.Size = New System.Drawing.Size(196, 23)
        Me.CryptoButton.TabIndex = 7
        Me.CryptoButton.Text = "Crypt"
        Me.CryptoButton.UseVisualStyleBackColor = True
        '
        'DecryptButton
        '
        Me.DecryptButton.Location = New System.Drawing.Point(559, 141)
        Me.DecryptButton.Name = "DecryptButton"
        Me.DecryptButton.Size = New System.Drawing.Size(196, 23)
        Me.DecryptButton.TabIndex = 7
        Me.DecryptButton.Text = "DeCrypt"
        Me.DecryptButton.UseVisualStyleBackColor = True
        '
        'Crypto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 460)
        Me.Controls.Add(Me.DecryptButton)
        Me.Controls.Add(Me.CryptoButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KeyTextBox)
        Me.Controls.Add(Me.DecryptedTextBox)
        Me.Controls.Add(Me.EncryptedTextBox)
        Me.Controls.Add(Me.SourceTextBox)
        Me.Name = "Crypto"
        Me.Text = "Crypto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SourceTextBox As TextBox
    Friend WithEvents EncryptedTextBox As TextBox
    Friend WithEvents DecryptedTextBox As TextBox
    Friend WithEvents KeyTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CryptoButton As Button
    Friend WithEvents DecryptButton As Button
End Class
