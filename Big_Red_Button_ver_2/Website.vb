Option Explicit On
Public Class Website
    'Delay module
    Private Declare Sub Sleep Lib "kernel32" (ByVal d As Long)
    'Mouse Dectector class for outside Form1
    Private WithEvents MouseDetector As MouseDetector

    Private Sub Website_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()
        End If
    End Sub

    Private Sub Website_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Settings.Hide_hud = "1" Then
            TextBox3.Visible = True
            Label5.Visible = True
            Label4.Visible = True
            Label1.Visible = True

            Label2.Visible = True
   
            Target.Visible = True
   
            LabelRight.Visible = True
    
            TextBox1.Visible = True
    
            Label6.Visible = True
      
            LabelLeft1.Visible = True
    
            TextBox2.Visible = True
    
            Button3.Visible = True
      
            Target.Visible = True
       
        End If
        If My.Settings.Hide_hud = "0" Then
            TextBox3.Visible = False
            Label5.Visible = False
            Label1.Visible = False
            Label4.Visible = False

            Label2.Visible = False

            Target.Visible = False

            LabelRight.Visible = False

            TextBox1.Visible = False

            Label6.Visible = False

            LabelLeft1.Visible = False

            TextBox2.Visible = False

            Button3.Visible = False

            Target.Visible = True
        End If
        TextBox1.Text = Label3.Text
        Target.Text = My.Settings.target
        'TextBox2.Text = My.Settings.target
        'My.Settings.website_Rightclick = TextBox2.Text
        'Load class mousedetector
        MouseDetector = New MouseDetector
        'change text labels temp
        LabelLeft1.Text = "No Clicks"
        LabelRight.Text = "No Clicks"
        If Target.Text = "0" Then
            Label3.Visible = True
            Target.Visible = False

        End If
    End Sub
    'load mousedetector outside form
    Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        RemoveHandler MouseDetector.MouseLeftButtonClick, AddressOf MouseDetector_MouseLeftButtonClick
        RemoveHandler MouseDetector.MouseRightButtonClick, AddressOf MouseDetector_MouseRightButtonClick
        MouseDetector.Dispose()
    End Sub
    Private Sub MouseDetector_MouseLeftButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MouseDetector.MouseLeftButtonClick

        'Delay(2)
        'counter temp
        If IsNumeric(LabelLeft1.Text) Then
            LabelLeft1.Text = CInt(LabelLeft1.Text) + 1
        Else
            LabelLeft1.Text = 1
        End If
        'var mouse function left
        If My.Settings.leftmouseon = 1 Then
            '   WebBrowser1.Navigate(My.Settings.Website_leftclick)
            '  ElseIf My.Settings.leftmouseon = 0 Then

        End If
        Text.Text = TextBox3.Text

    End Sub
    Private Sub MouseDetector_MouseRightButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MouseDetector.MouseRightButtonClick
        If IsNumeric(LabelRight.Text) Then
            LabelRight.Text = CInt(LabelRight.Text) + 1
        Else
            LabelRight.Text = 1
        End If
        Target.Text = (My.Settings.target) - 1
        My.Settings.target = Target.Text
        If Target.Text = "0" Then
            Label3.Text = TextBox1.Text
            Label3.Visible = True
            Target.Visible = False

        End If

  
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '   WebBrowser3.Navigate(TextBox3.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '   WebBrowser1.Navigate(TextBox1.Text)
        '    My.Settings.Website = TextBox1.Text
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        If TextBox3.Visible = False Then
            TextBox3.Visible = True

        ElseIf TextBox3.Visible = True Then
            TextBox3.Visible = False

        End If
        If Label5.Visible = False Then
            Label5.Visible = True

        ElseIf Label5.Visible = True Then
            Label5.Visible = False

        End If
        If Label4.Visible = False Then
            Label4.Visible = True

        ElseIf Label4.Visible = True Then
            Label4.Visible = False

        End If

        If Label1.Visible = False Then
            Label1.Visible = True
            My.Settings.Hide_hud = "1"
        ElseIf Label1.Visible = True Then
            Label1.Visible = False
            My.Settings.Hide_hud = "0"
        End If

        If Label2.Visible = False Then
            Label2.Visible = True
        ElseIf Label2.Visible = True Then
            Label2.Visible = False
        End If

        If Target.Visible = False Then
            Target.Visible = True
        ElseIf Target.Visible = True Then
            Target.Visible = False
        End If


        If LabelRight.Visible = False Then
            LabelRight.Visible = True
        ElseIf LabelRight.Visible = True Then
            LabelRight.Visible = False
        End If

        If TextBox1.Visible = False Then
            TextBox1.Visible = True
        ElseIf TextBox1.Visible = True Then
            TextBox1.Visible = False
        End If
        If Label6.Visible = False Then
            Label6.Visible = True
        ElseIf Label6.Visible = True Then
            Label6.Visible = False
        End If


        If LabelLeft1.Visible = False Then
            LabelLeft1.Visible = True
        ElseIf LabelLeft1.Visible = True Then
            LabelLeft1.Visible = False
        End If

        If TextBox2.Visible = False Then
            TextBox2.Visible = True
        ElseIf TextBox2.Visible = True Then
            TextBox2.Visible = False
        End If



        If Button3.Visible = False Then
            Button3.Visible = True
        ElseIf Button3.Visible = True Then
            Button3.Visible = False
        End If
        If Target.Visible = False Then
            Target.Visible = True
        ElseIf Target.Visible = True Then
            Target.Visible = True
        End If
    End Sub

    Private Sub Website_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Form1.Visible = True
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Settings.target = TextBox2.Text
        Label3.Text = TextBox1.Text
        Target.Text = My.Settings.target
        Label3.Visible = False
        Target.Visible = True
        Text.Text = TextBox3.Text
    End Sub

  
    
    Private Sub Target_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Target.Click

    End Sub
End Class