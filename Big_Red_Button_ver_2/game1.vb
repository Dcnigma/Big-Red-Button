''' <summary>
''' Simple Jackpot Game
''' </summary>
''' <remarks></remarks>
Public Class game1
    Dim m, a, b, c As Integer
    'Mouse Dectector class for outside Form1
    Private Declare Sub Sleep Lib "kernel32" (ByVal d As Long)
    Private WithEvents MouseDetector As MouseDetector


    'Timer time
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        m = m + 11
        If m < 98 Then

            a = Int(1 + Rnd() * 3)

            b = Int(1 + Rnd() * 3)

            c = Int(1 + Rnd() * 3)

            Select Case a
                Case 1
                    PictureBox1.Image = My.Resources._13729
                Case 2
                    PictureBox1.Image = My.Resources._20120731024244
                Case 3
                    PictureBox1.Image = My.Resources.slots_inferno_jackpot_casino

            End Select

            Select Case b
                Case 1
                    PictureBox2.Image = My.Resources._13729
                Case 2
                    PictureBox2.Image = My.Resources._20120731024244
                Case 3
                    PictureBox2.Image = My.Resources.slots_inferno_jackpot_casino

            End Select
            Select Case c
                Case 1
                    PictureBox3.Image = My.Resources._13729
                Case 2
                    PictureBox3.Image = My.Resources._20120731024244
                Case 3
                    PictureBox3.Image = My.Resources.slots_inferno_jackpot_casino

            End Select

        Else
            Timer1.Enabled = False
            m = 0
            If a = b And b = c Then

                Label6.Text = "Jackpot!" & vbCrLf & "You won $1,000"
                If IsNumeric(Score.Text) Then
                    Score.Text = CInt(Score.Text) + 1000
                Else
                    Score.Text = 0
                End If
            Else
                'If a = b Then
                'Label6.Text = "Jackpot!" & vbCrLf & "You won $1,000"
                'If IsNumeric(Score.Text) Then
                ' Score.Text = CInt(Score.Text) + 1000
                ' Else
                ' Score.Text = 0
                'End If
                '   Else
                '  If b = c Then
                'Label6.Text = "Jackpot!" & vbCrLf & "You won $500"
                'If IsNumeric(Score.Text) Then
                ' Score.Text = CInt(Score.Text) + 500
                'Else
                'Score.Text = 0
                ' End If
                '    Else
                If a = c Then
                    Label6.Text = "Bonus!" & vbCrLf & "You won $10"
                    If IsNumeric(Score.Text) Then
                        Score.Text = CInt(Score.Text) + 10
                    Else
                        Score.Text = 0
                    End If
                Else
                    Label6.Text = "No luck, try again" & vbCrLf & "You lose $10"
                    If IsNumeric(Score.Text) Then
                        Score.Text = CInt(Score.Text) - 10
                    Else
                        Score.Text = 0
                    End If

                End If
            End If
        End If
        'End If
        'End If
    End Sub

    'load mousedetector outside form
    Private Sub game1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        RemoveHandler MouseDetector.MouseLeftButtonClick, AddressOf MouseDetector_MouseLeftButtonClick
        RemoveHandler MouseDetector.MouseRightButtonClick, AddressOf MouseDetector_MouseRightButtonClick
        MouseDetector.Dispose()
    End Sub
    Private Sub game1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Luisteren naar keycodes Code: Exit on "ESC" and "Space Bar"
        If e.KeyCode = Keys.Escape Then
            Form1.Show()
            Me.Close()
        End If
        If e.KeyCode = Keys.Space Then
            Form1.Show()
            Me.Close()
        End If
    End Sub
    Private Sub game1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Startup commands
        MouseDetector = New MouseDetector
    End Sub
    ''' <summary>
    ''' mouse commands
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub MouseDetector_MouseLeftButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MouseDetector.MouseLeftButtonClick
        'Luisteren naar Linker muis knop
    End Sub

    Private Sub MouseDetector_MouseRightButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MouseDetector.MouseRightButtonClick
        'Luisteren naar Rechter muis knop
        Timer1.Enabled = True
        Label6.Text = ""
        If IsNumeric(LabelTime.Text) Then
            LabelTime.Text = CInt(LabelTime.Text) + 1
        Else
            LabelTime.Text = 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer1.Enabled = True
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
End Class