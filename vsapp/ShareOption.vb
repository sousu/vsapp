Public Class ShareOption
    Public Sub New()
        InitializeComponent()
        tbInterval.Text = ShareOptionXML.Instance.interval
    End Sub

    'Private Sub bt_path_Click(sender As Object, e As EventArgs) Handles bt_cpdlc_path.Click
    '    setPath(tb_path)
    'End Sub
    'Private Sub setPath(ByRef tb As RichTextBox)
    '    Dim ofd As New OpenFileDialog()
    '    ofd.Filter = "実行ファイル(*.exe)|*.exe"
    '    ofd.Title = "実行ファイルを選択してください"
    '    If ofd.ShowDialog() = DialogResult.OK Then
    '        tb.Text = ofd.FileName
    '    End If
    'End Sub

    ' 終了保存処理
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ShareOptionXML.Instance.interval = tbInterval.Text
        Close()
    End Sub
    Private Sub btnChancel_Click(sender As Object, e As EventArgs) Handles btnChancel.Click
        Close()
    End Sub

End Class

