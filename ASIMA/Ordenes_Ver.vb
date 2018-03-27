Public Class Ordenes_Ver
    Private Sub OMBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OMBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EstrategiaDataSet)

    End Sub

    Private Sub Ordenes_Ver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EstrategiaDataSet.OM' Puede moverla o quitarla según sea necesario.
        Me.OMTableAdapter.Fill(Me.EstrategiaDataSet.OM)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()
        Ordenes.Show()
    End Sub

    Private Sub Ordenes_Ver_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
        Ordenes.Show()
    End Sub
End Class