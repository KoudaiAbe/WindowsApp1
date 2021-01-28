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
        Me.btn = New System.Windows.Forms.Button()
        Me.coler = New System.Windows.Forms.Button()
        Me.txtValue1 = New System.Windows.Forms.TextBox()
        Me.calc_plus = New System.Windows.Forms.Button()
        Me.txtValue2 = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn
        '
        Me.btn.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn.Location = New System.Drawing.Point(39, 43)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(192, 105)
        Me.btn.TabIndex = 0
        Me.btn.Text = "Button"
        Me.btn.UseVisualStyleBackColor = False
        '
        'coler
        '
        Me.coler.Location = New System.Drawing.Point(39, 431)
        Me.coler.Name = "coler"
        Me.coler.Size = New System.Drawing.Size(267, 143)
        Me.coler.TabIndex = 1
        Me.coler.Text = "coler"
        Me.coler.UseVisualStyleBackColor = True
        '
        'txtValue1
        '
        Me.txtValue1.Location = New System.Drawing.Point(517, 109)
        Me.txtValue1.Name = "txtValue1"
        Me.txtValue1.Size = New System.Drawing.Size(113, 19)
        Me.txtValue1.TabIndex = 2
        '
        'calc_plus
        '
        Me.calc_plus.Location = New System.Drawing.Point(537, 151)
        Me.calc_plus.Name = "calc_plus"
        Me.calc_plus.Size = New System.Drawing.Size(68, 65)
        Me.calc_plus.TabIndex = 3
        Me.calc_plus.Text = "+"
        Me.calc_plus.UseVisualStyleBackColor = True
        '
        'txtValue2
        '
        Me.txtValue2.Location = New System.Drawing.Point(659, 109)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(191, 19)
        Me.txtValue2.TabIndex = 4
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(882, 116)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(26, 12)
        Me.lblAnswer.TabIndex = 5
        Me.lblAnswer.Text = "答え"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 614)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtValue2)
        Me.Controls.Add(Me.calc_plus)
        Me.Controls.Add(Me.txtValue1)
        Me.Controls.Add(Me.coler)
        Me.Controls.Add(Me.btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents coler As Button
    Friend WithEvents txtValue1 As TextBox
    Friend WithEvents calc_plus As Button
    Friend WithEvents txtValue2 As TextBox
    Friend WithEvents lblAnswer As Label
End Class
