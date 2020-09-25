
Imports System.Data
Imports System.Data.SqlClient
Imports System




Public Class frmstudentinfo



    Sub clear()
        txtrollno.Text = ""
        txtname.Text = ""
        txtrollno.ReadOnly = False
        txtname.ReadOnly = False
        txtage.Text = ""
        txtrollno.Focus()

    End Sub

    Private Sub txtrollno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtrollno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Focus()
        End If

    End Sub
    Private Sub txtrollno_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles txtrollno.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) _
            Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.KeyChar = " "
        End If

    End Sub

    Private Sub txtname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtage.Focus()
        End If

    End Sub

    Private Sub txtage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtage.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsave.Focus()
        End If

    End Sub
    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) _
            Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.KeyChar = " "
        End If

    End Sub

    Private Sub txtage_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles txtage.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) _
            Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.KeyChar = " "
        End If

    End Sub



    
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click



        Dim con As SqlConnection
        Dim strSql As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        con = New SqlConnection("Data Source =QSSERVER\QSPL;Initial Catalog=Training_GeetanjaliB; User ID=Training;Password =Train123!")
        If con.State = ConnectionState.Closed Then con.Open()

        strSql = "Insert into stud(stud_name, stud_rollno,age) values ('" & Trim(txtname.Text) & "'," & txtrollno.Text & "," & txtage.Text & ")"

        cmd = New SqlCommand(strSql, con)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Record Saved Successfully", "eSchool", MessageBoxButtons.OK)

    End Sub

    

    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        Dim con As SqlConnection
        Dim strsql As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        con = New SqlConnection("Data Source =QSSERVER\QSPL;Initial Catalog=Training_GeetanjaliB; User ID=Training;Password =Train123!")
        If con.State = ConnectionState.Closed Then con.Open()

        'strsql = " Update stud Set (stud_rollno=" & txtrollno.Text & ", stud_name='" & txtname.Text & "'  where stud_rollno=" & txtrollno.Text & ""
        strsql = "update stud set stud_rollno= " & txtrollno.Text & " , stud_name='" & txtname.Text & "' ,age= " & txtage.Text & " where stud_rollno=" & txtrollno.Text & ""


        cmd = New SqlCommand(strsql, con)

        cmd.ExecuteNonQuery()
        MessageBox.Show("Modified Successfully", "eSchool", MessageBoxButtons.OK)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim con As SqlConnection
        Dim strdel As String = ""
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        con = New SqlConnection("Data Source =QSSERVER\QSPL;Initial Catalog=Training_GeetanjaliB; User ID=Training;Password =Train123!")
        If con.State = ConnectionState.Closed Then con.Open()
        If (MessageBox.Show("Are You Sure You Want To Delete This Record", "eSchool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            strdel = "Delete from stud Where   stud_rollno=" & txtrollno.Text
        End If

        cmd = New SqlCommand(strdel, con)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Record Deleted Successfully", "eSchool", MessageBoxButtons.OK)

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        clear()

        txtrollno.Focus()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub txtage_TextChanged(sender As Object, e As EventArgs) Handles txtage.TextChanged

    End Sub


    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        frmsreport.Show()
    End Sub

    Private Sub frmstudentinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
