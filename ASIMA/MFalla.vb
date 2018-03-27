



Imports System.Data.SqlClient

Public Class MFalla


    Private Sub Modos_de_FallaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Modos_de_FallaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EstrategiaDataSet)

    End Sub

    Private Sub MFalla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EstrategiaDataSet.Modos_de_Falla' Puede moverla o quitarla según sea necesario.
        'Me.Modos_de_FallaTableAdapter.FillCombo1(Me.EstrategiaDataSet.Modos_de_Falla)

        Dim myDataTable = Modos_de_FallaTableAdapter.GetDataCombo1()

        For Each dataRow In myDataTable.Rows
            Familia__Nivel_6_ComboBox.Items.Add(dataRow._Familia__Nivel_6_)
        Next dataRow

    End Sub


    Private Sub Familia__Nivel_6_ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Familia__Nivel_6_ComboBox.SelectedValueChanged
        Dim myDataTable2 = Modos_de_FallaTableAdapter.GetDataCombo2(Familia__Nivel_6_ComboBox.Text)

        Tipo_Equipo__Nivel_7_ComboBox.Items.Clear()
        Modo_FallaComboBox.Items.Clear()
        Tipo_Equipo__Nivel_7_ComboBox.Text = ""
        Modo_FallaComboBox.Text = ""

        DisciplinaTextBox.Text = ""
        Código_GrupoTextBox.Text = ""
        Código_Modo_FallaTextBox.Text = ""

        Modo_de_DeteccionTextBox.Text = ""
        Causa_de_Modo_de_FallaTextBox.Text = ""
        Criticidad_Modo_de_FallaTextBox.Text = ""

        Tipo_de_TareaTextBox.Text = ""
        Descripción_de_la_Actividad_CorrectivaTextBox.Text = ""
        Fallas___AñoTextBox.Text = ""
        Duracion__Mins_TextBox.Text = ""
        Tipo_AislamientoTextBox.Text = ""

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
        Dim myDataTable3 = Modos_de_FallaTableAdapter.GetDataCombo3(Familia__Nivel_6_ComboBox.Text, Tipo_Equipo__Nivel_7_ComboBox.Text)

        Modo_FallaComboBox.Items.Clear()
        Modo_FallaComboBox.Text = ""


        DisciplinaTextBox.Text = ""
        Código_GrupoTextBox.Text = ""
        Código_Modo_FallaTextBox.Text = ""

        Modo_de_DeteccionTextBox.Text = ""
        Causa_de_Modo_de_FallaTextBox.Text = ""
        Criticidad_Modo_de_FallaTextBox.Text = ""

        Tipo_de_TareaTextBox.Text = ""
        Descripción_de_la_Actividad_CorrectivaTextBox.Text = ""
        Fallas___AñoTextBox.Text = ""
        Duracion__Mins_TextBox.Text = ""
        Tipo_AislamientoTextBox.Text = ""

        Htas_Especiales_1TextBox.Text = ""
        Htas_Especiales_2TextBox.Text = ""
        Htas_Especiales_3TextBox.Text = ""
        Htas_Especiales_4TextBox.Text = ""
        ComentariosTextBox.Text = ""

        For Each dataRow In myDataTable3.Rows
            Modo_FallaComboBox.Items.Add(dataRow.Modo_Falla)
        Next dataRow
    End Sub

    Private Sub Modo_FallaComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Modo_FallaComboBox.SelectedValueChanged
        'Modos_de_FallaTableAdapter.(Familia__Nivel_6_ComboBox.Text, Tipo_Equipo__Nivel_7_ComboBox.Text, Modo_FallaComboBox.Text)
        Dim myDataTable4 = Modos_de_FallaTableAdapter.GetDataTotal(Familia__Nivel_6_ComboBox.Text, Tipo_Equipo__Nivel_7_ComboBox.Text, Modo_FallaComboBox.Text)
        Me.Modos_de_FallaTableAdapter.FillTotal(myDataTable4, Familia__Nivel_6_ComboBox.Text, Tipo_Equipo__Nivel_7_ComboBox.Text, Modo_FallaComboBox.Text)
        For Each dataRow In myDataTable4.Rows
            'Modo_FallaComboBox.Items.Add(dataRow.Modo_Falla)

            DisciplinaTextBox.Text = dataRow.Disciplina
            Código_GrupoTextBox.Text = dataRow.Código_Grupo
            Código_Modo_FallaTextBox.Text = dataRow.Código_Modo_Falla

            Modo_de_DeteccionTextBox.Text = dataRow.Modo_de_Deteccion
            Causa_de_Modo_de_FallaTextBox.Text = dataRow.Causa_de_Modo_de_Falla
            Criticidad_Modo_de_FallaTextBox.Text = dataRow.Criticidad_Modo_de_Falla

            Tipo_de_TareaTextBox.Text = dataRow.Tipo_de_Tarea
            Descripción_de_la_Actividad_CorrectivaTextBox.Text = dataRow.Descripción_de_la_Actividad_Correctiva
            Fallas___AñoTextBox.Text = dataRow._Fallas___Año
            Duracion__Mins_TextBox.Text = dataRow._Duracion__Mins_
            Tipo_AislamientoTextBox.Text = dataRow.Tipo_Aislamiento

            Htas_Especiales_1TextBox.Text = dataRow.Htas_Especiales_1
            Htas_Especiales_2TextBox.Text = dataRow.Htas_Especiales_2
            Htas_Especiales_3TextBox.Text = dataRow.Htas_Especiales_3
            Htas_Especiales_4TextBox.Text = dataRow.Htas_Especiales_4
            ComentariosTextBox.Text = dataRow.Comentarios




        Next dataRow
    End Sub

    Private Sub MFalla_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
        MttoCorrectivo.Show()
    End Sub
End Class