'--- ---
'Notepadを独立スレッドで定期的に監視
'--- ---

Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class Ap
    Private main As Main
    Private bw As BackWorker
    Private pname
    Private proc As Process
    Private handle As Integer
    Private interval As Integer

    'Windowsのアプリを扱う関数群
    Private Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Private Declare Function GetClassName Lib "user32.dll" Alias "GetClassNameA" (ByVal hWnd As Integer, ByVal lpClassName As String, ByVal nMaxCount As Integer) As Integer
    Private Declare Function FindWindowEx Lib "user32.dll" Alias "FindWindowExA" (ByVal hwndParent As Integer, ByVal hwndChildAfter As Integer, ByVal lpszClass As String, ByVal lpszWindow As String) As Integer
    Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Declare Function SendMessageStr Lib "user32.dll" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal MSG As Integer, ByVal wParam As Integer, ByVal lParam As StringBuilder) As Integer
    Private Declare Function SetWindowPos Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal hWndInertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As Integer) As Integer

    Private Const WM_GETTEXT = &HD
    Private Const WM_GETTEXTLENGTH = &HE

    Public Const LB_GETCOUNT = &H18B
    Public Const LB_GETTEXTLEN = &H18A
    Public Const LB_GETTEXT = &H189

    Public Sub New(ByRef m As Main, i As Integer)
        main = m
        interval = i
        bw = New BackWorker(Me)
        pname = "notepad"
        proc = Nothing
        handle = 0
    End Sub

    Public Sub start()
        If Not findProcess() Then
            MessageBox.Show("アプリの起動を確認出来ません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If Not findHandle() Then
            MessageBox.Show("ハンドルを確認出来ません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        bw.start() 'スレッド起動
    End Sub

    Public Function findProcess() As Boolean
        Dim procs As Process()
        procs = Process.GetProcessesByName(getExename(pname))
        If procs.Length = 0 Then
            Return False
        End If
        Do '生成中の場合待機
            Thread.Sleep(50)
        Loop While procs(0).MainWindowHandle = 0
        proc = procs(0)
        Console.WriteLine("proc: " + proc.ToString)
        Return True
    End Function
    Private Function getExename(s As String)
        Dim r As New Regex("^.*?([^\\]+)\.exe$")
        Return r.Replace(s, "$1")
    End Function
    Public Function findHandle() As Boolean
        handle = FindWindowEx(proc.MainWindowHandle, 0, "Edit", "") 'Notpadの編集域
        Console.WriteLine("handle: " + handle.ToString)
        Return If(handle = 0, False, True)
    End Function
    '事例: クラス名／Window名で一意にしながらTraceが表示されるListのハンドルを取得
    'res = GetClassName(proc.MainWindowHandle, appcname, 255)
    'h1 = FindWindowEx(h1, 0, appcname, "")
    'h2 = FindWindowEx(h1, 0, appcname, "")
    'h2 = FindWindowEx(h1, h2, appcname, "") '同階層window2個目
    'h2 = FindWindowEx(h2, 0, getListBoxClassName(appcname), "") '目的トレースリストボックス
    'handle = h2
    'Private Function getListBoxClassName(name As String)
    'Dim r As New Regex("^.*(app\..+)$")
    'Dim rev = r.Replace(name, "$1")
    'Return "WindowsForms10.LISTBOX." + rev
    'End Function

    'メインへの委譲関数
    Public Delegate Sub setTxt(s As String)
    'バックスレッド実行
    Public Sub work()
        Try
            Do
                Console.WriteLine("--- loop ---")
                Thread.Sleep(interval)
                proc.WaitForInputIdle()
                getTxt()
            Loop
        Catch e As Exception
            Console.WriteLine("exception: " + e.Message)
            abort()
        End Try
    End Sub

    Private Sub getTxt()
        Dim l = SendMessage(handle, WM_GETTEXTLENGTH, 0, 0)
        Dim s = New StringBuilder("", l)
        Dim r = SendMessageStr(handle, WM_GETTEXT, l, s)
        main.Invoke(New setTxt(AddressOf main.delegatedSetTxt), New Object() {s.ToString})
    End Sub

    'バックスレッド停止
    Public Sub abort()
        proc = Nothing
        handle = 0
        bw.abort()
    End Sub

    'バックスレッド確認
    Public Function isWorking()
        Return bw.isWorking
    End Function

End Class
