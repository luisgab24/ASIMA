Public Class Ordenes_Diligenciar
    Private Sub OMBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OMBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EstrategiaDataSet)

    End Sub

    Private Sub Ordenes_Diligenciar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Modos_de_FallaTableAdapter.Fill(Me.EstrategiaDataSet.Modos_de_Falla)
        Me.RepuestosTableAdapter.Fill(Me.EstrategiaDataSet.Repuestos)
        Me.EmpleadosTableAdapter.Fill(Me.EstrategiaDataSet.Empleados)
        Label8.Text = Login.FullName

        Me.OMTableAdapter.Fill(Me.EstrategiaDataSet.OM)

        NombreTecnico1ComboBox.Items.Clear()
        NombreTecnico2ComboBox.Items.Clear()
        NombreTecnico3ComboBox.Items.Clear()
        NombreTecnico4ComboBox.Items.Clear()
        NombreTecnico5ComboBox.Items.Clear()
        NombreTecnico6ComboBox.Items.Clear()

        NombreTecnico1ComboBox.Items.Add("")
        NombreTecnico2ComboBox.Items.Add("")
        NombreTecnico3ComboBox.Items.Add("")
        NombreTecnico4ComboBox.Items.Add("")
        NombreTecnico5ComboBox.Items.Add("")
        NombreTecnico6ComboBox.Items.Add("")

        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("")
        ComboBox1.Items.Add("Instrumentación")
        ComboBox1.Items.Add("Mecánica")
        ComboBox1.Items.Add("Electricidad")
        ComboBox1.Items.Add("CBM")

        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("")
        ComboBox2.Items.Add("Instrumentación")
        ComboBox2.Items.Add("Mecánica")
        ComboBox2.Items.Add("Electricidad")
        ComboBox2.Items.Add("CBM")

        ComboBox3.Items.Clear()
        ComboBox3.Items.Add("")
        ComboBox3.Items.Add("Instrumentación")
        ComboBox3.Items.Add("Mecánica")
        ComboBox3.Items.Add("Electricidad")
        ComboBox3.Items.Add("CBM")

        ComboBox4.Items.Clear()
        ComboBox4.Items.Add("")
        ComboBox4.Items.Add("Instrumentación")
        ComboBox4.Items.Add("Mecánica")
        ComboBox4.Items.Add("Electricidad")
        ComboBox4.Items.Add("CBM")

        ComboBox5.Items.Clear()
        ComboBox5.Items.Add("")
        ComboBox5.Items.Add("Instrumentación")
        ComboBox5.Items.Add("Mecánica")
        ComboBox5.Items.Add("Electricidad")
        ComboBox5.Items.Add("CBM")

        ComboBox6.Items.Clear()
        ComboBox6.Items.Add("")
        ComboBox6.Items.Add("INS")
        ComboBox6.Items.Add("MEC")
        ComboBox6.Items.Add("ELE")

        ComboBox7.Items.Clear()
        ComboBox7.Items.Add("")
        ComboBox7.Items.Add("INS")
        ComboBox7.Items.Add("MEC")
        ComboBox7.Items.Add("ELE")


        Dim myDataTable = EmpleadosTableAdapter.GetNombre()
        For Each dataRow In myDataTable.Rows
            NombreTecnico1ComboBox.Items.Add(dataRow.FullName)
            NombreTecnico2ComboBox.Items.Add(dataRow.FullName)
            NombreTecnico3ComboBox.Items.Add(dataRow.FullName)
            NombreTecnico4ComboBox.Items.Add(dataRow.FullName)
            NombreTecnico5ComboBox.Items.Add(dataRow.FullName)
            NombreTecnico6ComboBox.Items.Add(dataRow.FullName)
        Next dataRow

        Cod_OTComboBox.Items.Clear()
        Dim myDataTable2 = OMTableAdapter.GetOTnumber("%rogramada")
        For Each dataRow In myDataTable2.Rows
            Cod_OTComboBox.Items.Add(dataRow.Cod_OT)
        Next dataRow

        Me.OMTableAdapter.Fill2(EstrategiaDataSet.OM, "")

    End Sub


    Private Sub Cod_OTComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Cod_OTComboBox.KeyDown
        If e.KeyCode = Keys.Enter Then

            Me.OMTableAdapter.Fill2(EstrategiaDataSet.OM, Cod_OTComboBox.Text)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Cod_OTComboBox.Text = "" Or Permiso_TrabajoTextBox.Text = "" Or Fecha_Ejecucion_InicioDateTimePicker.Value = "01/01/2017" Or
                Fecha_Ejecucion_FinDateTimePicker.Value = "01/01/2017" Or Duracion_EjecucionNumericUpDown.Value = 0 Or
                Como_encontroTextBox.Text = "" Or Actividad_RealizadaTextBox.Text = "" Or Como_quedoTextBox.Text = "" Or
                RecomendacionesTextBox.Text = "" Or Cargo1TextBox.Text = "" Or Especialidad1TextBox.Text = "" Or Fecha1DateTimePicker.Value = "01/01/2017" Or
                Horas1NumericUpDown.Value = 0 Then
            MsgBox("Debe llenar todos los campos obligatorios")

        Else
            If Cod_OTComboBox.Text <> Cod_OTTextBox.Text Then
                MsgBox("Discrepancia de Códigos")
            Else

                If MsgBox("Está seguro que Diligenciar la OT: " & Cod_OTTextBox.Text, vbOKCancel, "Confirmación") = vbOK Then
                    Try

                        Me.Validate()
                        Me.OMBindingSource.EndEdit()
                        Me.OMTableAdapter.Guardar(Permiso_Trabajo:=Permiso_TrabajoTextBox.Text, Fecha_Ejecucion_Inicio:=Fecha_Ejecucion_InicioDateTimePicker.Value,
                                        Fecha_Ejecucion_Fin:=Fecha_Ejecucion_FinDateTimePicker.Value, Hora_Ejecucion_Inicio:=Hora_Ejecucion_InicioDateTimePicker.Value,
                                        Hora_Ejecucion_Fin:=Hora_Ejecucion_FinDateTimePicker.Value, Horas_paro:=Horas_paroNumericUpDown.Value,
                                        Duracion_Ejecucion:=Duracion_EjecucionNumericUpDown.Value, Como_encontro:=Como_encontroTextBox.Text, Actividad_Realizada:=Actividad_RealizadaTextBox.Text,
                                        Como_quedo:=Como_quedoTextBox.Text, Recomendaciones:=RecomendacionesTextBox.Text,
                                        N_Articulo1:=N_Articulo1TextBox.Text, ParteNumero1:=ParteNumero1TextBox.Text, Unidad_Medida1:=Unidad_Medida1TextBox.Text,
                                            Descripcion_Repuesto1:=Descripcion_Repuesto1ComboBox.Text, Cantidad_Usada1:=Cantidad_Usada1NumericUpDown.Value,
                                            Cantidad_Requerida1:=Cantidad_Requerida1NumericUpDown.Value, N_Requerimiento1:=N_Requerimiento1TextBox.Text,
                                        N_Articulo2:=N_Articulo2TextBox.Text, ParteNumero2:=ParteNumero2TextBox.Text, Unidad_Medida2:=Unidad_Medida2TextBox.Text,
                                            Descripcion_Repuesto2:=Descripcion_Repuesto2ComboBox.Text, Cantidad_Usada2:=Cantidad_Usada2NumericUpDown.Value,
                                            Cantidad_Requerida2:=Cantidad_Requerida2NumericUpDown.Value, N_Requerimiento2:=N_Requerimiento2TextBox.Text,
                                        N_Articulo3:=N_Articulo3TextBox.Text, ParteNumero3:=ParteNumero3TextBox.Text, Unidad_Medida3:=Unidad_Medida3TextBox.Text,
                                            Descripcion_Repuesto3:=Descripcion_Repuesto3ComboBox.Text, Cantidad_Usada3:=Cantidad_Usada3NumericUpDown.Value,
                                            Cantidad_Requerida3:=Cantidad_Requerida3NumericUpDown.Value, N_Requerimiento3:=N_Requerimiento3TextBox.Text,
                                        N_Articulo4:=N_Articulo4TextBox.Text, ParteNumero4:=ParteNumero4TextBox.Text, Unidad_Medida4:=Unidad_Medida4TextBox.Text,
                                            Descripcion_Repuesto4:=Descripcion_Repuesto4ComboBox.Text, Cantidad_Usada4:=Cantidad_Usada4NumericUpDown.Value,
                                            Cantidad_Requerida4:=Cantidad_Requerida4NumericUpDown.Value, N_Requerimiento4:=N_Requerimiento4TextBox.Text,
                                        N_Articulo5:=N_Articulo5TextBox.Text, ParteNumero5:=ParteNumero5TextBox.Text, Unidad_Medida5:=Unidad_Medida5TextBox.Text,
                                            Descripcion_Repuesto5:=Descripcion_Repuesto5ComboBox.Text, Cantidad_Usada5:=Cantidad_Usada5NumericUpDown.Value,
                                            Cantidad_Requerida5:=Cantidad_Requerida5NumericUpDown.Value, N_Requerimiento5:=N_Requerimiento5TextBox.Text,
                                        Modo_de_Falla1:=Modo_de_Falla1ComboBox.Text, Causa_MF1:=Causa_MF1TextBox.Text, Tiempo_Fuera_Servicio1:=Tiempo_Fuera_Servicio1NumericUpDown.Value,
                                            Tiempo_Reparacion1:=Tiempo_Reparacion1NumericUpDown.Value, Afecta_Disponibilidad1:=Afecta_Disponibilidad1CheckBox.CheckState,
                                        Modo_de_Falla2:=Modo_de_Falla2ComboBox.Text, Causa_MF2:=Causa_MF2TextBox.Text, Tiempo_Fuera_Servicio2:=Tiempo_Fuera_Servicio2NumericUpDown.Value,
                                            Tiempo_Reparacion2:=Tiempo_Reparacion2NumericUpDown.Value, Afecta_Disponibilidad2:=Afecta_Disponibilidad2CheckBox.CheckState,
                                        Cargo1:=Cargo1TextBox.Text, Especialidad1:=Especialidad1TextBox.Text, NombreTecnico1:=NombreTecnico1ComboBox.Text,
                                              Fecha1:=Fecha1DateTimePicker.Value, Horas1:=Horas1NumericUpDown.Value, Horas_Extra1:=Horas_Extra1NumericUpDown.Value,
                                        Cargo2:=Cargo2TextBox.Text, Especialidad2:=Especialidad2TextBox.Text, NombreTecnico2:=NombreTecnico2ComboBox.Text,
                                              Fecha2:=Fecha2DateTimePicker.Value, Horas2:=Horas2NumericUpDown.Value, Horas_Extra2:=Horas_Extra2NumericUpDown.Value,
                                        Cargo3:=Cargo3TextBox.Text, Especialidad3:=Especialidad3TextBox.Text, NombreTecnico3:=NombreTecnico3ComboBox.Text,
                                              Fecha3:=Fecha3DateTimePicker.Value, Horas3:=Horas3NumericUpDown.Value, Horas_Extra3:=Horas_Extra3NumericUpDown.Value,
                                        Cargo4:=Cargo4TextBox.Text, Especialidad4:=Especialidad4TextBox.Text, NombreTecnico4:=NombreTecnico4ComboBox.Text,
                                              Fecha4:=Fecha4DateTimePicker.Value, Horas4:=Horas4NumericUpDown.Value, Horas_Extra4:=Horas_Extra4NumericUpDown.Value,
                                        Cargo5:=Cargo5TextBox.Text, Especialidad5:=Especialidad5TextBox.Text, NombreTecnico5:=NombreTecnico5ComboBox.Text,
                                              Fecha5:=Fecha5DateTimePicker.Value, Horas5:=Horas5NumericUpDown.Value, Horas_Extra5:=Horas_Extra5NumericUpDown.Value,
                                        Cargo6:=Cargo6TextBox.Text, Especialidad6:=Especialidad6TextBox.Text, NombreTecnico6:=NombreTecnico6ComboBox.Text,
                                              Fecha6:=Fecha6DateTimePicker.Value, Horas6:=Horas6NumericUpDown.Value, Horas_Extra6:=Horas_Extra6NumericUpDown.Value,
                                        CATM:=CATMNumericUpDown.Value, DESP:=DESPNumericUpDown.Value, PERM:=PERMNumericUpDown.Value, AHER:=AHERNumericUpDown.Value,
                                              OPUB:=OPUBNumericUpDown.Value, CSEG:=CSEGNumericUpDown.Value, DISP:=DISPNumericUpDown.Value, HERR:=HERRNumericUpDown.Value,
                                        REPU:=REPUNumericUpDown.Value, RECU:=RECUNumericUpDown.Value, CAPA:=CAPANumericUpDown.Value, AISL:=AISLNumericUpDown.Value,
                                              DAUD:=DAUDNumericUpDown.Value, OTRO:=OTRONumericUpDown.Value,
                                        Tiempo_total:=CATMNumericUpDown.Value + DESPNumericUpDown.Value + PERMNumericUpDown.Value + AHERNumericUpDown.Value + OPUBNumericUpDown.Value + CSEGNumericUpDown.Value + DISPNumericUpDown.Value + HERRNumericUpDown.Value + REPUNumericUpDown.Value + RECUNumericUpDown.Value + CAPANumericUpDown.Value + AISLNumericUpDown.Value + DAUDNumericUpDown.Value + OTRONumericUpDown.Value,
                                              Duracion_OT:=0, Tecnico_Ejecutante:=Login.FullName, Geopark:="", Supervisor:="", Fecha_Llenado:=Now.Date,
                                        Fecha_Revision:="01/01/2017", Fecha_Aprobacion:="01/01/2017", Notas:=NotasTextBox.Text, Estado:="Diligenciada", Original_Cod_OT:=Cod_OTComboBox.Text)
                        MsgBox("OT Diligenciada Satisfactoriamente")
                        Me.Close()
                        Me.Dispose()
                        Ordenes.Show()
                    Catch ex As Exception
                        MsgBox("Error en la creación de la OT")
                    End Try
                End If
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
        Ordenes.Show()
    End Sub

    Private Sub NombreTecnico1ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles NombreTecnico1ComboBox.SelectedValueChanged
        Especialidad1TextBox.Text = ""
        Cargo1TextBox.Text = ""

        Dim myDataTable = EmpleadosTableAdapter.GetDatos(NombreTecnico1ComboBox.Text)
        For Each dataRow In myDataTable.Rows
            Cargo1TextBox.Text = dataRow.Cargo
            Especialidad1TextBox.Text = dataRow.Especialidad
        Next dataRow
    End Sub

    Private Sub NombreTecnico2ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles NombreTecnico2ComboBox.SelectedValueChanged
        Especialidad2TextBox.Text = ""
        Cargo2TextBox.Text = ""

        Dim myDataTable = EmpleadosTableAdapter.GetDatos(NombreTecnico2ComboBox.Text)
        For Each dataRow In myDataTable.Rows
            Cargo2TextBox.Text = dataRow.Cargo
            Especialidad2TextBox.Text = dataRow.Especialidad
        Next dataRow
    End Sub

    Private Sub NombreTecnico3ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles NombreTecnico3ComboBox.SelectedValueChanged
        Especialidad3TextBox.Text = ""
        Cargo3TextBox.Text = ""

        Dim myDataTable = EmpleadosTableAdapter.GetDatos(NombreTecnico3ComboBox.Text)
        For Each dataRow In myDataTable.Rows
            Cargo3TextBox.Text = dataRow.Cargo
            Especialidad3TextBox.Text = dataRow.Especialidad
        Next dataRow
    End Sub

    Private Sub NombreTecnico4ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles NombreTecnico4ComboBox.SelectedValueChanged
        Especialidad4TextBox.Text = ""
        Cargo4TextBox.Text = ""

        Dim myDataTable = EmpleadosTableAdapter.GetDatos(NombreTecnico4ComboBox.Text)
        For Each dataRow In myDataTable.Rows
            Cargo4TextBox.Text = dataRow.Cargo
            Especialidad4TextBox.Text = dataRow.Especialidad
        Next dataRow
    End Sub

    Private Sub NombreTecnico5ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles NombreTecnico5ComboBox.SelectedValueChanged
        Especialidad5TextBox.Text = ""
        Cargo5TextBox.Text = ""

        Dim myDataTable = EmpleadosTableAdapter.GetDatos(NombreTecnico5ComboBox.Text)
        For Each dataRow In myDataTable.Rows
            Cargo5TextBox.Text = dataRow.Cargo
            Especialidad5TextBox.Text = dataRow.Especialidad
        Next dataRow
    End Sub

    Private Sub NombreTecnico6ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles NombreTecnico6ComboBox.SelectedValueChanged
        Especialidad6TextBox.Text = ""
        Cargo6TextBox.Text = ""

        Dim myDataTable = EmpleadosTableAdapter.GetDatos(NombreTecnico6ComboBox.Text)
        For Each dataRow In myDataTable.Rows
            Cargo6TextBox.Text = dataRow.Cargo
            Especialidad6TextBox.Text = dataRow.Especialidad
        Next dataRow
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim myDataTable = RepuestosTableAdapter.GetDescripcion(ComboBox1.Text)

        Descripcion_Repuesto1ComboBox.Items.Clear()
        Descripcion_Repuesto1ComboBox.Items.Add("")

        For Each dataRow In myDataTable.Rows
            Descripcion_Repuesto1ComboBox.Items.Add(dataRow.Descripcion)
        Next dataRow

        Descripcion_Repuesto1ComboBox.Text = ""
    End Sub

    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged
        Dim myDataTable = RepuestosTableAdapter.GetDescripcion(ComboBox1.Text)
        Descripcion_Repuesto2ComboBox.Items.Clear()
        Descripcion_Repuesto2ComboBox.Items.Add("")
        For Each dataRow In myDataTable.Rows
            Descripcion_Repuesto2ComboBox.Items.Add(dataRow.Descripcion)
        Next dataRow
        Descripcion_Repuesto2ComboBox.Text = ""
    End Sub

    Private Sub ComboBox3_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedValueChanged
        Dim myDataTable = RepuestosTableAdapter.GetDescripcion(ComboBox1.Text)
        Descripcion_Repuesto3ComboBox.Items.Clear()
        Descripcion_Repuesto3ComboBox.Items.Add("")
        For Each dataRow In myDataTable.Rows
            Descripcion_Repuesto3ComboBox.Items.Add(dataRow.Descripcion)
        Next dataRow
        Descripcion_Repuesto3ComboBox.Text = ""
    End Sub

    Private Sub ComboBox4_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedValueChanged
        Dim myDataTable = RepuestosTableAdapter.GetDescripcion(ComboBox1.Text)
        Descripcion_Repuesto4ComboBox.Items.Clear()
        Descripcion_Repuesto4ComboBox.Items.Add("")
        For Each dataRow In myDataTable.Rows
            Descripcion_Repuesto4ComboBox.Items.Add(dataRow.Descripcion)
        Next dataRow
        Descripcion_Repuesto4ComboBox.Text = ""
    End Sub

    Private Sub ComboBox5_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedValueChanged
        Dim myDataTable = RepuestosTableAdapter.GetDescripcion(ComboBox1.Text)
        Descripcion_Repuesto5ComboBox.Items.Clear()
        Descripcion_Repuesto5ComboBox.Items.Add("")
        For Each dataRow In myDataTable.Rows
            Descripcion_Repuesto5ComboBox.Items.Add(dataRow.Descripcion)
        Next dataRow
        Descripcion_Repuesto5ComboBox.Text = ""
    End Sub

    Private Sub Descripcion_Repuesto1ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Descripcion_Repuesto1ComboBox.SelectedValueChanged
        Dim myDataTable = RepuestosTableAdapter.GetDatosRepuestos(Descripcion_Repuesto1ComboBox.Text)
        ParteNumero1TextBox.Text = ""
        Unidad_Medida1TextBox.Text = ""
        For Each dataRow In myDataTable.Rows
            ParteNumero1TextBox.Text = dataRow.Numero_de_Parte
            Unidad_Medida1TextBox.Text = dataRow.Unidad
        Next dataRow

    End Sub

    Private Sub Descripcion_Repuesto2ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Descripcion_Repuesto2ComboBox.SelectedValueChanged
        Dim myDataTable = RepuestosTableAdapter.GetDatosRepuestos(Descripcion_Repuesto2ComboBox.Text)
        ParteNumero2TextBox.Text = ""
        Unidad_Medida2TextBox.Text = ""
        For Each dataRow In myDataTable.Rows
            ParteNumero2TextBox.Text = dataRow.Numero_de_Parte
            Unidad_Medida2TextBox.Text = dataRow.Unidad
        Next dataRow
    End Sub

    Private Sub Descripcion_Repuesto3ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Descripcion_Repuesto3ComboBox.SelectedValueChanged
        Dim myDataTable = RepuestosTableAdapter.GetDatosRepuestos(Descripcion_Repuesto3ComboBox.Text)
        ParteNumero3TextBox.Text = ""
        Unidad_Medida3TextBox.Text = ""
        For Each dataRow In myDataTable.Rows
            ParteNumero3TextBox.Text = dataRow.Numero_de_Parte
            Unidad_Medida3TextBox.Text = dataRow.Unidad
        Next dataRow
    End Sub

    Private Sub Descripcion_Repuesto4ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Descripcion_Repuesto4ComboBox.SelectedValueChanged
        Dim myDataTable = RepuestosTableAdapter.GetDatosRepuestos(Descripcion_Repuesto4ComboBox.Text)
        ParteNumero4TextBox.Text = ""
        Unidad_Medida4TextBox.Text = ""
        For Each dataRow In myDataTable.Rows
            ParteNumero4TextBox.Text = dataRow.Numero_de_Parte
            Unidad_Medida4TextBox.Text = dataRow.Unidad
        Next dataRow
    End Sub

    Private Sub Descripcion_Repuesto5ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Descripcion_Repuesto5ComboBox.SelectedValueChanged
        Dim myDataTable = RepuestosTableAdapter.GetDatosRepuestos(Descripcion_Repuesto5ComboBox.Text)
        ParteNumero5TextBox.Text = ""
        Unidad_Medida5TextBox.Text = ""
        For Each dataRow In myDataTable.Rows
            ParteNumero5TextBox.Text = dataRow.Numero_de_Parte
            Unidad_Medida5TextBox.Text = dataRow.Unidad
        Next dataRow
    End Sub

    Private Sub ComboBox6_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedValueChanged
        Dim myDataTable = Modos_de_FallaTableAdapter.GetMF(ComboBox6.Text)
        Modo_de_Falla1ComboBox.Items.Clear()
        Modo_de_Falla1ComboBox.Items.Add("")
        For Each dataRow In myDataTable.Rows
            Modo_de_Falla1ComboBox.Items.Add(dataRow.Modo_Falla)
        Next dataRow
        Modo_de_Falla1ComboBox.Text = ""
    End Sub

    Private Sub ComboBox7_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedValueChanged
        Dim myDataTable = Modos_de_FallaTableAdapter.GetMF(ComboBox7.Text)
        Modo_de_Falla2ComboBox.Items.Clear()
        Modo_de_Falla2ComboBox.Items.Add("")
        For Each dataRow In myDataTable.Rows
            Modo_de_Falla2ComboBox.Items.Add(dataRow.Modo_Falla)
        Next dataRow
        Modo_de_Falla2ComboBox.Text = ""
    End Sub
End Class