'-----------------------------------------------------------------------------------------------------
'-                                          File Name : clsClockControl                              - 
'-                                          Part of Project: Assign10                                -
'-----------------------------------------------------------------------------------------------------
'-                                          Written By: Tyler Miller                                 -
'-                                          Written On: 04/16/2016                                   -
'-----------------------------------------------------------------------------------------------------
'- File Purpose:                                                                                     -
'- This file is the class that contains all of the information for the Clock Control dll file which  -
'- can be loaded as a control in Visual Studio.                                                      - 
'-----------------------------------------------------------------------------------------------------
'- Program Purpose:                                                                                  -
'- This control can be used as a clock/alarm clock on a form. The user can choose to set the alarm   -
'- or turn it off. Once the alarm is triggered, chimes will play for one minute or until the user    -
'- turns the alarm off.                                                                              -
'-----------------------------------------------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):                                                      -
'- blnAlarmActive - boolean that tells whether the alarm is active or inactive                       -
'- currForeColor - color that holds the current color for all text on control                        -
'- fntCourierNew - font that is used for the clock on the control                                    -
'- screenBrush - a brush used to paint the clock on the control                                      -
'- strAlarmTime - a string that holds the set alarm time                                             -
'-----------------------------------------------------------------------------------------------------
Public Class ClockControl
    Inherits System.Windows.Forms.UserControl

    'Declaring global variables
    Dim fntCourierNew As New Font("Courier New", 15, FontStyle.Bold)
    Dim screenBrush As New SolidBrush(Color.Black)
    Dim currForeColor As Color = Color.Black
    Dim blnAlarmActive As Boolean = False
    Dim strAlarmTime As String = Nothing

    'Setting/Overriding the ForeColor Property to use our selected forecolor
    Public Overrides Property ForeColor As Color
        Get
            Return (currForeColor)
        End Get
        Set(ByVal Value As Color)
            currForeColor = Value
            Me.Invalidate()
        End Set
    End Property

    Private Sub controlTimer_Tick(sender As Object, e As EventArgs) Handles controlTimer.Tick
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: controlTimer_Tick                                 -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 04/16/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the control timer ticks, which is set to tick every second.   -
        '- It will check to see if the alarm is active, if it is, it will check to see if the current time  -
        '- is also the alarm time. If so, the alarm will sound. Else, it will keep painting the system clock-
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- currTime - string that holds the current time                                                    -
        '----------------------------------------------------------------------------------------------------
        If blnAlarmActive = True Then
            Dim currTime As String = DateTime.Now.ToShortTimeString()
            If strAlarmTime = currTime Then
                playAlarmSound()
            End If
        End If
        Me.Refresh()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: OnPaint                                           -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 04/16/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the screen brush tries to paint to the screen. It will use the-
        '- current ForeColor and then set the current time to the screen every second.                      -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -                                                                     - 
        '- e – Holds the PaintEventArgs object sent to the routine                                          -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- currTime - string that holds the current time                                                    -
        '----------------------------------------------------------------------------------------------------
        screenBrush.Color = currForeColor
        e.Graphics.DrawString(DateTime.Now.ToLongTimeString, fntCourierNew, screenBrush, 1, 15)
        grpAlarmEnable.ForeColor = currForeColor
    End Sub

    Private Sub cmdAlarmSet_Click(sender As Object, e As EventArgs) Handles cmdAlarmSet.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmdAlarmSet_Click                                 -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 04/16/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the user presses the Set button. It will set the alarm to     -
        '- sound at the user designated alarm time and enable the alarm.                                    -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- currTime - string that holds the current time                                                    -
        '----------------------------------------------------------------------------------------------------
        Dim currTime As String = DateTime.Now.ToShortTimeString()

        If cboHours.SelectedItem <> Nothing And cboMinutes.SelectedItem <> Nothing Then
            strAlarmTime = cboHours.SelectedItem.ToString & ":" & cboMinutes.SelectedItem.ToString
            If optAM.Checked = True Then
                strAlarmTime = strAlarmTime & " AM"
            Else
                strAlarmTime = strAlarmTime & " PM"
            End If
            blnAlarmActive = True
            cmdStopAlarm.Visible = True
            enableAlarmControls(False)
            MessageBox.Show("Alarm is set for " & strAlarmTime)
        Else
            MessageBox.Show("Please set a time for the alarm to sound!")
        End If
    End Sub

    Private Sub cmdStopAlarm_Click(sender As Object, e As EventArgs) Handles cmdStopAlarm.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmdStopAlarm_Click                                -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 04/16/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        blnAlarmActive = False
        cmdStopAlarm.Visible = False
        enableAlarmControls(True)
    End Sub
    Sub playAlarmSound()
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: playAlarmSound()                                  -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 04/16/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the alarm is activated. It will sound the computer designated -
        '- sound to alert the user the alarm has been triggered.                                            -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
    End Sub

    Private Sub grpAlarmEnable_Enter(sender As Object, e As EventArgs) Handles grpAlarmEnable.Enter
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: grpAlarmEnable()                                  -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 04/16/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called to either enable or disable the alarm control. If it is enables, the   -
        '- user will see options for setting the alarm. If it is disabled, the options will be hidden and   -
        '- the alarm will be turned off.                                                                    -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        If optAlarmOff.Checked = True Then
            pnlAlarm.Visible = False
            blnAlarmActive = False
        End If
        If optAlarmOn.Checked = True Then
            pnlAlarm.Visible = True
        End If
    End Sub

    Private Sub optAlarmOff_CheckedChanged(sender As Object, e As EventArgs) Handles optAlarmOff.CheckedChanged
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: optAlarmOff                                       -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 04/16/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the AlarmOff radio button is changed. If its checked off, it  -
        '- will turn off the alarm and hide the alarm controls. If its checked on, it will turn on the alarm-
        '- and show the alarm controls for the user to set.                                                 -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        If optAlarmOff.Checked = True Then
            pnlAlarm.Visible = False
            blnAlarmActive = False
            cmdStopAlarm.Visible = False
        End If
        If optAlarmOn.Checked = True Then
            pnlAlarm.Visible = True
            enableAlarmControls(True)
        End If
    End Sub

    Private Sub ClockControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: ClockControl_Load                                 -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 04/16/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when teh control is loaded. It simply adds the rest of the minute      -
        '- options to the minutes combobox on the control.                                                  -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        For i = 10 To 59
            cboMinutes.Items.Add(i)
        Next
    End Sub

    Private Sub enableAlarmControls(ByVal blnOn As Boolean)
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: enableAlarmControls                               -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 04/16/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called to enable or disable the alarm controls on the control. It takes a     -
        '- boolean value to tell whether or not to enable or disable the controls.                          -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- blnOn - boolean variable that tells the sub to turn on or off the controls.                      -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        cboHours.Enabled = blnOn
        cboMinutes.Enabled = blnOn
        optAM.Enabled = blnOn
        optPM.Enabled = blnOn
    End Sub
End Class
