Public Class Ordenes_Hts
    Private Sub OMBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OMBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EstrategiaDataSet)

    End Sub

    Private Sub Ordenes_Hts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EstrategiaDataSet.OM' Puede moverla o quitarla según sea necesario.
        Me.OMTableAdapter.Fill(Me.EstrategiaDataSet.OM)

        Cod_OTComboBox.Items.Clear()
        Dim myDataTable2 = OMTableAdapter.GetOTnumber("Programada")
        For Each dataRow In myDataTable2.Rows
            Cod_OTComboBox.Items.Add(dataRow.Cod_OT)
        Next dataRow

        Me.OMTableAdapter.Fill2(EstrategiaDataSet.OM, "")
        Fecha_ProgramadoDateTimePicker.Value = "01/01/2017"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If MsgBox("Está seguro que Reprogramar la OT: " & Cod_OTComboBox.Text, vbOKCancel, "Confirmación") = vbOK Then
            Try

                Me.Validate()
                Me.OMBindingSource.EndEdit()
                Me.OMTableAdapter.UpdateFecha(Fecha_ProgramadoDateTimePicker.Value, "Reprogramada", Cod_OTComboBox.Text)
                MsgBox("OT Reprogramada Satisfactoriamente")
                Me.Close()
                Me.Dispose()
                Ordenes.Show()
            Catch ex As Exception
                MsgBox("Error en la creación de la OT")
            End Try
        End If
    End Sub

    Private Sub Cod_OTComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Cod_OTComboBox.KeyDown
        If e.KeyCode = Keys.Enter Then

            Me.OMTableAdapter.Fill2(EstrategiaDataSet.OM, Cod_OTComboBox.Text)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
        Ordenes.Show()

    End Sub
End Class