Public Class Main
    Private ap

    '起動処理
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '終了イベントハンドラの設定
        AddHandler Application.ApplicationExit, AddressOf applicationExit
        '共有設定ファイル読込
        ShareOptionXML.LoadFromXmlFile()
        'サイズ復元
        Size = My.Settings.mySize
        'フォント調整
        rtbDisplay.LanguageOption = RichTextBoxLanguageOptions.UIFonts
        'アプリ初期化
        ap = New Ap(Me, ShareOptionXML.Instance.interval)
        'メイン処理
        start()
    End Sub
    '終了処理
    Private Sub applicationExit(ByVal sender As Object, ByVal e As EventArgs)
        '設定を保存する
        ShareOptionXML.SaveToXmlFile()
        My.Settings.mySize = Size
        If ap.isWorking Then ap.abort()
    End Sub

    'メイン処理スタート 
    Public Sub start()
        ap.start()
    End Sub

    'バックスレッドからの呼び出し
    Public Sub delegatedSetTxt(s As String)
        Console.WriteLine(s)
        rtbDisplay.Text = s
    End Sub

    '共有設定呼出 
    Private Sub btnShareOptionClick(sender As Object, e As EventArgs) Handles btnShareOption.Click
        Dim so As New ShareOption()
        so.ShowDialog(Me)
        so.Dispose()
    End Sub

End Class