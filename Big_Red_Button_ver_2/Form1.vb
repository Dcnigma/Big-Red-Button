'##################################################################
'###################TODO BEFORE CODE WORKS#########################
'##################################################################
'
'##################################################################
'Delay Function
'##################################################################
'Create Module
'Copy this code in it
'Module Wait_Function
'Sub Delay(ByVal dblSecs As Double)
'
'Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
'Dim dblWaitTil As Date
'Now.AddSeconds(OneSec)
'dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
'Do Until Now > dblWaitTil
'Application.DoEvents() ' Allow windows messages to be processed
'Loop

'    End Sub
'End Module
'##################################################################
'##################################################################
'###########################Settings###############################
'##################################################################
'##################################################################
'Rember to turn of Visual Studio Hosting process for it to work while running in Visual Studio.
'to go to Project / Properties / Debug and uncheck Enable the Visual Studio Hosting process 
'##################################################################
Option Explicit On

Public Class Form1
    'Delay module
    Private Declare Sub Sleep Lib "kernel32" (ByVal d As Long)
    'Mouse Dectector class for outside Form1
    Private WithEvents MouseDetector As MouseDetector
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        'counter temp
        If IsNumeric(LabelLeft.Text) Then
            LabelLeft.Text = CInt(LabelLeft.Text) + 1
        Else
            LabelLeft.Text = 1
        End If
        '**********Easter Egg*********************
        If LabelLeft.Text = 5 Then
            PictureBox1.Visible = True
            PictureBox1.Image = My.Resources.photo
        End If
        If LabelLeft.Text = 6 Then
            PictureBox1.Visible = False
        End If
        If LabelLeft.Text = 40 Then
            PictureBox1.Visible = True
            PictureBox1.Image = My.Resources.photo
        End If
        If LabelLeft.Text = 41 Then
            PictureBox1.Visible = False
        End If
        '**********Easter Egg*********************
        If LabelLeft.Text = 10 Then
            PictureBox2.Image = My.Resources.Comic_pow
            PictureBox2.Visible = True
        End If
        If LabelLeft.Text = 11 Then
            PictureBox2.Visible = False
        End If
        If LabelLeft.Text = 15 Then
            PictureBox2.Image = My.Resources.pow1
            PictureBox2.Visible = True
        End If
        If LabelLeft.Text = 16 Then
            PictureBox2.Visible = False
        End If
        If LabelLeft.Text = 20 Then
            PictureBox2.Image = My.Resources.bam3
            PictureBox2.Visible = True
        End If
        If LabelLeft.Text = 21 Then
            PictureBox2.Visible = False
        End If
        If LabelLeft.Text = 25 Then
            PictureBox2.Image = My.Resources._591img_20
            PictureBox2.Visible = True
        End If
        If LabelLeft.Text = 26 Then
            PictureBox2.Visible = False
        End If
        If LabelLeft.Text = 30 Then
            PictureBox2.Image = My.Resources.bam_retro_tattoo_1
            PictureBox2.Visible = True
        End If
        If LabelLeft.Text = 31 Then
            PictureBox2.Visible = False
        End If
        If LabelLeft.Text = 34 Then
            PictureBox2.Image = My.Resources.pow1
            PictureBox2.Visible = True
        End If
        If LabelLeft.Text = 35 Then
            PictureBox2.Visible = False
        End If
        '**********Easter Egg*********************
        If LabelLeft.Text = 50 Then
            LabelLeft.Text = 0
        End If
    End Sub
    Private Sub MouseDetector_MouseRightButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MouseDetector.MouseRightButtonClick
        'load counterwebsite
        'WebBrowser1.Navigate("http://tpmaa.engbersen.org/telenet/counter.php")
        'Give Delay for 2 Seconds
        'Delay(2)
        'load website (counter got a autoclose script)
        'WebBrowser1.Navigate("http://tpmaa.engbersen.org/telenet/togo.php")
        'counter temp
        If IsNumeric(LabelRight.Text) Then
            LabelRight.Text = CInt(LabelRight.Text) + 1
        Else
            LabelRight.Text = 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    
            Boom1.Show()
  
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Boom1.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Punch_1.Show()

        Punch_1.TopMost = True
        Me.TopMost = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Website.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Credits.show()
    End Sub

    Private Sub LabelLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelLeft.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Working.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Settings.Show()
        Settings.TopMost = True
        Me.Hide()
        Me.TopMost = False
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        game1.Show()
    End Sub
End Class
