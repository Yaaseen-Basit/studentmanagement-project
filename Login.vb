Public Class Login

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtsutdentid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsutdentid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpassword.Focus()
        End If

    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnlogin.Focus()
        End If

    End Sub


    Private Sub txtsutdentid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsutdentid.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) _
            Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.KeyChar = " "
        End If

    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) _
            Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.KeyChar = " "
        End If

    End Sub

End Class