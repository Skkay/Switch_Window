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
        Me.txtBox_Settings_Player1 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player2 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player3 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player4 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player5 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player6 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player7 = New System.Windows.Forms.TextBox()
        Me.txtBox_Settings_Player8 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtBox_Settings_Player1
        '
        Me.txtBox_Settings_Player1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player1.Location = New System.Drawing.Point(12, 12)
        Me.txtBox_Settings_Player1.Name = "txtBox_Settings_Player1"
        Me.txtBox_Settings_Player1.Size = New System.Drawing.Size(100, 20)
        Me.txtBox_Settings_Player1.TabIndex = 0
        Me.txtBox_Settings_Player1.Text = Global.Switch_Window.My.MySettings.Default.Player_1
        '
        'txtBox_Settings_Player2
        '
        Me.txtBox_Settings_Player2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player2.Location = New System.Drawing.Point(12, 38)
        Me.txtBox_Settings_Player2.Name = "txtBox_Settings_Player2"
        Me.txtBox_Settings_Player2.Size = New System.Drawing.Size(100, 20)
        Me.txtBox_Settings_Player2.TabIndex = 1
        Me.txtBox_Settings_Player2.Text = Global.Switch_Window.My.MySettings.Default.Player_2
        '
        'txtBox_Settings_Player3
        '
        Me.txtBox_Settings_Player3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player3.Location = New System.Drawing.Point(12, 64)
        Me.txtBox_Settings_Player3.Name = "txtBox_Settings_Player3"
        Me.txtBox_Settings_Player3.Size = New System.Drawing.Size(100, 20)
        Me.txtBox_Settings_Player3.TabIndex = 2
        Me.txtBox_Settings_Player3.Text = Global.Switch_Window.My.MySettings.Default.Player_3
        '
        'txtBox_Settings_Player4
        '
        Me.txtBox_Settings_Player4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player4.Location = New System.Drawing.Point(12, 90)
        Me.txtBox_Settings_Player4.Name = "txtBox_Settings_Player4"
        Me.txtBox_Settings_Player4.Size = New System.Drawing.Size(100, 20)
        Me.txtBox_Settings_Player4.TabIndex = 3
        Me.txtBox_Settings_Player4.Text = Global.Switch_Window.My.MySettings.Default.Player_4
        '
        'txtBox_Settings_Player5
        '
        Me.txtBox_Settings_Player5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_5", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player5.Location = New System.Drawing.Point(12, 116)
        Me.txtBox_Settings_Player5.Name = "txtBox_Settings_Player5"
        Me.txtBox_Settings_Player5.Size = New System.Drawing.Size(100, 20)
        Me.txtBox_Settings_Player5.TabIndex = 4
        Me.txtBox_Settings_Player5.Text = Global.Switch_Window.My.MySettings.Default.Player_5
        '
        'txtBox_Settings_Player6
        '
        Me.txtBox_Settings_Player6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_6", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player6.Location = New System.Drawing.Point(12, 142)
        Me.txtBox_Settings_Player6.Name = "txtBox_Settings_Player6"
        Me.txtBox_Settings_Player6.Size = New System.Drawing.Size(100, 20)
        Me.txtBox_Settings_Player6.TabIndex = 5
        Me.txtBox_Settings_Player6.Text = Global.Switch_Window.My.MySettings.Default.Player_6
        '
        'txtBox_Settings_Player7
        '
        Me.txtBox_Settings_Player7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_7", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player7.Location = New System.Drawing.Point(12, 168)
        Me.txtBox_Settings_Player7.Name = "txtBox_Settings_Player7"
        Me.txtBox_Settings_Player7.Size = New System.Drawing.Size(100, 20)
        Me.txtBox_Settings_Player7.TabIndex = 6
        Me.txtBox_Settings_Player7.Text = Global.Switch_Window.My.MySettings.Default.Player_7
        '
        'txtBox_Settings_Player8
        '
        Me.txtBox_Settings_Player8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_8", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Settings_Player8.Location = New System.Drawing.Point(12, 194)
        Me.txtBox_Settings_Player8.Name = "txtBox_Settings_Player8"
        Me.txtBox_Settings_Player8.Size = New System.Drawing.Size(100, 20)
        Me.txtBox_Settings_Player8.TabIndex = 7
        Me.txtBox_Settings_Player8.Text = Global.Switch_Window.My.MySettings.Default.Player_8
        '
        'frm_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtBox_Settings_Player8)
        Me.Controls.Add(Me.txtBox_Settings_Player7)
        Me.Controls.Add(Me.txtBox_Settings_Player6)
        Me.Controls.Add(Me.txtBox_Settings_Player5)
        Me.Controls.Add(Me.txtBox_Settings_Player4)
        Me.Controls.Add(Me.txtBox_Settings_Player3)
        Me.Controls.Add(Me.txtBox_Settings_Player2)
        Me.Controls.Add(Me.txtBox_Settings_Player1)
        Me.Name = "frm_Settings"
        Me.Text = "frm_Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBox_Settings_Player1 As TextBox
    Friend WithEvents txtBox_Settings_Player2 As TextBox
    Friend WithEvents txtBox_Settings_Player3 As TextBox
    Friend WithEvents txtBox_Settings_Player4 As TextBox
    Friend WithEvents txtBox_Settings_Player5 As TextBox
    Friend WithEvents txtBox_Settings_Player6 As TextBox
    Friend WithEvents txtBox_Settings_Player7 As TextBox
    Friend WithEvents txtBox_Settings_Player8 As TextBox
End Class
