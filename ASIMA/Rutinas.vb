Public Class Rutinas

    Private Sub Rutinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myDataTable = RutinasTableAdapter.GetDataCombo1()

        For Each dataRow In myDataTable.Rows
            Familia__Nivel_6_ComboBox.Items.Add(dataRow._Familia__Nivel_6_)
        Next dataRow
    End Sub

    Private Sub Familia__Nivel_6_ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Familia__Nivel_6_ComboBox.SelectedValueChanged
        Dim myDataTable2 = RutinasTableAdapter.GetDataCombo2(Familia__Nivel_6_ComboBox.Text)

        Tipo_Equipo__Nivel_7_ComboBox.Items.Clear()
        DisciplinaComboBox.Items.Clear()
        ComboBox1.Items.Clear()
        Tipo_Equipo__Nivel_7_ComboBox.Text = ""
        DisciplinaComboBox.Text = ""
        ComboBox1.Text = ""

        Código_GrupoTextBox.Text = ""
        Descripción_de_la_RutinaTextBox.Text = ""
        Tipo_de_TareaTextBox.Text = ""
        Cantidad_de_TécnicosTextBox.Text = ""
        Frecuencia_x_AñoTextBox.Text = ""
        Modos_de_Falla_AsociadosTextBox.Text = ""
        Duración__Mins_TextBox.Text = ""

        Htas_Especiales_1TextBox.Text = ""
        Htas_Especiales_2TextBox.Text = ""
        Htas_Especiales_3TextBox.Text = ""
        Htas_Especiales_4TextBox.Text = ""
        ComentariosTextBox.Text = ""


        For Each dataRow In myDataTable2.Rows
            Tipo_Equipo__Nivel_7_ComboBox.Items.Add(dataRow._Tipo_Equipo__Nivel_7_)
        Next dataRow
    End Sub

    Private Sub Tipo_Equipo__Nivel_7_ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Tipo_Equipo__Nivel_7_ComboBox.SelectedValueChanged
        Dim myDataTable3 = RutinasTableAdapter.GetDataCombo3(Familia__Nivel_6_ComboBox.Text, Tipo_Equipo__Nivel_7_ComboBox.Text)

        DisciplinaComboBox.Items.Clear()
        ComboBox1.Items.Clear()
        DisciplinaComboBox.Text = ""
        ComboBox1.Text = ""

        Código_GrupoTextBox.Text = ""
        Descripción_de_la_RutinaTextBox.Text = ""
        Tipo_de_TareaTextBox.Text = ""
        Cantidad_de_TécnicosTextBox.Text = ""
        Frecuencia_x_AñoTextBox.Text = ""
        Modos_de_Falla_AsociadosTextBox.Text = ""
        Duración__Mins_TextBox.Text = ""

        Htas_Especiales_1TextBox.Text = ""
        Htas_Especiales_2TextBox.Text = ""
        Htas_Especiales_3TextBox.Text = ""
        Htas_Especiales_4TextBox.Text = ""
        ComentariosTextBox.Text = ""

        For Each dataRow In myDataTable3.Rows
            DisciplinaComboBox.Items.Add(dataRow.Disciplina)
        Next dataRow
    End Sub

    Private Sub DisciplinaComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles DisciplinaComboBox.SelectedValueChanged

        Dim myDataTable4 = RutinasTableAdapter.GetDataCombo4(Familia__Nivel_6_ComboBox.Text, Tipo_Equipo__Nivel_7_ComboBox.Text, DisciplinaComboBox.Text)

        ComboBox1.Items.Clear()
        ComboBox1.Text = ""


        Código_GrupoTextBox.Text = ""
        Descripción_de_la_RutinaTextBox.Text = ""
        Tipo_de_TareaTextBox.Text = ""
        Cantidad_de_TécnicosTextBox.Text = ""
        Frecuencia_x_AñoTextBox.Text = ""
        Modos_de_Falla_AsociadosTextBox.Text = ""
        Duración__Mins_TextBox.Text = ""

        Htas_Especiales_1TextBox.Text = ""
        Htas_Especiales_2TextBox.Text = ""
        Htas_Especiales_3TextBox.Text = ""
        Htas_Especiales_4TextBox.Text = ""
        ComentariosTextBox.Text = ""

        For Each dataRow In myDataTable4.Rows
            ComboBox1.Items.Add(dataRow.Código_Rutina)
        Next dataRow
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim myDataTable5 = RutinasTableAdapter.GetDataTotal(Familia__Nivel_6_ComboBox.Text, Tipo_Equipo__Nivel_7_ComboBox.Text, DisciplinaComboBox.Text, ComboBox1.Text)
        'Me.RutinasTableAdapter.FillTotal(myDataTable4, Familia__Nivel_6_ComboBox.Text, Tipo_Equipo__Nivel_7_ComboBox.Text, Modo_FallaComboBox.Text)
        For Each dataRow In myDataTable5.Rows
            'Modo_FallaComboBox.Items.Add(dataRow.Modo_Falla)

            Código_GrupoTextBox.Text = dataRow.Código_Grupo
            Descripción_de_la_RutinaTextBox.Text = dataRow.Descripción_de_la_Rutina
            Tipo_de_TareaTextBox.Text = dataRow.Tipo_de_Tarea
            Cantidad_de_TécnicosTextBox.Text = dataRow.Cantidad_de_Técnicos
            Frecuencia_x_AñoTextBox.Text = dataRow.Frecuencia_x_Año
            Modos_de_Falla_AsociadosTextBox.Text = dataRow.Modos_de_Falla_Asociados
            Duración__Mins_TextBox.Text = dataRow._Duración__Mins_

            Htas_Especiales_1TextBox.Text = dataRow.Htas_Especiales_1
            Htas_Especiales_2TextBox.Text = dataRow.Htas_Especiales_2
            Htas_Especiales_3TextBox.Text = dataRow.Htas_Especiales_3
            Htas_Especiales_4TextBox.Text = dataRow.Htas_Especiales_4
            ComentariosTextBox.Text = dataRow.Comentarios

        Next dataRow
    End Sub

    Private Sub Rutinas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim Planeacion As New Planeacion
        Planeacion.Show()
    End Sub
End Class