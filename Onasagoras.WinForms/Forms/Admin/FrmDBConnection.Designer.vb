<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDBConnection
    Inherits MaterialSkin.Controls.MaterialForm

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
        TxtHost = New MaterialSkin.Controls.MaterialTextBox()
        TxtPort = New MaterialSkin.Controls.MaterialTextBox()
        TxtDatabase = New MaterialSkin.Controls.MaterialTextBox()
        TxtUsername = New MaterialSkin.Controls.MaterialTextBox()
        TxtPassword = New MaterialSkin.Controls.MaterialTextBox()
        BtnClose = New MaterialSkin.Controls.MaterialButton()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        SuspendLayout()
        ' 
        ' TxtHost
        ' 
        TxtHost.AnimateReadOnly = False
        TxtHost.BorderStyle = BorderStyle.None
        TxtHost.Depth = 0
        TxtHost.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtHost.Hint = "Host"
        TxtHost.LeadingIcon = Nothing
        TxtHost.Location = New Point(26, 92)
        TxtHost.MaxLength = 50
        TxtHost.MouseState = MaterialSkin.MouseState.OUT
        TxtHost.Multiline = False
        TxtHost.Name = "TxtHost"
        TxtHost.Size = New Size(230, 50)
        TxtHost.TabIndex = 0
        TxtHost.Text = ""
        TxtHost.TrailingIcon = Nothing
        ' 
        ' TxtPort
        ' 
        TxtPort.AnimateReadOnly = False
        TxtPort.BorderStyle = BorderStyle.None
        TxtPort.Depth = 0
        TxtPort.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtPort.Hint = "Port"
        TxtPort.LeadingIcon = Nothing
        TxtPort.Location = New Point(301, 92)
        TxtPort.MaxLength = 50
        TxtPort.MouseState = MaterialSkin.MouseState.OUT
        TxtPort.Multiline = False
        TxtPort.Name = "TxtPort"
        TxtPort.Size = New Size(230, 50)
        TxtPort.TabIndex = 1
        TxtPort.Text = ""
        TxtPort.TrailingIcon = Nothing
        ' 
        ' TxtDatabase
        ' 
        TxtDatabase.AnimateReadOnly = False
        TxtDatabase.BorderStyle = BorderStyle.None
        TxtDatabase.Depth = 0
        TxtDatabase.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtDatabase.Hint = "Database"
        TxtDatabase.LeadingIcon = Nothing
        TxtDatabase.Location = New Point(26, 175)
        TxtDatabase.MaxLength = 50
        TxtDatabase.MouseState = MaterialSkin.MouseState.OUT
        TxtDatabase.Multiline = False
        TxtDatabase.Name = "TxtDatabase"
        TxtDatabase.Size = New Size(230, 50)
        TxtDatabase.TabIndex = 2
        TxtDatabase.Text = ""
        TxtDatabase.TrailingIcon = Nothing
        ' 
        ' TxtUsername
        ' 
        TxtUsername.AnimateReadOnly = False
        TxtUsername.BorderStyle = BorderStyle.None
        TxtUsername.Depth = 0
        TxtUsername.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtUsername.Hint = "Username"
        TxtUsername.LeadingIcon = Nothing
        TxtUsername.Location = New Point(26, 263)
        TxtUsername.MaxLength = 50
        TxtUsername.MouseState = MaterialSkin.MouseState.OUT
        TxtUsername.Multiline = False
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(230, 50)
        TxtUsername.TabIndex = 3
        TxtUsername.Text = ""
        TxtUsername.TrailingIcon = Nothing
        ' 
        ' TxtPassword
        ' 
        TxtPassword.AnimateReadOnly = False
        TxtPassword.BorderStyle = BorderStyle.None
        TxtPassword.Depth = 0
        TxtPassword.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtPassword.Hint = "Password"
        TxtPassword.LeadingIcon = Nothing
        TxtPassword.Location = New Point(301, 263)
        TxtPassword.MaxLength = 50
        TxtPassword.MouseState = MaterialSkin.MouseState.OUT
        TxtPassword.Multiline = False
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(230, 50)
        TxtPassword.TabIndex = 4
        TxtPassword.Text = ""
        TxtPassword.TrailingIcon = Nothing
        ' 
        ' BtnClose
        ' 
        BtnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnClose.Depth = 0
        BtnClose.HighEmphasis = True
        BtnClose.Icon = Nothing
        BtnClose.Location = New Point(301, 342)
        BtnClose.Margin = New Padding(4, 6, 4, 6)
        BtnClose.MouseState = MaterialSkin.MouseState.HOVER
        BtnClose.Name = "BtnClose"
        BtnClose.NoAccentTextColor = Color.Empty
        BtnClose.Size = New Size(66, 36)
        BtnClose.TabIndex = 5
        BtnClose.Text = "Close"
        BtnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnClose.UseAccentColor = False
        BtnClose.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(192, 342)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(64, 36)
        MaterialButton1.TabIndex = 6
        MaterialButton1.Text = "Test"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' FrmDBConnection
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(561, 399)
        Controls.Add(MaterialButton1)
        Controls.Add(BtnClose)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUsername)
        Controls.Add(TxtDatabase)
        Controls.Add(TxtPort)
        Controls.Add(TxtHost)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmDBConnection"
        StartPosition = FormStartPosition.CenterParent
        Text = "Onasagoras - DB Connection"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtHost As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TxtPort As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TxtDatabase As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TxtUsername As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TxtPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents BtnClose As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
End Class
