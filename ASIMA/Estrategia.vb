Public Class Estrategia

    Private Sub Estrategia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EstrategiaDataSet.Estrategia_de_Mantenimiento' Puede moverla o quitarla según sea necesario.
        Me.Estrategia_de_MantenimientoTableAdapter.Fill(Me.EstrategiaDataSet.Estrategia_de_Mantenimiento)

    End Sub

    Private Sub Estrategia_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim Planeacion As New Planeacion
        Me.Dispose()
        Planeacion.Show()
    End Sub
End Class