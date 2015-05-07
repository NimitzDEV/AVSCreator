Public Class frmMain
    Dim require As String
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " - " & Application.ProductVersion
    End Sub

    Private Sub fileSelect(ByRef tb As TextBox, ByVal filter As String)
        ofd.Filter = filter
        ofd.ShowDialog()
        If Dir(ofd.FileName) = "" Then Exit Sub
        tb.Text = ofd.FileName
    End Sub

    Private Sub btnPlugin_Click(sender As Object, e As EventArgs) Handles btnPlugin.Click
        fileSelect(tbPlugin, "OCX控件|*.ocx|DLL文件|*.dll")
    End Sub

    Private Sub btnVideo_Click(sender As Object, e As EventArgs) Handles btnVideo.Click
        fileSelect(tbVideo, "视频文件|*.*")
    End Sub

    Private Sub btnASS_Click(sender As Object, e As EventArgs) Handles btnASS.Click
        fileSelect(tbASS, "ASS字幕|*.ass")
    End Sub

    Private Sub tbVideo_TextChanged(sender As Object, e As EventArgs) Handles tbVideo.TextChanged
        If Dir(tbVideo.Text) = "" Then Exit Sub
        tbASS.Text = System.IO.Path.GetDirectoryName(tbVideo.Text) & "\" & System.IO.Path.GetFileNameWithoutExtension(tbVideo.Text) & ".ass"
        If Dir(tbASS.Text) = "" Then tbASS.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        require = "LoadPlugin(""" & tbPlugin.Text & """)" & vbCrLf & _
            "DirectShowSource(""" & tbVideo.Text & """)" & vbCrLf & _
            "TextSub(""" & tbASS.Text & """)"
        System.IO.File.WriteAllText(System.IO.Path.GetDirectoryName(tbVideo.Text) & "\[N&V字幕组] " & System.IO.Path.GetFileNameWithoutExtension(tbVideo.Text) & ".avs", require, System.Text.Encoding.Default)
    End Sub

    Private Sub tbPlugin_TextChanged(sender As Object, e As EventArgs) Handles tbPlugin.TextChanged

    End Sub
End Class
