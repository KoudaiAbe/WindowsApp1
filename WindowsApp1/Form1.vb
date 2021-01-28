Public Class Form1


    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        '変数を使うパターン
        '宣言
        Dim message As String
        '代入
        message = "hello"
        '参照
        MsgBox(message)

        '直接表示するパターン
        'MsgBox("hello")
    End Sub

    Private Sub color_Click(sender As Object, e As EventArgs) Handles coler.Click

        Me.BackColor = Color.Crimson

    End Sub

    Private Sub calcPlus_Click(sender As Object, e As EventArgs) Handles calc_plus.Click

        On Error Resume Next

        Dim X As Decimal
        Dim Y As Decimal

        X = txtValue1.Text
        Y = txtValue2.Text

        lblAnswer.Text = X + Y

    End Sub
End Class
