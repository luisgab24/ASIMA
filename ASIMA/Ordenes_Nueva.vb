Public Class Ordenes_Nueva
    Dim pre1 As String
    Private Sub OMBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OMBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EstrategiaDataSet)
    End Sub

    Private Sub Ordenes_Nueva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Login.FullName
        Label3.Text = Login.Role

        Me.Estrategia_de_MantenimientoTableAdapter.Fill(Me.EstrategiaDataSet.Estrategia_de_Mantenimiento)
        Me.OMTableAdapter.Fill(Me.EstrategiaDataSet.OM)
        Me.Estrategia_de_MantenimientoTableAdapter.Fill(Me.EstrategiaDataSet.Estrategia_de_Mantenimiento)

        'Limpiar items previos y crear los items para las esepcialidades
        EspecialidadComboBox.Items.Clear()
        EspecialidadComboBox.Items.Add("CBM")
        EspecialidadComboBox.Items.Add("Electricidad")
        EspecialidadComboBox.Items.Add("Instrumentación")
        EspecialidadComboBox.Items.Add("Mecánica")

        'Limpiar items previos y crear los items para los tipos de OT
        Tipo_OTComboBox.Items.Clear()
        Tipo_OTComboBox.Items.Add("Correctiva")
        Tipo_OTComboBox.Items.Add("Preventiva")
        Tipo_OTComboBox.Items.Add("Predictiva")
        Tipo_OTComboBox.Items.Add("Mejorativa")

        'Limpiar items previos y crear los items para los tipos de unidad de negocio
        Unidad_NegocioComboBox.Items.Clear()
        Unidad_NegocioComboBox.Items.Add("LL34")

        'Limpiar items previos y crear los items para los tipos de planta
        PlantaComboBox.Items.Clear()
        Dim myDataTable = Estrategia_de_MantenimientoTableAdapter.GetCombo1()
        For Each dataRow In myDataTable.Rows
            PlantaComboBox.Items.Add(dataRow.DESCRIPCION_PLANTA)
        Next dataRow

        'Limpiar items previos y crear los items para los tipos de sistema
        SistemaComboBox.Items.Clear()

        'Limpiar items previos y crear los items para los tipos de subfuncion
        SubFuncionComboBox.Items.Clear()

        'Limpiar items previos y crear los items para los tipos de familia equipo
        Familia_EquipoComboBox.Items.Clear()

        'Limpiar items previos y crear los items para los tipos de familia equipo
        Tipo_EquipoComboBox.Items.Clear()

        'Limpiar items previos y crear los items para los TAGS
        TAGComboBox.Items.Clear()

        'Limpiar items previos y crear los items para la prioridad
        PrioridadComboBox.Items.Clear()
        PrioridadComboBox.Items.Add("1")
        PrioridadComboBox.Items.Add("2")
        PrioridadComboBox.Items.Add("3")

        EspecialidadComboBox.Text = ""
        Tipo_OTComboBox.Text = ""
        Unidad_NegocioComboBox.Text = ""
        PlantaComboBox.Text = ""
        SistemaComboBox.Text = ""
        SubFuncionComboBox.Text = ""
        Familia_EquipoComboBox.Text = ""
        Tipo_EquipoComboBox.Text = ""
        TAGComboBox.Text = ""
        PrioridadComboBox.Text = ""
        OriginadorLabel2.Text = Login.FullName
        Descripcion_ActividadTextBox.Text = ""
        Duracion_planeadaNumericUpDown.Value = "1"
        Fecha_ProgramadoDateTimePicker.Value = "01/01/2017"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
        Ordenes.Show()
    End Sub

    Private Sub PlantaComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles PlantaComboBox.SelectedValueChanged
        'Limpiar items previos y crear los items para los tipos de sistema
        SistemaComboBox.Items.Clear()
        Dim myDataTable = Estrategia_de_MantenimientoTableAdapter.GetCombo2(PlantaComboBox.Text)
        For Each dataRow In myDataTable.Rows
            SistemaComboBox.Items.Add(dataRow.DESCRIPCION_FUNCION)
        Next dataRow
    End Sub

    Private Sub SistemaComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles SistemaComboBox.SelectedValueChanged
        'Limpiar items previos y crear los items para los tipos de subfuncion
        SubFuncionComboBox.Items.Clear()
        Dim myDataTable = Estrategia_de_MantenimientoTableAdapter.GetCombo3(PlantaComboBox.Text, SistemaComboBox.Text)
        For Each dataRow In myDataTable.Rows
            SubFuncionComboBox.Items.Add(dataRow.SUB_FUNCION)
        Next dataRow
    End Sub

    Private Sub SubFuncionComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles SubFuncionComboBox.SelectedValueChanged
        'Limpiar items previos y crear los items para los tipos de familia equipo
        Familia_EquipoComboBox.Items.Clear()
        Dim myDataTable = Estrategia_de_MantenimientoTableAdapter.GetCombo4(PlantaComboBox.Text, SistemaComboBox.Text, SubFuncionComboBox.Text)
        For Each dataRow In myDataTable.Rows
            Familia_EquipoComboBox.Items.Add(dataRow._Familia_Nivel_6_)
        Next dataRow
    End Sub

    Private Sub Familia_EquipoComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Familia_EquipoComboBox.SelectedValueChanged
        'Limpiar items previos y crear los items para los tipos de equipo
        Tipo_EquipoComboBox.Items.Clear()
        Dim myDataTable = Estrategia_de_MantenimientoTableAdapter.GetCombo5(PlantaComboBox.Text, SistemaComboBox.Text, SubFuncionComboBox.Text, Familia_EquipoComboBox.Text)
        For Each dataRow In myDataTable.Rows
            Tipo_EquipoComboBox.Items.Add(dataRow._Tipo_Equipo__Nivel_7_)
        Next dataRow
    End Sub

    Private Sub Tipo_EquipoComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Tipo_EquipoComboBox.SelectedValueChanged
        'Limpiar items previos y crear los items para los TAGS
        TAGComboBox.Items.Clear()
        Dim myDataTable = Estrategia_de_MantenimientoTableAdapter.GetCombo6(PlantaComboBox.Text, SistemaComboBox.Text, SubFuncionComboBox.Text, Familia_EquipoComboBox.Text, Tipo_EquipoComboBox.Text)
        For Each dataRow In myDataTable.Rows
            TAGComboBox.Items.Add(dataRow.TAG)
        Next dataRow
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (EspecialidadComboBox.Text = "" Or Tipo_OTComboBox.Text = "" Or
            Unidad_NegocioComboBox.Text = "" Or PlantaComboBox.Text = "" Or
            SistemaComboBox.Text = "" Or SubFuncionComboBox.Text = "" Or
            Familia_EquipoComboBox.Text = "" Or Tipo_EquipoComboBox.Text = "" Or
            TAGComboBox.Text = "" Or PrioridadComboBox.Text = "" Or
            OriginadorLabel2.Text = "" Or Descripcion_ActividadTextBox.Text = "") Then
            MsgBox("Todos los campos deben estar llenos")
        Else
            Dim consecutivo As Integer
            Dim prefijo, consecutivostr As String
            Dim año, mes
            consecutivo = Me.OMTableAdapter.Consecutivo_OT()
            consecutivo = consecutivo + 1
            consecutivostr = consecutivo.ToString("D4")
            año = Format(Now, "yy")
            mes = Format(Now, "MM")
            prefijo = "GPK" & "-" & pre1 & "-" & año & mes & "-" & consecutivostr

            If Fecha_ProgramadoDateTimePicker.Value = "01/01/2017" Then
                MsgBox("Debe seleccionar una fecha")
            Else
                If MsgBox("Está seguro que desea crear la OT: " & prefijo, vbOKCancel, "Confirmación") = vbOK Then
                    Try

                        Me.OMTableAdapter.InsertOM(EspecialidadComboBox.Text, Tipo_OTComboBox.Text, prefijo, Unidad_NegocioComboBox.Text, PlantaComboBox.Text,
                                            SistemaComboBox.Text, SubFuncionComboBox.Text, Familia_EquipoComboBox.Text, Tipo_EquipoComboBox.Text, TAGComboBox.Text,
                                            PrioridadComboBox.Text, OriginadorLabel2.Text, Descripcion_ActividadTextBox.Text, Duracion_planeadaNumericUpDown.Value,
                                            Estado:="Programada", Fecha_Programado:=Fecha_ProgramadoDateTimePicker.Value, Permiso_Trabajo:="", Fecha_Ejecucion_Inicio:="01/01/2017",
                                            Fecha_Ejecucion_Fin:="01/01/2017", Hora_Ejecucion_Inicio:="00:00", Hora_Ejecucion_Fin:="00:00", Horas_paro:="1",
                                            Duracion_Ejecucion:=0, Como_encontro:="", Actividad_Realizada:="", Como_quedo:="", Recomendaciones:="",
                                            N_Articulo1:=0, ParteNumero1:=0, Unidad_Medida1:="", Descripcion_Repuesto1:="", Cantidad_Usada1:=0, Cantidad_Requerida1:=0, N_Requerimiento1:="",
                                            N_Articulo2:=0, ParteNumero2:=0, Unidad_Medida2:="", Descripcion_Repuesto2:="", Cantidad_Usada2:=0, Cantidad_Requerida2:=0, N_Requerimiento2:="",
                                            N_Articulo3:=0, ParteNumero3:=0, Unidad_Medida3:="", Descripcion_Repuesto3:="", Cantidad_Usada3:=0, Cantidad_Requerida3:=0, N_Requerimiento3:="",
                                            N_Articulo4:=0, ParteNumero4:=0, Unidad_Medida4:="", Descripcion_Repuesto4:="", Cantidad_Usada4:=0, Cantidad_Requerida4:=0, N_Requerimiento4:="",
                                            N_Articulo5:=0, ParteNumero5:=0, Unidad_Medida5:="", Descripcion_Repuesto5:="", Cantidad_Usada5:=0, Cantidad_Requerida5:=0, N_Requerimiento5:="",
                                            Modo_de_Falla1:="", Causa_MF1:="", Tiempo_Fuera_Servicio1:=0, Tiempo_Reparacion1:=0, Afecta_Disponibilidad1:=False,
                                            Modo_de_Falla2:="", Causa_MF2:="", Tiempo_Fuera_Servicio2:=0, Tiempo_Reparacion2:=0, Afecta_Disponibilidad2:=False,
                                            Cargo1:="", Especialidad1:="", NombreTecnico1:="", Fecha1:="01/01/2017", Horas1:=0, Horas_Extra1:=0,
                                            Cargo2:="", Especialidad2:="", NombreTecnico2:="", Fecha2:="01/01/2017", Horas2:=0, Horas_Extra2:=0,
                                            Cargo3:="", Especialidad3:="", NombreTecnico3:="", Fecha3:="01/01/2017", Horas3:=0, Horas_Extra3:=0,
                                            Cargo4:="", Especialidad4:="", NombreTecnico4:="", Fecha4:="01/01/2017", Horas4:=0, Horas_Extra4:=0,
                                            Cargo5:="", Especialidad5:="", NombreTecnico5:="", Fecha5:="01/01/2017", Horas5:=0, Horas_Extra5:=0,
                                            Cargo6:="", Especialidad6:="", NombreTecnico6:="", Fecha6:="01/01/2017", Horas6:=0, Horas_Extra6:=0,
                                            CATM:=0, DESP:=0, PERM:=0, AHER:=0, OPUB:=0, CSEG:=0, DISP:=0, HERR:=0, REPU:=0, RECU:=0, CAPA:=0, AISL:=0, DAUD:=0, OTRO:=0,
                                            Tiempo_total:=0, Duracion_OT:=0, Tecnico_Ejecutante:="", Geopark:="", Supervisor:="", Fecha_Creacion:=Now.Date, Fecha_Llenado:="01/01/2017",
                                            Fecha_Revision:="01/01/2017", Fecha_Aprobacion:="01/01/2017", Notas:="", Consecutivo_OT:=consecutivo)
                        Me.Validate()
                        Me.OMBindingSource.EndEdit()
                        MsgBox("OT creada Satisfactoriamente")
                        Ordenes_Nueva_Load(e, e)

                    Catch ex As Exception
                        MsgBox("Error en la creación de la OT")
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub TAGComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TAGComboBox.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim myDataTable = Estrategia_de_MantenimientoTableAdapter.GetTAG(TAGComboBox.Text)
            For Each dataRow In myDataTable.Rows

                Unidad_NegocioComboBox.Text = "LL34"
                PlantaComboBox.Text = dataRow.DESCRIPCION_PLANTA
                SistemaComboBox.Text = dataRow.DESCRIPCION_FUNCION
                SubFuncionComboBox.Text = dataRow.SUB_FUNCION
                Familia_EquipoComboBox.Text = dataRow._Familia_Nivel_6_
                Tipo_EquipoComboBox.Text = dataRow._Tipo_Equipo__Nivel_7_
            Next dataRow
        End If
    End Sub

    Private Sub EspecialidadComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles EspecialidadComboBox.SelectedValueChanged


        If EspecialidadComboBox.Text = "Instrumentación" Then
            pre1 = "INS"
        End If
        If EspecialidadComboBox.Text = "Mecánica" Then
            pre1 = "MEC"
        End If
        If EspecialidadComboBox.Text = "Electricidad" Then
            pre1 = "ELE"
        End If
        If EspecialidadComboBox.Text = "CBM" Then
            pre1 = "CBM"
        End If
    End Sub
End Class

