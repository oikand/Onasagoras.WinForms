Imports MaterialSkin

Public Class FrmUserLogin
    Private Sub FrmUserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
        Catch ex As Exception
            MessageBox.Show(String.Format("Exception error on method 'FrmUserLogin.Load'.{0}Message: {1}", Environment.NewLine, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Try
            Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Exception error on method 'BtnCancel.Click'.{0}Message: {1}", Environment.NewLine, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Try
            Dim frm As New FrmMain
            frm.Show()
            Hide()
        Catch ex As Exception
            MessageBox.Show(String.Format("Exception error on method 'BtnOK.Click'.{0}Message: {1}", Environment.NewLine, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDBConnection_Click(sender As Object, e As EventArgs) Handles BtnDBConnection.Click
        Try
            Using frm As New FrmDBConnection
                frm.ShowDialog(Me)
            End Using
        Catch ex As Exception
            MessageBox.Show(String.Format("Exception error on method 'BtnDBConnection.Click'.{0}Message: {1}", Environment.NewLine, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class