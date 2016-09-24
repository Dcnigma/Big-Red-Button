<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alarm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alarm))
        Me.Min_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Ani_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelLeft = New System.Windows.Forms.Label()
        Me.LabelRight = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BreakorWork = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Min_Timer
        '
        Me.Min_Timer.Interval = 60000
        '
        'Ani_Timer
        '
        Me.Ani_Timer.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Animation Label"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Break Time"
        Me.Label2.Visible = False
        '
        'LabelLeft
        '
        Me.LabelLeft.AutoSize = True
        Me.LabelLeft.Location = New System.Drawing.Point(7, 52)
        Me.LabelLeft.Name = "LabelLeft"
        Me.LabelLeft.Size = New System.Drawing.Size(55, 13)
        Me.LabelLeft.TabIndex = 2
        Me.LabelLeft.Text = "mouse left"
        Me.LabelLeft.Visible = False
        '
        'LabelRight
        '
        Me.LabelRight.AutoSize = True
        Me.LabelRight.Location = New System.Drawing.Point(59, 52)
        Me.LabelRight.Name = "LabelRight"
        Me.LabelRight.Size = New System.Drawing.Size(61, 13)
        Me.LabelRight.TabIndex = 3
        Me.LabelRight.Text = "mouse right"
        Me.LabelRight.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, -6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 20)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Stop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Couter Min"
        Me.Label3.Visible = False
        '
        'BreakorWork
        '
        Me.BreakorWork.AutoSize = True
        Me.BreakorWork.Location = New System.Drawing.Point(7, 116)
        Me.BreakorWork.Name = "BreakorWork"
        Me.BreakorWork.Size = New System.Drawing.Size(70, 13)
        Me.BreakorWork.TabIndex = 6
        Me.BreakorWork.Text = "BreakorWork"
        Me.BreakorWork.Visible = False
        '
        'Alarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.Big_Red_Button_ver_3.My.Resources.Resources.foot_print_action_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BreakorWork)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelRight)
        Me.Controls.Add(Me.LabelLeft)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Alarm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Min_Timer As System.Windows.Forms.Timer
    Friend WithEvents Ani_Timer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelLeft As System.Windows.Forms.Label
    Friend WithEvents LabelRight As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BreakorWork As System.Windows.Forms.Label
End Class
