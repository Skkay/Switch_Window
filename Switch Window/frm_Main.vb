﻿Public Class frm_Main

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
        RegisterHotKey(Me.Handle, HOTKEY_ID1, FsModifiers.None, Keys.F1)
        RegisterHotKey(Me.Handle, HOTKEY_ID2, FsModifiers.None, Keys.F2)
        RegisterHotKey(Me.Handle, HOTKEY_ID3, FsModifiers.None, Keys.F3)
        RegisterHotKey(Me.Handle, HOTKEY_ID4, FsModifiers.None, Keys.F4)
        RegisterHotKey(Me.Handle, HOTKEY_ID5, FsModifiers.None, Keys.F5)
        RegisterHotKey(Me.Handle, HOTKEY_ID6, FsModifiers.None, Keys.F6)
        RegisterHotKey(Me.Handle, HOTKEY_ID7, FsModifiers.None, Keys.F7)
        RegisterHotKey(Me.Handle, HOTKEY_ID8, FsModifiers.None, Keys.F8)

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
    End Sub


End Class
