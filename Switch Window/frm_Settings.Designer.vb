<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Settings
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gb_PlayerName = New System.Windows.Forms.GroupBox()
        Me.gb_AppSettings = New System.Windows.Forms.GroupBox()
        Me.cb_MsgBoxError = New System.Windows.Forms.CheckBox()
        Me.cb_TopMost = New System.Windows.Forms.CheckBox()
        Me.txtBox_Settings_Player1 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player8 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player2 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player7 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player3 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player6 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player4 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player5 = New System.Windows.Forms.TextBox()
        Me.btn_OpenDir = New System.Windows.Forms.Button()
        Me.gb_PlayerName.SuspendLayout()
        Me.gb_AppSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_PlayerName
        '
        Me.gb_PlayerName.Controls.Add(Me.txtBox_Settings_Player1)
        Me.gb_PlayerName.Controls.Add(Me.txtBox_Settings_Player8)
        Me.gb_PlayerName.Controls.Add(Me.txtBox_Settings_Player2)
        Me.gb_PlayerName.Controls.Add(Me.txtBox_Settings_Player7)
        Me.gb_PlayerName.Controls.Add(Me.txtBox_Settings_Player3)
        Me.gb_PlayerName.Controls.Add(Me.txtBox_Settings_Player6)
        Me.gb_PlayerName.Controls.Add(Me.txtBox_Settings_Player4)
        Me.gb_PlayerName.Controls.Add(Me.txtBox_Settings_Player5)
        Me.gb_PlayerName.Location = New System.Drawing.Point(12, 12)
        Me.gb_PlayerName.Name = "gb_PlayerName"
        Me.gb_PlayerName.Size = New System.Drawing.Size(173, 230)
        Me.gb_PlayerName.TabIndex = 8
        Me.gb_PlayerName.TabStop = False
        Me.gb_PlayerName.Text = "Nom des personnages"
        '
        'gb_AppSettings
        '
        Me.gb_AppSettings.Controls.Add(Me.cb_MsgBoxError)
        Me.gb_AppSettings.Controls.Add(Me.cb_TopMost)
        Me.gb_AppSettings.Location = New System.Drawing.Point(191, 12)
        Me.gb_AppSettings.Name = "gb_AppSettings"
        Me.gb_AppSettings.Size = New System.Drawing.Size(173, 230)
        Me.gb_AppSettings.TabIndex = 9
        Me.gb_AppSettings.TabStop = False
        Me.gb_AppSettings.Text = "Paramètres d'application"
        '
        'cb_MsgBoxError
        '
        Me.cb_MsgBoxError.AutoSize = True
        Me.cb_MsgBoxError.Checked = Global.Switch_Window.My.MySettings.Default.isShowingMsgBox
        Me.cb_MsgBoxError.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_MsgBoxError.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Switch_Window.My.MySettings.Default, "isShowingMsgBox", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cb_MsgBoxError.Location = New System.Drawing.Point(6, 47)
        Me.cb_MsgBoxError.Name = "cb_MsgBoxError"
        Me.cb_MsgBoxError.Size = New System.Drawing.Size(125, 17)
        Me.cb_MsgBoxError.TabIndex = 1
        Me.cb_MsgBoxError.Text = "MessageBox d'erreur"
        Me.cb_MsgBoxError.UseVisualStyleBackColor = True
        '
        'cb_TopMost
        '
        Me.cb_TopMost.AutoSize = True
        Me.cb_TopMost.Checked = Global.Switch_Window.My.MySettings.Default.isTopMost
        Me.cb_TopMost.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Switch_Window.My.MySettings.Default, "isTopMost", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cb_TopMost.Enabled = False
        Me.cb_TopMost.Location = New System.Drawing.Point(6, 21)
        Me.cb_TopMost.Name = "cb_TopMost"
        Me.cb_TopMost.Size = New System.Drawing.Size(133, 17)
        Me.cb_TopMost.TabIndex = 0
        Me.cb_TopMost.Text = "Garder au premier plan"
        Me.cb_TopMost.UseVisualStyleBackColor = True
        '
        'txtBox_Settings_Player1
        '
        Me.txtBox_Settings_Player1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player1.Location = New System.Drawing.Point(6, 19)
        Me.txtBox_Settings_Player1.Name = "txtBox_Settings_Player1"
        Me.txtBox_Settings_Player1.Size = New System.Drawing.Size(159, 20)
        Me.txtBox_Settings_Player1.TabIndex = 0
        Me.txtBox_Settings_Player1.Text = Global.Switch_Window.My.MySettings.Default.Player_1
        '
        'txtBox_Settings_Player8
        '
        Me.txtBox_Settings_Player8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_8", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player8.Location = New System.Drawing.Point(6, 201)
        Me.txtBox_Settings_Player8.Name = "txtBox_Settings_Player8"
        Me.txtBox_Settings_Player8.Size = New System.Drawing.Size(159, 20)
        Me.txtBox_Settings_Player8.TabIndex = 7
        Me.txtBox_Settings_Player8.Text = Global.Switch_Window.My.MySettings.Default.Player_8
        '
        'txtBox_Settings_Player2
        '
        Me.txtBox_Settings_Player2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player2.Location = New System.Drawing.Point(6, 45)
        Me.txtBox_Settings_Player2.Name = "txtBox_Settings_Player2"
        Me.txtBox_Settings_Player2.Size = New System.Drawing.Size(159, 20)
        Me.txtBox_Settings_Player2.TabIndex = 1
        Me.txtBox_Settings_Player2.Text = Global.Switch_Window.My.MySettings.Default.Player_2
        '
        'txtBox_Settings_Player7
        '
        Me.txtBox_Settings_Player7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_7", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player7.Location = New System.Drawing.Point(6, 175)
        Me.txtBox_Settings_Player7.Name = "txtBox_Settings_Player7"
        Me.txtBox_Settings_Player7.Size = New System.Drawing.Size(159, 20)
        Me.txtBox_Settings_Player7.TabIndex = 6
        Me.txtBox_Settings_Player7.Text = Global.Switch_Window.My.MySettings.Default.Player_7
        '
        'txtBox_Settings_Player3
        '
        Me.txtBox_Settings_Player3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player3.Location = New System.Drawing.Point(6, 71)
        Me.txtBox_Settings_Player3.Name = "txtBox_Settings_Player3"
        Me.txtBox_Settings_Player3.Size = New System.Drawing.Size(159, 20)
        Me.txtBox_Settings_Player3.TabIndex = 2
        Me.txtBox_Settings_Player3.Text = Global.Switch_Window.My.MySettings.Default.Player_3
        '
        'txtBox_Settings_Player6
        '
        Me.txtBox_Settings_Player6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_6", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player6.Location = New System.Drawing.Point(6, 149)
        Me.txtBox_Settings_Player6.Name = "txtBox_Settings_Player6"
        Me.txtBox_Settings_Player6.Size = New System.Drawing.Size(159, 20)
        Me.txtBox_Settings_Player6.TabIndex = 5
        Me.txtBox_Settings_Player6.Text = Global.Switch_Window.My.MySettings.Default.Player_6
        '
        'txtBox_Settings_Player4
        '
        Me.txtBox_Settings_Player4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player4.Location = New System.Drawing.Point(6, 97)
        Me.txtBox_Settings_Player4.Name = "txtBox_Settings_Player4"
        Me.txtBox_Settings_Player4.Size = New System.Drawing.Size(159, 20)
        Me.txtBox_Settings_Player4.TabIndex = 3
        Me.txtBox_Settings_Player4.Text = Global.Switch_Window.My.MySettings.Default.Player_4
        '
        'txtBox_Settings_Player5
        '
        Me.txtBox_Settings_Player5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_5", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player5.Location = New System.Drawing.Point(6, 123)
        Me.txtBox_Settings_Player5.Name = "txtBox_Settings_Player5"
        Me.txtBox_Settings_Player5.Size = New System.Drawing.Size(159, 20)
        Me.txtBox_Settings_Player5.TabIndex = 4
        Me.txtBox_Settings_Player5.Text = Global.Switch_Window.My.MySettings.Default.Player_5
        '
        'btn_OpenDir
        '
        Me.btn_OpenDir.Location = New System.Drawing.Point(12, 248)
        Me.btn_OpenDir.Name = "btn_OpenDir"
        Me.btn_OpenDir.Size = New System.Drawing.Size(173, 23)
        Me.btn_OpenDir.TabIndex = 10
        Me.btn_OpenDir.Text = "Dossier d'application"
        Me.btn_OpenDir.UseVisualStyleBackColor = True
        '
        'frm_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_OpenDir)
        Me.Controls.Add(Me.gb_AppSettings)
        Me.Controls.Add(Me.gb_PlayerName)
        Me.Name = "frm_Settings"
        Me.Text = "frm_Settings"
        Me.gb_PlayerName.ResumeLayout(False)
        Me.gb_PlayerName.PerformLayout()
        Me.gb_AppSettings.ResumeLayout(False)
        Me.gb_AppSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtBox_Settings_Player1 As TextBox
    Friend WithEvents txtBox_Settings_Player2 As TextBox
    Friend WithEvents txtBox_Settings_Player3 As TextBox
    Friend WithEvents txtBox_Settings_Player4 As TextBox
    Friend WithEvents txtBox_Settings_Player5 As TextBox
    Friend WithEvents txtBox_Settings_Player6 As TextBox
    Friend WithEvents txtBox_Settings_Player7 As TextBox
    Friend WithEvents txtBox_Settings_Player8 As TextBox
    Friend WithEvents gb_PlayerName As GroupBox
    Friend WithEvents gb_AppSettings As GroupBox
    Friend WithEvents cb_MsgBoxError As CheckBox
    Friend WithEvents cb_TopMost As CheckBox
    Friend WithEvents btn_OpenDir As Button
End Class
