<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClockControl
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.controlTimer = New System.Windows.Forms.Timer(Me.components)
        Me.cmdAlarmSet = New System.Windows.Forms.Button()
        Me.cmdStopAlarm = New System.Windows.Forms.Button()
        Me.optPM = New System.Windows.Forms.RadioButton()
        Me.optAM = New System.Windows.Forms.RadioButton()
        Me.optAlarmOn = New System.Windows.Forms.RadioButton()
        Me.optAlarmOff = New System.Windows.Forms.RadioButton()
        Me.grpAlarmEnable = New System.Windows.Forms.GroupBox()
        Me.pnlAlarm = New System.Windows.Forms.Panel()
        Me.cboHours = New System.Windows.Forms.ComboBox()
        Me.cboMinutes = New System.Windows.Forms.ComboBox()
        Me.grpAlarmEnable.SuspendLayout()
        Me.pnlAlarm.SuspendLayout()
        Me.SuspendLayout()
        '
        'controlTimer
        '
        Me.controlTimer.Enabled = True
        Me.controlTimer.Interval = 1000
        '
        'cmdAlarmSet
        '
        Me.cmdAlarmSet.Location = New System.Drawing.Point(98, 14)
        Me.cmdAlarmSet.Name = "cmdAlarmSet"
        Me.cmdAlarmSet.Size = New System.Drawing.Size(36, 25)
        Me.cmdAlarmSet.TabIndex = 2
        Me.cmdAlarmSet.Text = "Set"
        Me.cmdAlarmSet.UseVisualStyleBackColor = True
        '
        'cmdStopAlarm
        '
        Me.cmdStopAlarm.Location = New System.Drawing.Point(98, 14)
        Me.cmdStopAlarm.Name = "cmdStopAlarm"
        Me.cmdStopAlarm.Size = New System.Drawing.Size(36, 25)
        Me.cmdStopAlarm.TabIndex = 6
        Me.cmdStopAlarm.Text = "Off"
        Me.cmdStopAlarm.UseVisualStyleBackColor = True
        Me.cmdStopAlarm.Visible = False
        '
        'optPM
        '
        Me.optPM.AutoSize = True
        Me.optPM.Location = New System.Drawing.Point(53, 29)
        Me.optPM.Name = "optPM"
        Me.optPM.Size = New System.Drawing.Size(41, 17)
        Me.optPM.TabIndex = 5
        Me.optPM.Text = "PM"
        Me.optPM.UseVisualStyleBackColor = True
        '
        'optAM
        '
        Me.optAM.AutoSize = True
        Me.optAM.Checked = True
        Me.optAM.Location = New System.Drawing.Point(6, 29)
        Me.optAM.Name = "optAM"
        Me.optAM.Size = New System.Drawing.Size(41, 17)
        Me.optAM.TabIndex = 4
        Me.optAM.TabStop = True
        Me.optAM.Text = "AM"
        Me.optAM.UseVisualStyleBackColor = True
        '
        'optAlarmOn
        '
        Me.optAlarmOn.AutoSize = True
        Me.optAlarmOn.Location = New System.Drawing.Point(6, 15)
        Me.optAlarmOn.Name = "optAlarmOn"
        Me.optAlarmOn.Size = New System.Drawing.Size(39, 17)
        Me.optAlarmOn.TabIndex = 7
        Me.optAlarmOn.Text = "On"
        Me.optAlarmOn.UseVisualStyleBackColor = True
        '
        'optAlarmOff
        '
        Me.optAlarmOff.AutoSize = True
        Me.optAlarmOff.Checked = True
        Me.optAlarmOff.Location = New System.Drawing.Point(50, 15)
        Me.optAlarmOff.Name = "optAlarmOff"
        Me.optAlarmOff.Size = New System.Drawing.Size(37, 18)
        Me.optAlarmOff.TabIndex = 8
        Me.optAlarmOff.TabStop = True
        Me.optAlarmOff.Text = "Off"
        Me.optAlarmOff.UseCompatibleTextRendering = True
        Me.optAlarmOff.UseVisualStyleBackColor = True
        '
        'grpAlarmEnable
        '
        Me.grpAlarmEnable.Controls.Add(Me.optAlarmOn)
        Me.grpAlarmEnable.Controls.Add(Me.optAlarmOff)
        Me.grpAlarmEnable.Location = New System.Drawing.Point(23, 49)
        Me.grpAlarmEnable.Name = "grpAlarmEnable"
        Me.grpAlarmEnable.Size = New System.Drawing.Size(97, 39)
        Me.grpAlarmEnable.TabIndex = 9
        Me.grpAlarmEnable.TabStop = False
        Me.grpAlarmEnable.Text = "Alarm:"
        '
        'pnlAlarm
        '
        Me.pnlAlarm.Controls.Add(Me.cboHours)
        Me.pnlAlarm.Controls.Add(Me.cboMinutes)
        Me.pnlAlarm.Controls.Add(Me.cmdStopAlarm)
        Me.pnlAlarm.Controls.Add(Me.optPM)
        Me.pnlAlarm.Controls.Add(Me.cmdAlarmSet)
        Me.pnlAlarm.Controls.Add(Me.optAM)
        Me.pnlAlarm.Location = New System.Drawing.Point(4, 88)
        Me.pnlAlarm.Name = "pnlAlarm"
        Me.pnlAlarm.Size = New System.Drawing.Size(139, 51)
        Me.pnlAlarm.TabIndex = 10
        '
        'cboHours
        '
        Me.cboHours.DropDownHeight = 100
        Me.cboHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHours.FormattingEnabled = True
        Me.cboHours.IntegralHeight = False
        Me.cboHours.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboHours.Location = New System.Drawing.Point(3, 6)
        Me.cboHours.Name = "cboHours"
        Me.cboHours.Size = New System.Drawing.Size(41, 21)
        Me.cboHours.TabIndex = 11
        '
        'cboMinutes
        '
        Me.cboMinutes.DropDownHeight = 100
        Me.cboMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinutes.FormattingEnabled = True
        Me.cboMinutes.IntegralHeight = False
        Me.cboMinutes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09"})
        Me.cboMinutes.Location = New System.Drawing.Point(53, 6)
        Me.cboMinutes.Name = "cboMinutes"
        Me.cboMinutes.Size = New System.Drawing.Size(41, 21)
        Me.cboMinutes.TabIndex = 12
        '
        'ClockControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlAlarm)
        Me.Controls.Add(Me.grpAlarmEnable)
        Me.Name = "ClockControl"
        Me.Size = New System.Drawing.Size(146, 150)
        Me.grpAlarmEnable.ResumeLayout(False)
        Me.grpAlarmEnable.PerformLayout()
        Me.pnlAlarm.ResumeLayout(False)
        Me.pnlAlarm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents controlTimer As Timer
    Friend WithEvents cmdAlarmSet As Button
    Friend WithEvents optPM As RadioButton
    Friend WithEvents optAM As RadioButton
    Friend WithEvents cmdStopAlarm As Button
    Friend WithEvents optAlarmOn As RadioButton
    Friend WithEvents optAlarmOff As RadioButton
    Friend WithEvents grpAlarmEnable As GroupBox
    Friend WithEvents pnlAlarm As Panel
    Friend WithEvents cboHours As ComboBox
    Friend WithEvents cboMinutes As ComboBox
End Class
