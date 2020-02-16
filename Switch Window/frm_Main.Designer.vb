<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Me.btn_Settings = New System.Windows.Forms.Button()
        Me.txtBox_Player8 = New System.Windows.Forms.TextBox()
        Me.txtBox_Player7 = New System.Windows.Forms.TextBox()
        Me.txtBox_Player6 = New System.Windows.Forms.TextBox()
        Me.txtBox_Player5 = New System.Windows.Forms.TextBox()
        Me.txtBox_Player4 = New System.Windows.Forms.TextBox()
        Me.txtBox_Player3 = New System.Windows.Forms.TextBox()
        Me.txtBox_Player2 = New System.Windows.Forms.TextBox()
        Me.txtBox_Player1 = New System.Windows.Forms.TextBox()
        Me.btn_f1 = New System.Windows.Forms.Button()
        Me.btn_f2 = New System.Windows.Forms.Button()
        Me.btn_f5 = New System.Windows.Forms.Button()
        Me.btn_f6 = New System.Windows.Forms.Button()
        Me.btn_f7 = New System.Windows.Forms.Button()
        Me.btn_f8 = New System.Windows.Forms.Button()
        Me.btn_f4 = New System.Windows.Forms.Button()
        Me.btn_f3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Settings
        '
        Me.btn_Settings.Location = New System.Drawing.Point(12, 220)
        Me.btn_Settings.Name = "btn_Settings"
        Me.btn_Settings.Size = New System.Drawing.Size(153, 23)
        Me.btn_Settings.TabIndex = 4
        Me.btn_Settings.Text = "Paramètres"
        Me.btn_Settings.UseVisualStyleBackColor = True
        '
        'txtBox_Player8
        '
        Me.txtBox_Player8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_8", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Player8.Location = New System.Drawing.Point(12, 194)
        Me.txtBox_Player8.Name = "txtBox_Player8"
        Me.txtBox_Player8.ReadOnly = True
        Me.txtBox_Player8.Size = New System.Drawing.Size(120, 20)
        Me.txtBox_Player8.TabIndex = 10
        Me.txtBox_Player8.Text = Global.Switch_Window.My.MySettings.Default.Player_8
        '
        'txtBox_Player7
        '
        Me.txtBox_Player7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_7", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Player7.Location = New System.Drawing.Point(12, 168)
        Me.txtBox_Player7.Name = "txtBox_Player7"
        Me.txtBox_Player7.ReadOnly = True
        Me.txtBox_Player7.Size = New System.Drawing.Size(120, 20)
        Me.txtBox_Player7.TabIndex = 9
        Me.txtBox_Player7.Text = Global.Switch_Window.My.MySettings.Default.Player_7
        '
        'txtBox_Player6
        '
        Me.txtBox_Player6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_6", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Player6.Location = New System.Drawing.Point(12, 142)
        Me.txtBox_Player6.Name = "txtBox_Player6"
        Me.txtBox_Player6.ReadOnly = True
        Me.txtBox_Player6.Size = New System.Drawing.Size(120, 20)
        Me.txtBox_Player6.TabIndex = 8
        Me.txtBox_Player6.Text = Global.Switch_Window.My.MySettings.Default.Player_6
        '
        'txtBox_Player5
        '
        Me.txtBox_Player5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_5", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Player5.Location = New System.Drawing.Point(12, 116)
        Me.txtBox_Player5.Name = "txtBox_Player5"
        Me.txtBox_Player5.ReadOnly = True
        Me.txtBox_Player5.Size = New System.Drawing.Size(120, 20)
        Me.txtBox_Player5.TabIndex = 7
        Me.txtBox_Player5.Text = Global.Switch_Window.My.MySettings.Default.Player_5
        '
        'txtBox_Player4
        '
        Me.txtBox_Player4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Player4.Location = New System.Drawing.Point(12, 90)
        Me.txtBox_Player4.Name = "txtBox_Player4"
        Me.txtBox_Player4.ReadOnly = True
        Me.txtBox_Player4.Size = New System.Drawing.Size(120, 20)
        Me.txtBox_Player4.TabIndex = 6
        Me.txtBox_Player4.Text = Global.Switch_Window.My.MySettings.Default.Player_4
        '
        'txtBox_Player3
        '
        Me.txtBox_Player3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Player3.Location = New System.Drawing.Point(12, 64)
        Me.txtBox_Player3.Name = "txtBox_Player3"
        Me.txtBox_Player3.ReadOnly = True
        Me.txtBox_Player3.Size = New System.Drawing.Size(120, 20)
        Me.txtBox_Player3.TabIndex = 5
        Me.txtBox_Player3.Text = Global.Switch_Window.My.MySettings.Default.Player_3
        '
        'txtBox_Player2
        '
        Me.txtBox_Player2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Player2.Location = New System.Drawing.Point(12, 38)
        Me.txtBox_Player2.Name = "txtBox_Player2"
        Me.txtBox_Player2.ReadOnly = True
        Me.txtBox_Player2.Size = New System.Drawing.Size(120, 20)
        Me.txtBox_Player2.TabIndex = 2
        Me.txtBox_Player2.Text = Global.Switch_Window.My.MySettings.Default.Player_2
        '
        'txtBox_Player1
        '
        Me.txtBox_Player1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Switch_Window.My.MySettings.Default, "Player_1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBox_Player1.Location = New System.Drawing.Point(12, 12)
        Me.txtBox_Player1.Name = "txtBox_Player1"
        Me.txtBox_Player1.ReadOnly = True
        Me.txtBox_Player1.Size = New System.Drawing.Size(120, 20)
        Me.txtBox_Player1.TabIndex = 0
        Me.txtBox_Player1.Text = Global.Switch_Window.My.MySettings.Default.Player_1
        '
        'btn_f1
        '
        Me.btn_f1.Location = New System.Drawing.Point(138, 11)
        Me.btn_f1.Name = "btn_f1"
        Me.btn_f1.Size = New System.Drawing.Size(27, 22)
        Me.btn_f1.TabIndex = 11
        Me.btn_f1.Text = "F1"
        Me.btn_f1.UseVisualStyleBackColor = True
        '
        'btn_f2
        '
        Me.btn_f2.Location = New System.Drawing.Point(138, 37)
        Me.btn_f2.Name = "btn_f2"
        Me.btn_f2.Size = New System.Drawing.Size(27, 22)
        Me.btn_f2.TabIndex = 12
        Me.btn_f2.Text = "F2"
        Me.btn_f2.UseVisualStyleBackColor = True
        '
        'btn_f5
        '
        Me.btn_f5.Location = New System.Drawing.Point(138, 115)
        Me.btn_f5.Name = "btn_f5"
        Me.btn_f5.Size = New System.Drawing.Size(27, 22)
        Me.btn_f5.TabIndex = 13
        Me.btn_f5.Text = "F5"
        Me.btn_f5.UseVisualStyleBackColor = True
        '
        'btn_f6
        '
        Me.btn_f6.Location = New System.Drawing.Point(138, 141)
        Me.btn_f6.Name = "btn_f6"
        Me.btn_f6.Size = New System.Drawing.Size(27, 22)
        Me.btn_f6.TabIndex = 14
        Me.btn_f6.Text = "F6"
        Me.btn_f6.UseVisualStyleBackColor = True
        '
        'btn_f7
        '
        Me.btn_f7.Location = New System.Drawing.Point(138, 167)
        Me.btn_f7.Name = "btn_f7"
        Me.btn_f7.Size = New System.Drawing.Size(27, 22)
        Me.btn_f7.TabIndex = 15
        Me.btn_f7.Text = "F7"
        Me.btn_f7.UseVisualStyleBackColor = True
        '
        'btn_f8
        '
        Me.btn_f8.Location = New System.Drawing.Point(138, 193)
        Me.btn_f8.Name = "btn_f8"
        Me.btn_f8.Size = New System.Drawing.Size(27, 22)
        Me.btn_f8.TabIndex = 16
        Me.btn_f8.Text = "F8"
        Me.btn_f8.UseVisualStyleBackColor = True
        '
        'btn_f4
        '
        Me.btn_f4.Location = New System.Drawing.Point(138, 89)
        Me.btn_f4.Name = "btn_f4"
        Me.btn_f4.Size = New System.Drawing.Size(27, 22)
        Me.btn_f4.TabIndex = 17
        Me.btn_f4.Text = "F4"
        Me.btn_f4.UseVisualStyleBackColor = True
        '
        'btn_f3
        '
        Me.btn_f3.Location = New System.Drawing.Point(138, 63)
        Me.btn_f3.Name = "btn_f3"
        Me.btn_f3.Size = New System.Drawing.Size(27, 22)
        Me.btn_f3.TabIndex = 18
        Me.btn_f3.Text = "F3"
        Me.btn_f3.UseVisualStyleBackColor = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_f3)
        Me.Controls.Add(Me.btn_f4)
        Me.Controls.Add(Me.btn_f8)
        Me.Controls.Add(Me.btn_f7)
        Me.Controls.Add(Me.btn_f6)
        Me.Controls.Add(Me.btn_f5)
        Me.Controls.Add(Me.btn_f2)
        Me.Controls.Add(Me.btn_f1)
        Me.Controls.Add(Me.txtBox_Player8)
        Me.Controls.Add(Me.txtBox_Player7)
        Me.Controls.Add(Me.txtBox_Player6)
        Me.Controls.Add(Me.txtBox_Player5)
        Me.Controls.Add(Me.txtBox_Player4)
        Me.Controls.Add(Me.txtBox_Player3)
        Me.Controls.Add(Me.btn_Settings)
        Me.Controls.Add(Me.txtBox_Player2)
        Me.Controls.Add(Me.txtBox_Player1)
        Me.Name = "frm_Main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBox_Player1 As TextBox
    Friend WithEvents txtBox_Player2 As TextBox
    Friend WithEvents btn_Settings As Button
    Friend WithEvents txtBox_Player3 As TextBox
    Friend WithEvents txtBox_Player4 As TextBox
    Friend WithEvents txtBox_Player6 As TextBox
    Friend WithEvents txtBox_Player5 As TextBox
    Friend WithEvents txtBox_Player8 As TextBox
    Friend WithEvents txtBox_Player7 As TextBox
    Friend WithEvents btn_f1 As Button
    Friend WithEvents btn_f2 As Button
    Friend WithEvents btn_f5 As Button
    Friend WithEvents btn_f6 As Button
    Friend WithEvents btn_f7 As Button
    Friend WithEvents btn_f8 As Button
    Friend WithEvents btn_f4 As Button
    Friend WithEvents btn_f3 As Button
End Class
