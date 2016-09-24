Public Class Punch_1


    Dim counter As Integer
    Dim state As Armen
    Dim speed As Integer

    Private Declare Sub Sleep Lib "kernel32" (ByVal d As Long)
    'Mouse Dectector class for outside Form1
    Private WithEvents MouseDetector As MouseDetector

    Enum Armen
        Armen1 = 1 ' Armen ani 1
        Armen2 = 2 ' Armen ani 2

    End Enum
    Private Sub Punch_1_Load(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form1.Show()
            Me.Close()
        End If
        If e.KeyCode = Keys.Space Then
            Form1.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Punch_1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load, MyBase.KeyDown

        speed = 0 ' Pixels per timer tick
        Timer1.Enabled = True
        PictureBox2.Visible = False
        Label1.Text = (0) ' set 0 for hidden picturebox 2
        'Load class mousedetector
        MouseDetector = New MouseDetector
        'change text labels temp
        LabelLeft.Text = "mouse left"
        LabelRight.Text = "mouse right"
    End Sub
    'load mousedetector outside form
    Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        RemoveHandler MouseDetector.MouseLeftButtonClick, AddressOf MouseDetector_MouseLeftButtonClick
        RemoveHandler MouseDetector.MouseRightButtonClick, AddressOf MouseDetector_MouseRightButtonClick
        MouseDetector.Dispose()
    End Sub
    Private Sub MouseDetector_MouseLeftButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MouseDetector.MouseLeftButtonClick
        'var mouse function left
        'load 
        state = Armen.Armen1
        'counter temp
        If IsNumeric(LabelRight.Text) Then
            LabelRight.Text = CInt(LabelRight.Text) + 1
        Else
            LabelRight.Text = 1
        End If

    End Sub
    Private Sub MouseDetector_MouseRightButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MouseDetector.MouseRightButtonClick

        'Give label number up
        Label1.Text = Label1.Text + 1
        PictureBox2.Visible = True
        'If label hit 13 reset
        If Label1.Text = 13 Then
            Label1.Text = 0
        End If
        'if label is 0 make visible
        If Label1.Text = (0) Then
            PictureBox2.Visible = False
        End If
        'change picture to label
        If Label1.Text = (1) Then
            PictureBox2.Visible = True
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_101
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_102
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_103
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_104
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_105
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_106
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_107
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_108
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_109
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_110
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_111
            Delay(0.1)
            PictureBox2.Visible = False
        End If
        If Label1.Text = (2) Then
            PictureBox2.Visible = False
        End If
        If Label1.Text = (3) Then
            PictureBox2.Visible = False
        End If
        If Label1.Text = (4) Then
            PictureBox2.Visible = False
        End If
        If Label1.Text = (5) Then
            PictureBox2.Visible = True
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_101
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_102
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_103
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_104
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_105
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_106
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_107
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_108
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_109
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_110
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_111
            Delay(0.1)
            PictureBox2.Visible = False
        End If
        If Label1.Text = (6) Then
            PictureBox2.Visible = False
        End If
        If Label1.Text = (7) Then
            PictureBox2.Visible = False
        End If
        If Label1.Text = (8) Then
            PictureBox2.Visible = False
        End If
        If Label1.Text = (9) Then
            PictureBox2.Visible = False
        End If
        If Label1.Text = (10) Then
            PictureBox2.Visible = True
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_101
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_102
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_103
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_104
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_105
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_106
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_107
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_108
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_109
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_110
            Delay(0.1)
            PictureBox2.Image = My.Resources.Resources.effect_111
            Delay(0.1)
            PictureBox2.Visible = False
        End If
        If Label1.Text = (11) Then
            PictureBox2.Visible = False
        End If
        'reset and hide picture box
        If Label1.Text = (12) Then
            PictureBox2.Visible = False
        End If
        'counter temp
        If IsNumeric(LabelLeft.Text) Then
            LabelLeft.Text = CInt(LabelLeft.Text) + 1
        Else
            LabelLeft.Text = 1
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Select Case state

            Case Armen.Armen1
                PictureBox1.Left = PictureBox1.Left - speed ' Move the sheep to the left
                PictureBox1.Image = My.Resources.Resources.effect_002 ' Switch to complementary image
                If PictureBox1.Left = 0 Then
                    state = Armen.Armen2 ' Plenty of room; extend the other legs
                    PictureBox1.Image = My.Resources.Resources.effect_001 ' Switch to complementary image
                Else
                    state = Armen.Armen1 ' Don't walk off the form -- turn around!
                    PictureBox1.Image = My.Resources.Resources.effect_002 ' Switch to complementary image
                End If

            Case Armen.Armen2
                PictureBox1.Left = PictureBox1.Left - speed ' Move the sheep to the left
                PictureBox1.Image = My.Resources.Resources.effect_001 ' Switch to complementary image
                If PictureBox1.Left = 0 Then
                    state = Armen.Armen1 ' Plenty of room; extend the other legs
                    PictureBox1.Image = My.Resources.Resources.effect_002 ' Switch to complementary image
                Else
                    state = Armen.Armen2 ' Don't walk off the form -- turn around!
                    PictureBox1.Image = My.Resources.Resources.effect_001 ' Switch to complementary image
                End If

        End Select

    End Sub


    Private Sub Punch_1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Form1.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class