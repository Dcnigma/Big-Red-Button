Option Explicit On
Public Class Working
    'Delay module
    Private Declare Sub Sleep Lib "kernel32" (ByVal d As Long)
  

    Private Sub Working_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        ' Form1.Show()
        '  Form1.TopMost = True
    End Sub
    Private Sub Working_Load(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.TopMost = False
            Form1.Show()
            Form1.TopMost = True
            Me.Close()
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If IsNumeric(Label1.Text) Then
            Label1.Text = CInt(Label1.Text) + 1
        Else
            Label1.Text = 1
        End If

        'If Label1.Text = 1 Then
        'Me.BackgroundImage = My.Resources.foot_print_action_1

        'End If
        '
        '    If Label1.Text = 2 Then
        '  Me.BackgroundImage = My.Resources.foot_print_action_2
        'Label1.Text = 0
        '   End If

        ' End Sub

    End Sub
    Private Sub Working_Load1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = False
        Form1.TopMost = False
        Form1.Hide()
        Me.TopMost = True
        Label2.Visible = False
        Button5.Visible = False
        'RectangleShape1.Visible = False
        TextBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Label3.Visible = False
        TextBox2.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        'change text labels temp
        LabelLeft.Text = "mouse left"
        LabelRight.Text = "mouse right"
        Label4.Text = My.Settings.Timer_Alarm
        Label5.Text = My.Settings.TImer_break
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If IsNumeric(TextBox2.Text) Then
            TextBox2.Text = CInt(TextBox2.Text) + 1
        Else
            TextBox2.Text = 1
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If IsNumeric(TextBox2.Text) Then
            TextBox2.Text = CInt(TextBox2.Text) - 1
        Else
            TextBox2.Text = 0
        End If
        If TextBox2.Text = -1 Then
            TextBox2.Text = 0
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If IsNumeric(TextBox1.Text) Then
            TextBox1.Text = CInt(TextBox1.Text) - 1
        Else
            TextBox1.Text = 0
        End If
        If TextBox1.Text = -1 Then
            TextBox1.Text = 0
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) Then
            TextBox1.Text = CInt(TextBox1.Text) + 1
        Else
            TextBox1.Text = 1
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer1.Enabled = True
        Label4.Text = My.Settings.Timer_Alarm
        My.Settings.Timer_Alarm = TextBox1.Text
        Label5.Text = My.Settings.TImer_break
        My.Settings.TImer_break = TextBox2.Text
        Label5.Text = My.Settings.TImer_break
        Label4.Text = My.Settings.Timer_Alarm
        Me.Opacity = 0
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Alarm.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Timer1.Enabled = True
        Label2.Visible = False
        Button5.Visible = False
        'RectangleShape1.Visible = False
        TextBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Label3.Visible = False
        TextBox2.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        My.Settings.TImer_break = "15"
        My.Settings.Timer_Alarm = "60"
        Label5.Text = My.Settings.TImer_break
        Label4.Text = My.Settings.Timer_Alarm
        Me.TopMost = False
        Me.Opacity = 0
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Timer1.Enabled = True
        Label2.Visible = False
        Button5.Visible = False
        'RectangleShape1.Visible = False
        TextBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Label3.Visible = False
        TextBox2.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        My.Settings.TImer_break = "15"
        My.Settings.Timer_Alarm = "120"
        Label5.Text = My.Settings.TImer_break
        Label4.Text = My.Settings.Timer_Alarm
        Me.Opacity = 0
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Timer1.Enabled = True
        Label2.Visible = False
        Button5.Visible = False
        'RectangleShape1.Visible = False
        TextBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Label3.Visible = False
        TextBox2.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        My.Settings.TImer_break = "30"
        My.Settings.Timer_Alarm = "240"
        Label5.Text = My.Settings.TImer_break
        Label4.Text = My.Settings.Timer_Alarm
        Me.Opacity = 0
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Label2.Visible = True
        Button5.Visible = True
        'RectangleShape1.Visible = True
        TextBox1.Visible = True
        Button1.Visible = True
        Button2.Visible = True
        Label3.Visible = True
        TextBox2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
        My.Settings.TImer_break = "15"
        My.Settings.Timer_Alarm = "60"
        Label5.Text = My.Settings.TImer_break
        Label4.Text = My.Settings.Timer_Alarm
        TextBox2.Text = My.Settings.TImer_break
        TextBox1.Text = My.Settings.Timer_Alarm
    End Sub

  

    Private Sub Label1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.TextChanged
        If Label1.Text = My.Settings.Timer_Alarm Then
            My.Settings.BreakorWork = "break"
            Alarm.Show()
            Alarm.TopMost = True
            Form1.Hide()
            Me.Opacity = 100
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form1.TopMost = True
        Form1.Show()
        Me.Close()


    End Sub
End Class
