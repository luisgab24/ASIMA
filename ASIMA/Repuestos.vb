Public Class Repuestos
    Private Sub RepuestosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RepuestosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RepuestosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EstrategiaDataSet)

    End Sub

    Private Sub Repuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EstrategiaDataSet.Repuestos' Puede moverla o quitarla según sea necesario.
        Me.RepuestosTableAdapter.Fill(Me.EstrategiaDataSet.Repuestos)

    End Sub
End Class