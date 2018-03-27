Public Class Login

    Public Role As String
    Public FullName As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EstrategiaDataSet.Users' Puede moverla o quitarla según sea necesario.
        Me.UsersTableAdapter.Fill(Me.EstrategiaDataSet.Users)
        User_Name_Text.Text = ""

    End Sub



    Private Sub Cancel_Button_Click_1(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
        Principal.Close()
        Me.Dispose()
        End
    End Sub

    Private Sub OK_Button_Click_1(sender As Object, e As EventArgs) Handles OK_Button.Click

        Try
            Dim entrar = Me.UsersTableAdapter.Validate(User_Name_Text.Text, Password_text.Text)
            Dim myDataTable = UsersTableAdapter.GetUser(User_Name_Text.Text, Password_text.Text)
            Me.UsersTableAdapter.FillUser(myDataTable, User_Name_Text.Text, Password_text.Text)

            If entrar <> 0 Then
                For Each dataRow In myDataTable.Rows
                    MsgBox("Bienvenid@:   " & dataRow.FirstName)

                    Role = dataRow.Role
                    FullName = dataRow.FirstName & " " & dataRow.LastName
                Next dataRow

                Principal.Show()
                Me.Hide()
            Else
                MsgBox("Usuario o Contraseña Inválida, intente de nuevo")
            End If


        Catch ex As Exception
            MsgBox("ERROR DE CREDENCIALES")
        End Try

    End Sub
End Class