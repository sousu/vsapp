<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnShareOption = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.rtbDisplay = New System.Windows.Forms.RichTextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShareOption
        '
        Me.btnShareOption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShareOption.Image = CType(resources.GetObject("btnShareOption.Image"), System.Drawing.Image)
        Me.btnShareOption.Location = New System.Drawing.Point(638, 12)
        Me.btnShareOption.Name = "btnShareOption"
        Me.btnShareOption.Size = New System.Drawing.Size(34, 27)
        Me.btnShareOption.TabIndex = 1
        Me.btnShareOption.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnShareOption)
        Me.SplitContainer1.Panel1MinSize = 100
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.rtbDisplay)
        Me.SplitContainer1.Panel2MinSize = 200
        Me.SplitContainer1.Size = New System.Drawing.Size(684, 523)
        Me.SplitContainer1.SplitterDistance = 100
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 1
        '
        'rtbDisplay
        '
        Me.rtbDisplay.BackColor = System.Drawing.SystemColors.Window
        Me.rtbDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDisplay.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rtbDisplay.Location = New System.Drawing.Point(0, 0)
        Me.rtbDisplay.Margin = New System.Windows.Forms.Padding(0)
        Me.rtbDisplay.Name = "rtbDisplay"
        Me.rtbDisplay.Size = New System.Drawing.Size(684, 420)
        Me.rtbDisplay.TabIndex = 1
        Me.rtbDisplay.Text = ""
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 523)
        Me.Controls.Add(Me.SplitContainer1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.vsapp.My.MySettings.Default, "myLoc", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.vsapp.My.MySettings.Default.myLoc
        Me.MinimumSize = New System.Drawing.Size(700, 550)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShareOption As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents rtbDisplay As RichTextBox
End Class
