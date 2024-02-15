Imports MaterialSkin

Public Class FrmDBConnection
    Private Sub FrmDBConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Try
            Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Exception error on method 'BtnClose.Click'.{0}Message: {1}", Environment.NewLine, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class