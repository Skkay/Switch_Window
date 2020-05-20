Public Class frm_Settings
    Private Sub btn_OpenDir_Click(sender As Object, e As EventArgs) Handles btn_OpenDir.Click
        Process.Start(My.Application.Info.DirectoryPath)
    End Sub

    Private Sub frm_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each i In [Enum].GetValues(GetType(Keys))
            cb_Settings_Player1.Items.Add(i)
            cb_Settings_Player2.Items.Add(i)
            cb_Settings_Player3.Items.Add(i)
            cb_Settings_Player4.Items.Add(i)
            cb_Settings_Player5.Items.Add(i)
            cb_Settings_Player6.Items.Add(i)
            cb_Settings_Player7.Items.Add(i)
            cb_Settings_Player8.Items.Add(i)
        Next

        cb_Settings_Player1.SelectedIndex = cb_Settings_Player1.FindStringExact(If(My.Settings.Shortcut_Player_1 <> "", My.Settings.Shortcut_Player_1, "None"))
        cb_Settings_Player2.SelectedIndex = cb_Settings_Player2.FindStringExact(If(My.Settings.Shortcut_Player_2 <> "", My.Settings.Shortcut_Player_2, "None"))
        cb_Settings_Player3.SelectedIndex = cb_Settings_Player3.FindStringExact(If(My.Settings.Shortcut_Player_3 <> "", My.Settings.Shortcut_Player_3, "None"))
        cb_Settings_Player4.SelectedIndex = cb_Settings_Player4.FindStringExact(If(My.Settings.Shortcut_Player_4 <> "", My.Settings.Shortcut_Player_4, "None"))
        cb_Settings_Player5.SelectedIndex = cb_Settings_Player5.FindStringExact(If(My.Settings.Shortcut_Player_5 <> "", My.Settings.Shortcut_Player_5, "None"))
        cb_Settings_Player6.SelectedIndex = cb_Settings_Player6.FindStringExact(If(My.Settings.Shortcut_Player_6 <> "", My.Settings.Shortcut_Player_6, "None"))
        cb_Settings_Player7.SelectedIndex = cb_Settings_Player7.FindStringExact(If(My.Settings.Shortcut_Player_7 <> "", My.Settings.Shortcut_Player_7, "None"))
        cb_Settings_Player8.SelectedIndex = cb_Settings_Player8.FindStringExact(If(My.Settings.Shortcut_Player_8 <> "", My.Settings.Shortcut_Player_8, "None"))
    End Sub
End Class