Imports MaterialSkin

Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
        Catch ex As Exception
            MessageBox.Show(String.Format("Exception error on method 'FrmMain.Load'.{0}Message: {1}", Environment.NewLine, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
