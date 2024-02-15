<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserLogin
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
        TxtUsername = New MaterialSkin.Controls.MaterialTextBox()
        TxtPassword = New MaterialSkin.Controls.MaterialTextBox()
        BtnOK = New MaterialSkin.Controls.MaterialButton()
        BtnCancel = New MaterialSkin.Controls.MaterialButton()
        BtnDBConnection = New MaterialSkin.Controls.MaterialButton()
        SuspendLayout()
        ' 
        ' TxtUsername
        ' 
        TxtUsername.AnimateReadOnly = False
        TxtUsername.BorderStyle = BorderStyle.None
        TxtUsername.Depth = 0
        TxtUsername.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtUsername.Hint = "Username"
        TxtUsername.LeadingIcon = Nothing
        TxtUsername.Location = New Point(53, 81)
        TxtUsername.MaxLength = 50
        TxtUsername.MouseState = MaterialSkin.MouseState.OUT
        TxtUsername.Multiline = False
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(280, 50)
        TxtUsername.TabIndex = 0
        TxtUsername.Text = ""
        TxtUsername.TrailingIcon = Nothing
        ' 
        ' TxtPassword
        ' 
        TxtPassword.AnimateReadOnly = False
        TxtPassword.BorderStyle = BorderStyle.None
        TxtPassword.Depth = 0
        TxtPassword.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtPassword.Hint = "Password"
        TxtPassword.LeadingIcon = Nothing
        TxtPassword.Location = New Point(55, 143)
        TxtPassword.MaxLength = 50
        TxtPassword.MouseState = MaterialSkin.MouseState.OUT
        TxtPassword.Multiline = False
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(280, 50)
        TxtPassword.TabIndex = 1
        TxtPassword.Text = ""
        TxtPassword.TrailingIcon = Nothing
        ' 
        ' BtnOK
        ' 
        BtnOK.AutoSize = False
        BtnOK.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnOK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnOK.Depth = 0
        BtnOK.HighEmphasis = True
        BtnOK.Icon = Nothing
        BtnOK.Location = New Point(106, 202)
        BtnOK.Margin = New Padding(4, 6, 4, 6)
        BtnOK.MouseState = MaterialSkin.MouseState.HOVER
        BtnOK.Name = "BtnOK"
        BtnOK.NoAccentTextColor = Color.Empty
        BtnOK.Size = New Size(80, 36)
        BtnOK.TabIndex = 2
        BtnOK.Text = "OK"
        BtnOK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnOK.UseAccentColor = False
        BtnOK.UseVisualStyleBackColor = True
        ' 
        ' BtnCancel
        ' 
        BtnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnCancel.Depth = 0
        BtnCancel.HighEmphasis = True
        BtnCancel.Icon = Nothing
        BtnCancel.Location = New Point(208, 202)
        BtnCancel.Margin = New Padding(4, 6, 4, 6)
        BtnCancel.MouseState = MaterialSkin.MouseState.HOVER
        BtnCancel.Name = "BtnCancel"
        BtnCancel.NoAccentTextColor = Color.Empty
        BtnCancel.Size = New Size(77, 36)
        BtnCancel.TabIndex = 3
        BtnCancel.Text = "Cancel"
        BtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnCancel.UseAccentColor = False
        BtnCancel.UseVisualStyleBackColor = True
        ' 
        ' BtnDBConnection
        ' 
        BtnDBConnection.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnDBConnection.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnDBConnection.Depth = 0
        BtnDBConnection.HighEmphasis = True
        BtnDBConnection.Icon = Nothing
        BtnDBConnection.Location = New Point(269, 245)
        BtnDBConnection.Margin = New Padding(4, 6, 4, 6)
        BtnDBConnection.MouseState = MaterialSkin.MouseState.HOVER
        BtnDBConnection.Name = "BtnDBConnection"
        BtnDBConnection.NoAccentTextColor = Color.Empty
        BtnDBConnection.Size = New Size(64, 36)
        BtnDBConnection.TabIndex = 4
        BtnDBConnection.Text = "DB"
        BtnDBConnection.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnDBConnection.UseAccentColor = False
        BtnDBConnection.UseVisualStyleBackColor = True
        ' 
        ' FrmUserLogin
        ' 
        AcceptButton = BtnOK
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = BtnCancel
        ClientSize = New Size(406, 329)
        Controls.Add(BtnDBConnection)
        Controls.Add(BtnCancel)
        Controls.Add(BtnOK)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUsername)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmUserLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Onasagoras - User Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtUsername As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TxtPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents BtnOK As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnCancel As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BtnDBConnection As MaterialSkin.Controls.MaterialButton
End Class
