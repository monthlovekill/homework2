Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtUserName.Text = "login" Then
            If txtPassword.Text = "abc123" Then
                MessageBox.Show("登入成功！")
            Else
                MessageBox.Show("登入失敗!")
            End If
        Else
            MessageBox.Show("登入失敗!")

        End If
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Application.Exit()

    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

        Dim tb As TextBox = CType(sender, TextBox)

        If (String.IsNullOrEmpty(tb.Text)) Then

            tb.BackColor = Color.MistyRose

        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        Dim tb As TextBox = CType(sender, TextBox)

        If (String.IsNullOrEmpty(tb.Text)) Then

            tb.BackColor = Color.MistyRose
        End If

    End Sub
End Class
