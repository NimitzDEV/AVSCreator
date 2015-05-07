<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPlugin = New System.Windows.Forms.TextBox()
        Me.tbVideo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbASS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPlugin = New System.Windows.Forms.Button()
        Me.btnVideo = New System.Windows.Forms.Button()
        Me.btnASS = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AVSPlugin"
        '
        'tbPlugin
        '
        Me.tbPlugin.Location = New System.Drawing.Point(14, 24)
        Me.tbPlugin.Name = "tbPlugin"
        Me.tbPlugin.Size = New System.Drawing.Size(336, 21)
        Me.tbPlugin.TabIndex = 1
        Me.tbPlugin.Text = "C:\Program Files\AviSynth 2.5\plugins\VSFilter.dll"
        '
        'tbVideo
        '
        Me.tbVideo.Location = New System.Drawing.Point(14, 75)
        Me.tbVideo.Name = "tbVideo"
        Me.tbVideo.Size = New System.Drawing.Size(336, 21)
        Me.tbVideo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Video"
        '
        'tbASS
        '
        Me.tbASS.Location = New System.Drawing.Point(14, 129)
        Me.tbASS.Name = "tbASS"
        Me.tbASS.Size = New System.Drawing.Size(336, 21)
        Me.tbASS.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ASS"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(14, 167)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(336, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "保存"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPlugin
        '
        Me.btnPlugin.Location = New System.Drawing.Point(356, 24)
        Me.btnPlugin.Name = "btnPlugin"
        Me.btnPlugin.Size = New System.Drawing.Size(42, 23)
        Me.btnPlugin.TabIndex = 7
        Me.btnPlugin.Text = "选择"
        Me.btnPlugin.UseVisualStyleBackColor = True
        '
        'btnVideo
        '
        Me.btnVideo.Location = New System.Drawing.Point(356, 73)
        Me.btnVideo.Name = "btnVideo"
        Me.btnVideo.Size = New System.Drawing.Size(42, 23)
        Me.btnVideo.TabIndex = 8
        Me.btnVideo.Text = "选择"
        Me.btnVideo.UseVisualStyleBackColor = True
        '
        'btnASS
        '
        Me.btnASS.Location = New System.Drawing.Point(356, 127)
        Me.btnASS.Name = "btnASS"
        Me.btnASS.Size = New System.Drawing.Size(42, 23)
        Me.btnASS.TabIndex = 9
        Me.btnASS.Text = "选择"
        Me.btnASS.UseVisualStyleBackColor = True
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 208)
        Me.Controls.Add(Me.btnASS)
        Me.Controls.Add(Me.btnVideo)
        Me.Controls.Add(Me.btnPlugin)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbASS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbVideo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbPlugin)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbPlugin As System.Windows.Forms.TextBox
    Friend WithEvents tbVideo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbASS As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPlugin As System.Windows.Forms.Button
    Friend WithEvents btnVideo As System.Windows.Forms.Button
    Friend WithEvents btnASS As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog

End Class
