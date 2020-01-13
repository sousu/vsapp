<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShareOption
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnChancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbInterval = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(244, 196)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(52, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnChancel
        '
        Me.btnChancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChancel.Location = New System.Drawing.Point(302, 196)
        Me.btnChancel.Name = "btnChancel"
        Me.btnChancel.Size = New System.Drawing.Size(52, 23)
        Me.btnChancel.TabIndex = 1
        Me.btnChancel.Text = "Cancel"
        Me.btnChancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "取得インターバル(ms)"
        '
        'tbInterval
        '
        Me.tbInterval.Location = New System.Drawing.Point(126, 14)
        Me.tbInterval.Name = "tbInterval"
        Me.tbInterval.Size = New System.Drawing.Size(89, 19)
        Me.tbInterval.TabIndex = 3
        '
        'ShareOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 231)
        Me.Controls.Add(Me.tbInterval)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ShareOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "共有設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents btnChancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbInterval As TextBox
End Class
