<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Initial
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_decryptedtext = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_encryptedText = New System.Windows.Forms.TextBox()
        Me.btn_encrypt = New System.Windows.Forms.Button()
        Me.txt_plainTest = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(174, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 34)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Decrypt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Plain Text:"
        '
        'txt_decryptedtext
        '
        Me.txt_decryptedtext.Location = New System.Drawing.Point(174, 243)
        Me.txt_decryptedtext.Name = "txt_decryptedtext"
        Me.txt_decryptedtext.Size = New System.Drawing.Size(196, 20)
        Me.txt_decryptedtext.TabIndex = 15
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(393, 94)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(111, 99)
        Me.btn_save.TabIndex = 14
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Cipher Text:"
        '
        'txt_encryptedText
        '
        Me.txt_encryptedText.Location = New System.Drawing.Point(174, 129)
        Me.txt_encryptedText.Name = "txt_encryptedText"
        Me.txt_encryptedText.Size = New System.Drawing.Size(196, 20)
        Me.txt_encryptedText.TabIndex = 12
        '
        'btn_encrypt
        '
        Me.btn_encrypt.Location = New System.Drawing.Point(174, 63)
        Me.btn_encrypt.Name = "btn_encrypt"
        Me.btn_encrypt.Size = New System.Drawing.Size(196, 36)
        Me.btn_encrypt.TabIndex = 11
        Me.btn_encrypt.Text = "Encrypt"
        Me.btn_encrypt.UseVisualStyleBackColor = True
        '
        'txt_plainTest
        '
        Me.txt_plainTest.Location = New System.Drawing.Point(174, 25)
        Me.txt_plainTest.Name = "txt_plainTest"
        Me.txt_plainTest.Size = New System.Drawing.Size(196, 20)
        Me.txt_plainTest.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Enter Text:"
        '
        'frm_Initial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 314)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_decryptedtext)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_encryptedText)
        Me.Controls.Add(Me.btn_encrypt)
        Me.Controls.Add(Me.txt_plainTest)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Initial"
        Me.Text = "Encryption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_decryptedtext As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_encryptedText As TextBox
    Friend WithEvents btn_encrypt As Button
    Friend WithEvents txt_plainTest As TextBox
    Friend WithEvents Label1 As Label
End Class
