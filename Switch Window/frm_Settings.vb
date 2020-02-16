Public Class frm_Settings
    Private Sub btn_OpenDir_Click(sender As Object, e As EventArgs) Handles btn_OpenDir.Click
        Process.Start(My.Application.Info.DirectoryPath)
    End Sub
End Class