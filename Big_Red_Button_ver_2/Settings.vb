Public Class Settings

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.TopMost = False
        Form1.Hide()
        TextBox1.Text = My.Settings.Bomb_movie
        TextBox2.Text = My.Settings.Counter_movie
        TextBox3.Text = My.Settings.TImer_break
        TextBox4.Text = My.Settings.Timer_Alarm
        TextBox5.Text = My.Settings.website_Rightclick
        TextBox6.Text = My.Settings.Website_leftclick
        TextBox7.Text = My.Settings.Website
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.Bomb_movie = TextBox1.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Settings.Counter_movie = TextBox2.Text
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Settings.TImer_break = TextBox3.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Settings.Timer_Alarm = TextBox4.Text
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        My.Settings.website_Rightclick = TextBox5.Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        My.Settings.Website_leftclick = TextBox6.Text
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        My.Settings.Website = TextBox7.Text
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form1.Show()
        Form1.TopMost = True
        Me.Close()

    End Sub
End Class