Public Class frm_Main

    Enum FsModifiers
        None = 0
        Alt = 1
        Control = 2
        Shift = 4
        Windows = 8
        Alt_Ctrl = 3
        Alt_Shift = 5
        Alt_Windows = 9
        Ctrl_Shift = 6
        Ctrl_Windows = 10
        Shift_Windows = 12
        No_Repeat = 16384
    End Enum

    Declare Auto Function RegisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Integer, ByVal fsModifier As FsModifiers, ByVal vk As Keys) As Boolean

    Private Const HOTKEY_ID1 As Integer = 571584
    Private Const HOTKEY_ID2 As Integer = 752453
    Private Const HOTKEY_ID3 As Integer = 752454
    Private Const HOTKEY_ID4 As Integer = 752455
    Private Const HOTKEY_ID5 As Integer = 752456
    Private Const HOTKEY_ID6 As Integer = 752457
    Private Const HOTKEY_ID7 As Integer = 752458
    Private Const HOTKEY_ID8 As Integer = 752459
    Private Const WM_HOTKEY As Integer = 786


    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload_Hotkey()
    End Sub

    Private Sub Reload_Hotkey()
        RegisterHotKey(Me.Handle, HOTKEY_ID1, FsModifiers.None, CType([Enum].Parse(GetType(Keys), If(My.Settings.Shortcut_Player_1 <> "", My.Settings.Shortcut_Player_1, "None")), Keys))
        RegisterHotKey(Me.Handle, HOTKEY_ID2, FsModifiers.None, CType([Enum].Parse(GetType(Keys), If(My.Settings.Shortcut_Player_2 <> "", My.Settings.Shortcut_Player_2, "None")), Keys))
        RegisterHotKey(Me.Handle, HOTKEY_ID3, FsModifiers.None, CType([Enum].Parse(GetType(Keys), If(My.Settings.Shortcut_Player_3 <> "", My.Settings.Shortcut_Player_3, "None")), Keys))
        RegisterHotKey(Me.Handle, HOTKEY_ID4, FsModifiers.None, CType([Enum].Parse(GetType(Keys), If(My.Settings.Shortcut_Player_4 <> "", My.Settings.Shortcut_Player_4, "None")), Keys))
        RegisterHotKey(Me.Handle, HOTKEY_ID5, FsModifiers.None, CType([Enum].Parse(GetType(Keys), If(My.Settings.Shortcut_Player_5 <> "", My.Settings.Shortcut_Player_5, "None")), Keys))
        RegisterHotKey(Me.Handle, HOTKEY_ID6, FsModifiers.None, CType([Enum].Parse(GetType(Keys), If(My.Settings.Shortcut_Player_6 <> "", My.Settings.Shortcut_Player_6, "None")), Keys))
        RegisterHotKey(Me.Handle, HOTKEY_ID7, FsModifiers.None, CType([Enum].Parse(GetType(Keys), If(My.Settings.Shortcut_Player_7 <> "", My.Settings.Shortcut_Player_7, "None")), Keys))
        RegisterHotKey(Me.Handle, HOTKEY_ID8, FsModifiers.None, CType([Enum].Parse(GetType(Keys), If(My.Settings.Shortcut_Player_8 <> "", My.Settings.Shortcut_Player_8, "None")), Keys))
    End Sub


    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_HOTKEY
                If m.WParam = HOTKEY_ID1 Then
                    setOnForground(0)

                ElseIf m.WParam = HOTKEY_ID2 Then
                    setOnForground(1)

                ElseIf m.WParam = HOTKEY_ID3 Then
                    setOnForground(2)

                ElseIf m.WParam = HOTKEY_ID4 Then
                    setOnForground(3)

                ElseIf m.WParam = HOTKEY_ID5 Then
                    setOnForground(4)

                ElseIf m.WParam = HOTKEY_ID6 Then
                    setOnForground(5)

                ElseIf m.WParam = HOTKEY_ID7 Then
                    setOnForground(6)

                ElseIf m.WParam = HOTKEY_ID8 Then
                    setOnForground(7)

                End If
        End Select

        MyBase.WndProc(m)

    End Sub


    Private Sub setOnForground(i As Integer)
        Dim list_player As New List(Of String) From {txtBox_Player1.Text, txtBox_Player2.Text, txtBox_Player3.Text, txtBox_Player4.Text, txtBox_Player5.Text, txtBox_Player6.Text, txtBox_Player7.Text, txtBox_Player8.Text}

        Try
            AppActivate(list_player.Item(i))
        Catch
            If My.Settings.isShowingMsgBox Then
                MsgBox($"{list_player.Item(i)} est introuvable !", vbExclamation + vbSystemModal + vbMsgBoxSetForeground, "Personnage introuvable")

            End If
        End Try

    End Sub


    Private Sub btn_Settings_Click(sender As Object, e As EventArgs) Handles btn_Settings.Click
        Dim frm_Settings = New frm_Settings()
        frm_Settings.ShowDialog()
        Reload_Hotkey()
    End Sub

    Private Sub btn_f1_Click(sender As Object, e As EventArgs) Handles btn_f1.Click
        setOnForground(0)
    End Sub

    Private Sub btn_f2_Click(sender As Object, e As EventArgs) Handles btn_f2.Click
        setOnForground(1)
    End Sub

    Private Sub btn_f3_Click(sender As Object, e As EventArgs) Handles btn_f3.Click
        setOnForground(2)
    End Sub

    Private Sub btn_f4_Click(sender As Object, e As EventArgs) Handles btn_f4.Click
        setOnForground(3)
    End Sub

    Private Sub btn_f5_Click(sender As Object, e As EventArgs) Handles btn_f5.Click
        setOnForground(4)
    End Sub

    Private Sub btn_f6_Click(sender As Object, e As EventArgs) Handles btn_f6.Click
        setOnForground(5)
    End Sub

    Private Sub btn_f7_Click(sender As Object, e As EventArgs) Handles btn_f7.Click
        setOnForground(6)
    End Sub

    Private Sub btn_f8_Click(sender As Object, e As EventArgs) Handles btn_f8.Click
        setOnForground(7)
    End Sub
End Class
