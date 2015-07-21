Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Keys) As Integer
    Private Declare Sub mouse_event Lib "user32" (ByVal dwflags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cbuttons As Integer, ByVal dwextrainfo As Integer)
    Private Const mouseclickup = 4
    Private Const mouseclickdown = 2
    Dim startPressed As Boolean
    Dim stopPressed As Boolean
    Dim test As Integer
    Dim totalTime As Integer


    Private Sub txtStartHotkey_Click(sender As Object, e As EventArgs) Handles txtStartHotkey.Click
        tmrStartStopKeyFinder.Enabled = False
        txtStartHotkey.Text = "Press Desired Key"
    End Sub


    Private Sub txtStartHotkey_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStartHotkey.KeyDown
        Settings.setStartKey(e.KeyCode)
        Label1.Focus()
        txtStartHotkey.Text = Settings.getStartKey().ToString()
        tmrStartStopKeyFinder.Enabled = True
        clicker.Enabled = False
    End Sub

    Private Sub txtStopHotkey_Click(sender As Object, e As EventArgs) Handles txtStopHotkey.Click
        tmrStartStopKeyFinder.Enabled = False
        txtStopHotkey.Text = "Press Desired Key"
    End Sub

    Private Sub txtStopHotkey_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStopHotkey.KeyDown
        Settings.setStopKey(e.KeyCode)
        Label1.Focus()
        txtStopHotkey.Text = Settings.getStopKey().ToString()
        tmrStartStopKeyFinder.Enabled = True
        clicker.Enabled = False

    End Sub

    Private Sub tmrStartStopKeyFinder_Tick(sender As Object, e As EventArgs) Handles tmrStartStopKeyFinder.Tick
        'Set textbox keys
        txtStartHotkey.Text = Settings.getStartKey().ToString()
        txtStopHotkey.Text = Settings.getStopKey().ToString()


        'Check the keys pressed
        startPressed = GetAsyncKeyState(Settings.getStartKey())
        stopPressed = GetAsyncKeyState(Settings.getStopKey())

        If startPressed = True Or stopPressed = True Then

            'Check the keys pressed
            startPressed = GetAsyncKeyState(Settings.getStartKey())
            stopPressed = GetAsyncKeyState(Settings.getStopKey())

            If clicker.Enabled = True Then
                If stopPressed = True Then
                    Threading.Thread.Sleep(500)
                    clicker.Enabled = False
                    timeCounter.Enabled = False



                    'lblTotalTime.Text = "Time: " + Math.Round(totalTime / 60, 2).ToString() + " mins"
                End If
            Else
                If startPressed = True Then
                    Threading.Thread.Sleep(500)
                    clicker.Enabled = True
                    timeCounter.Enabled = True
                End If
            End If
        End If


        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(totalTime)

        lblTotalTime.Text = "Time: " + iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" & _
                                iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                                iSpan.Seconds.ToString.PadLeft(2, "0"c)

        'Me.Text = clicker.Enabled.ToString() + " " + tmrStartStopKeyFinder.Enabled.ToString()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        test = 1
        clicker.Interval = 9999999

        Settings.setStartKey(My.Settings.startKey)
        txtStartHotkey.Text = Settings.getStartKey().ToString()
        Settings.setStopKey(My.Settings.stopKey)
        txtStopHotkey.Text = Settings.getStopKey().ToString()

        startPressed = False
        stopPressed = False

        tmrStartStopKeyFinder.Interval = 100
        tmrStartStopKeyFinder.Enabled = False

        Me.Focus()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clicker.Enabled = False
        clicker.Interval = 1000 / txtCps.Text
        clicker.Enabled = False
        tmrStartStopKeyFinder.Enabled = True


    End Sub

    Private Sub clicker_Tick(sender As Object, e As EventArgs) Handles clicker.Tick
        mouse_event(mouseclickup, 0, 0, 0, 0)
        mouse_event(mouseclickdown, 0, 0, 0, 0)

    End Sub

    Private Sub lblTest_Click(sender As Object, e As EventArgs) Handles lblTest.Click
        test = test + 1
        lblTest.Text = "Test me: " + test.ToString()

    End Sub

    Private Sub txtStartHotkey_TextChanged(sender As Object, e As EventArgs) Handles txtStartHotkey.TextChanged

    End Sub

    Private Sub timeCounter_Tick(sender As Object, e As EventArgs) Handles timeCounter.Tick
        totalTime = totalTime + 1

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        test = 0
        lblTest.Text = "Test me: " + test.ToString()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        totalTime = 0
    End Sub
End Class
