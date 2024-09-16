<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBoxOriginal = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDifferent = New System.Windows.Forms.PictureBox()
        Me.ButtonCalcStart = New System.Windows.Forms.Button()
        Me.LabelCopyWrite = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBoxOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDifferent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxOriginal
        '
        Me.PictureBoxOriginal.Image = Global.MapEditor.My.Resources.Resources.地図
        Me.PictureBoxOriginal.Location = New System.Drawing.Point(11, 13)
        Me.PictureBoxOriginal.Name = "PictureBoxOriginal"
        Me.PictureBoxOriginal.Size = New System.Drawing.Size(260, 260)
        Me.PictureBoxOriginal.TabIndex = 0
        Me.PictureBoxOriginal.TabStop = False
        '
        'PictureBoxDifferent
        '
        Me.PictureBoxDifferent.Location = New System.Drawing.Point(277, 13)
        Me.PictureBoxDifferent.Name = "PictureBoxDifferent"
        Me.PictureBoxDifferent.Size = New System.Drawing.Size(240, 260)
        Me.PictureBoxDifferent.TabIndex = 1
        Me.PictureBoxDifferent.TabStop = False
        '
        'ButtonCalcStart
        '
        Me.ButtonCalcStart.Location = New System.Drawing.Point(717, 18)
        Me.ButtonCalcStart.Name = "ButtonCalcStart"
        Me.ButtonCalcStart.Size = New System.Drawing.Size(73, 23)
        Me.ButtonCalcStart.TabIndex = 2
        Me.ButtonCalcStart.Text = "CalcStart"
        Me.ButtonCalcStart.UseVisualStyleBackColor = True
        '
        'LabelCopyWrite
        '
        Me.LabelCopyWrite.AutoSize = True
        Me.LabelCopyWrite.Location = New System.Drawing.Point(606, 429)
        Me.LabelCopyWrite.Name = "LabelCopyWrite"
        Me.LabelCopyWrite.Size = New System.Drawing.Size(184, 12)
        Me.LabelCopyWrite.TabIndex = 3
        Me.LabelCopyWrite.Text = "MapEditor Kyosuke Miyazawa 2024"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(522, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(186, 260)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.WordWrap = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.LabelCopyWrite)
        Me.Controls.Add(Me.ButtonCalcStart)
        Me.Controls.Add(Me.PictureBoxDifferent)
        Me.Controls.Add(Me.PictureBoxOriginal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBoxOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDifferent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxOriginal As PictureBox
    Friend WithEvents PictureBoxDifferent As PictureBox
    Friend WithEvents ButtonCalcStart As Button
    Friend WithEvents LabelCopyWrite As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
