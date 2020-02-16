Public Class frm_Main
    Private Sub btn_Settings_Click(sender As Object, e As EventArgs) Handles btn_Settings.Click
        Dim frm_Settings = New frm_Settings()
        frm_Settings.ShowDialog()
    End Sub
End Class
