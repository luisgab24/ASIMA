Public Class Ordenes_Validar
    Private Sub OMBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OMBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EstrategiaDataSet)

    End Sub

    Private Sub Ordenes_Validar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EstrategiaDataSet.OM' Puede moverla o quitarla según sea necesario.
        Me.OMTableAdapter.Fill(Me.EstrategiaDataSet.OM)

        Dim myDataTable2 = OMTableAdapter.GetOTnumber("Diligenciada")
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
        If Cod_OTComboBox.Text <> Cod_OTTextBox.Text Then
            MsgBox("Discrepancia de Códigos")
        Else

            If MsgBox("Está seguro que Aprobar la OT: " & Cod_OTTextBox.Text, vbOKCancel, "Confirmación") = vbOK Then
                Try

                    Me.Validate()
                    Me.OMBindingSource.EndEdit()
                    Me.OMTableAdapter.UpdateRevisado("Revisada", Now.Date, Login.FullName, Cod_OTComboBox.Text)
                    MsgBox("OT Revisada Satisfactoriamente")
                    Me.Close()
                    Me.Dispose()
                    Ordenes.Show()
                Catch ex As Exception
                    MsgBox("Error en la creación de la OT")
                End Try
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Cod_OTComboBox.Text <> Cod_OTTextBox.Text Then
            MsgBox("Discrepancia de Códigos")
        Else
            If NotasTextBox.Text = "" Then
                MsgBox("Debe escribir notas de corrección")
            Else
                If MsgBox("Está seguro que Asignar a Corrección la OT: " & Cod_OTTextBox.Text, vbOKCancel, "Confirmación") = vbOK Then
                    Try

                        Me.Validate()
                        Me.OMBindingSource.EndEdit()
                        Me.OMTableAdapter.UpdateCorregir("Corregir-Programada", NotasTextBox.Text, Cod_OTComboBox.Text)
                        MsgBox("OT Asignada a Corrección Satisfactoriamente")
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Me.Dispose()
        Ordenes.Show()

    End Sub
End Class