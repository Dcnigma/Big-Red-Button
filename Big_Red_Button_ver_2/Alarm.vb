Option Explicit On
Public Class Alarm
    'Delay module
    Private Declare Sub Sleep Lib "kernel32" (ByVal d As Long)
    'Mouse Dectector class for outside Form1
    Private WithEvents MouseDetector As MouseDetector

   

    'load mousedetector outside form
    Private Sub Alarm_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        RemoveHandler MouseDetector.MouseLeftButtonClick, AddressOf MouseDetector_MouseLeftButtonClick
        RemoveHandler MouseDetector.MouseRightButtonClick, AddressOf MouseDetector_MouseRightButtonClick
        MouseDetector.Dispose()
    End Sub
    Private Sub MouseDetector_MouseLeftButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MouseDetector.MouseLeftButtonClick
        'var mouse function left
        'counter temp
        If IsNumeric(LabelLeft.Text) Then
            LabelLeft.Text = CInt(LabelLeft.Text) + 1
        Else
            LabelLeft.Text = 1
        End If
    End Sub
    Private Sub MouseDetector_MouseRightButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MouseDetector.MouseRightButtonClick
        If IsNumeric(LabelRight.Text) Then
            LabelRight.Text = CInt(LabelRight.Text) + 1
        Else
            LabelRight.Text = 1
        End If

        If BreakorWork.Text = "break" Then
            Label3.Text = "0"
            Label2.Text = My.Settings.TImer_break
            Me.Opacity = "0"
            My.Settings.BreakorWork = "work"
            Min_Timer.Enabled = True
        ElseIf BreakorWork.Text = "work" Then
            Label3.Text = "0"
            Label2.Text = My.Settings.Timer_Alarm
            Me.Opacity = "0"
            My.Settings.BreakorWork = "break"
            Min_Timer.Enabled = True
        End If


    End Sub
    Private Sub Ani_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ani_Timer.Tick
        BreakorWork.Text = My.Settings.BreakorWork
        If IsNumeric(Label1.Text) Then
            Label1.Text = CInt(Label1.Text) + 1
        Else
            Label1.Text = 1
        End If

        If Label1.Text = 1 Then
            Me.BackgroundImage = My.Resources.foot_print_action_1

        End If

        If Label1.Text = 2 Then
            Me.BackgroundImage = My.Resources.foot_print_action_2
            Label1.Text = 0
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Working.Show()
        Me.Close()
    End Sub

    Private Sub Min_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Min_Timer.Tick

        If IsNumeric(Label3.Text) Then
            Label3.Text = CInt(Label3.Text) + 1
        Else
            Label3.Text = 1
        End If

    End Sub

    Private Sub Alarm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.KeyDown
        Working.Close()
        'Load class mousedetector
        MouseDetector = New MouseDetector
        'change text labels temp
        BreakorWork.Text = My.Settings.BreakorWork
        LabelLeft.Text = "mouse left"
        LabelRight.Text = "mouse right"
        Me.TopMost = True
        Me.Opacity = "100"
        Label2.Text = My.Settings.TImer_break
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.TextChanged
        If Label3.Text = Label2.Text Then
            Me.TopMost = True
            Min_Timer.Enabled = False
            Me.Opacity = "100"
        End If

    End Sub
End Class