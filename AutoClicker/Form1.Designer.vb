<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStartHotkey = New System.Windows.Forms.TextBox()
        Me.tmrStartStopKeyFinder = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStopHotkey = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCps = New System.Windows.Forms.TextBox()
        Me.clicker = New System.Windows.Forms.Timer(Me.components)
        Me.lblTotalTime = New System.Windows.Forms.Label()
        Me.timeCounter = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "START hotkey"
        '
        'txtStartHotkey
        '
        Me.txtStartHotkey.Location = New System.Drawing.Point(109, 6)
        Me.txtStartHotkey.Name = "txtStartHotkey"
        Me.txtStartHotkey.Size = New System.Drawing.Size(146, 22)
        Me.txtStartHotkey.TabIndex = 1
        '
        'tmrStartStopKeyFinder
        '
        Me.tmrStartStopKeyFinder.Interval = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "STOP hotkey"
        '
        'txtStopHotkey
        '
        Me.txtStopHotkey.Location = New System.Drawing.Point(109, 50)
        Me.txtStopHotkey.Name = "txtStopHotkey"
        Me.txtStopHotkey.Size = New System.Drawing.Size(146, 22)
        Me.txtStopHotkey.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCps)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 136)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Click Configuration"
        '
        'lblTest
        '
        Me.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTest.Location = New System.Drawing.Point(15, 229)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(98, 18)
        Me.lblTest.TabIndex = 5
        Me.lblTest.Text = "Test me: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "per sec"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Custom Clicks"
        '
        'txtCps
        '
        Me.txtCps.Location = New System.Drawing.Point(22, 46)
        Me.txtCps.MaxLength = 3
        Me.txtCps.Name = "txtCps"
        Me.txtCps.Size = New System.Drawing.Size(100, 22)
        Me.txtCps.TabIndex = 0
        Me.txtCps.Text = "25"
        Me.txtCps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clicker
        '
        Me.clicker.Interval = 500
        '
        'lblTotalTime
        '
        Me.lblTotalTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalTime.Location = New System.Drawing.Point(126, 229)
        Me.lblTotalTime.Name = "lblTotalTime"
        Me.lblTotalTime.Size = New System.Drawing.Size(129, 18)
        Me.lblTotalTime.TabIndex = 6
        Me.lblTotalTime.Text = "Time: 0"
        '
        'timeCounter
        '
        Me.timeCounter.Interval = 1000
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 250)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(70, 16)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Reset Test"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(181, 250)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(74, 16)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Reset Time"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(267, 275)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblTotalTime)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtStopHotkey)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStartHotkey)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "AutoClicker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStartHotkey As System.Windows.Forms.TextBox
    Friend WithEvents tmrStartStopKeyFinder As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStopHotkey As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCps As System.Windows.Forms.TextBox
    Friend WithEvents clicker As System.Windows.Forms.Timer
    Friend WithEvents lblTest As System.Windows.Forms.Label
    Friend WithEvents lblTotalTime As System.Windows.Forms.Label
    Friend WithEvents timeCounter As System.Windows.Forms.Timer
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel

End Class
