Public Class Form1
    Private Sub Greatbtn_Click(sender As Object, e As EventArgs) Handles Greatbtn.Click
        Dim stFirstName As String
        Dim stSurname As String
        Dim stGender As String

        stFirstName = txtFirstName.Text
        stSurname = txtSurname.Text
        stGender = txtGender.Text

        MsgBox("Hello " & stFirstName & "  " & stSurname & " it is good to know that your gender is " & stGender)

    End Sub
End Class
