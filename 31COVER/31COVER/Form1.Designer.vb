<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox_TEN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_OTHER = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_START = New System.Windows.Forms.TextBox()
        Me.Button_COVER = New System.Windows.Forms.Button()
        Me.TextBox_VALUE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_RUN = New System.Windows.Forms.Button()
        Me.ListBox_ID = New System.Windows.Forms.ListBox()
        Me.startCount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.endCount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox_TEN
        '
        Me.TextBox_TEN.Location = New System.Drawing.Point(90, 26)
        Me.TextBox_TEN.Name = "TextBox_TEN"
        Me.TextBox_TEN.Size = New System.Drawing.Size(258, 21)
        Me.TextBox_TEN.TabIndex = 0
        Me.TextBox_TEN.Text = "985"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "十进制"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "其他进制"
        '
        'TextBox_OTHER
        '
        Me.TextBox_OTHER.Location = New System.Drawing.Point(90, 57)
        Me.TextBox_OTHER.Name = "TextBox_OTHER"
        Me.TextBox_OTHER.Size = New System.Drawing.Size(258, 21)
        Me.TextBox_OTHER.TabIndex = 2
        Me.TextBox_OTHER.Text = "123456789ABCDEFGHJKLMNPRSTUWXYZ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "启始值"
        '
        'TextBox_START
        '
        Me.TextBox_START.Location = New System.Drawing.Point(90, 91)
        Me.TextBox_START.Name = "TextBox_START"
        Me.TextBox_START.Size = New System.Drawing.Size(258, 21)
        Me.TextBox_START.TabIndex = 4
        Me.TextBox_START.Text = "111"
        '
        'Button_COVER
        '
        Me.Button_COVER.Location = New System.Drawing.Point(273, 122)
        Me.Button_COVER.Name = "Button_COVER"
        Me.Button_COVER.Size = New System.Drawing.Size(75, 23)
        Me.Button_COVER.TabIndex = 6
        Me.Button_COVER.Text = "转换"
        Me.Button_COVER.UseVisualStyleBackColor = True
        '
        'TextBox_VALUE
        '
        Me.TextBox_VALUE.Location = New System.Drawing.Point(90, 161)
        Me.TextBox_VALUE.Name = "TextBox_VALUE"
        Me.TextBox_VALUE.Size = New System.Drawing.Size(258, 21)
        Me.TextBox_VALUE.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "转换值"
        '
        'Button_RUN
        '
        Me.Button_RUN.Location = New System.Drawing.Point(609, 24)
        Me.Button_RUN.Name = "Button_RUN"
        Me.Button_RUN.Size = New System.Drawing.Size(82, 23)
        Me.Button_RUN.TabIndex = 9
        Me.Button_RUN.Text = "RunAll"
        Me.Button_RUN.UseVisualStyleBackColor = True
        '
        'ListBox_ID
        '
        Me.ListBox_ID.FormattingEnabled = True
        Me.ListBox_ID.ItemHeight = 12
        Me.ListBox_ID.Location = New System.Drawing.Point(355, 60)
        Me.ListBox_ID.Name = "ListBox_ID"
        Me.ListBox_ID.Size = New System.Drawing.Size(336, 148)
        Me.ListBox_ID.TabIndex = 10
        '
        'startCount
        '
        Me.startCount.Location = New System.Drawing.Point(393, 26)
        Me.startCount.Name = "startCount"
        Me.startCount.Size = New System.Drawing.Size(80, 21)
        Me.startCount.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "开始"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(484, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "结束"
        '
        'endCount
        '
        Me.endCount.Location = New System.Drawing.Point(523, 26)
        Me.endCount.Name = "endCount"
        Me.endCount.Size = New System.Drawing.Size(80, 21)
        Me.endCount.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 217)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.endCount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.startCount)
        Me.Controls.Add(Me.ListBox_ID)
        Me.Controls.Add(Me.Button_RUN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_VALUE)
        Me.Controls.Add(Me.Button_COVER)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_START)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_OTHER)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_TEN)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_TEN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_OTHER As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_START As System.Windows.Forms.TextBox
    Friend WithEvents Button_COVER As System.Windows.Forms.Button
    Friend WithEvents TextBox_VALUE As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button_RUN As System.Windows.Forms.Button
    Friend WithEvents ListBox_ID As System.Windows.Forms.ListBox
    Friend WithEvents startCount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents endCount As System.Windows.Forms.TextBox

End Class
