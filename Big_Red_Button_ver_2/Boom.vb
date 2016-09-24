
Public Class Boom1

    'Delay module
    Private Declare Sub Sleep Lib "kernel32" (ByVal d As Long)
    'Mouse Dectector class for outside Form1
    Private WithEvents MouseDetector As MouseDetector
      
    Private Sub Boom1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        WebBrowser1.Visible = True
        If e.KeyCode = 27 Then
            Label1.Text = ("escape")

            Form1.Show()
            Me.Close()
        End If
    End Sub
    Private Sub WebBrowser1_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles WebBrowser1.PreviewKeyDown
        WebBrowser1.Visible = True
        If e.KeyCode = Keys.Escape Then
            Label1.Text = ("escape")
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        WebBrowser1.Visible = vbFalse
        Cursor.Position = New Point(11, 11)
        Form1.Hide()
        Me.TopMost = False
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
        'load Counter video
        Cursor.Position = New Point(11, 11)
        Form1.Hide()
        Me.TopMost = True
        WebBrowser1.Visible = True
        Delay(1)
        WebBrowser1.Navigate(My.Settings.Counter_movie)
        'counter temp
        If IsNumeric(LabelLeft.Text) Then
            LabelLeft.Text = CInt(LabelLeft.Text) + 1
        Else
            LabelLeft.Text = 1
        End If
        Delay(10)
        WebBrowser1.Navigate("")
        WebBrowser1.Visible = vbFalse
        MyBase.WindowState = ("Maximized")
        Me.TopMost = vbFalse
        Me.Activate()
        Label1.Select()
        Delay(0.1)
        Me.BringToFront()
    End Sub
    Private Sub MouseDetector_MouseRightButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MouseDetector.MouseRightButtonClick
        'var mouse function left
        'load BoomVideo
        Cursor.Position = New Point(11, 11)
        Form1.Hide()
        Me.TopMost = True
        WebBrowser1.Visible = True
        Delay(1)
        WebBrowser1.Navigate(My.Settings.Bomb_movie)
        'counter temp
        If IsNumeric(LabelRight.Text) Then
            LabelRight.Text = CInt(LabelRight.Text) + 1
        Else
            LabelRight.Text = 1
        End If
        Delay(10)
        WebBrowser1.Navigate("")
        WebBrowser1.Visible = vbFalse
        Me.WindowState = ("Maximized")
        Me.TopMost = vbFalse
        Me.Activate()
        Label1.Select()
        Label1.Focus()
        Delay(0.1)
        Me.BringToFront()
    End Sub

 

    Private Sub WebBrowser1_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WebBrowser1.VisibleChanged
        If Label1.Text = ("escape") Then
            Form1.Show()
            Me.Close()
        End If
    End Sub


    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class