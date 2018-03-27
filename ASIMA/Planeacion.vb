Public Class Planeacion

    'Variable de tipo Aplicación de Excel  
    Dim objExcel As New Microsoft.Office.Interop.Excel.Application
    'Una variable de tipo Libro de Excel y hoja
    Dim xLibro As Microsoft.Office.Interop.Excel.Workbook
    Dim xHoja As Microsoft.Office.Interop.Excel.Worksheet


    Private Sub Button4_Click(sender As Object, e As EventArgs)

        Me.Close()
        Principal.Close()
        Dispose()
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Hide()
        Principal.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Rutinas.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Hide()
        Estrategia.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        'Sabana.Show()
        'Usamos el método open para abrir el archivo que está en el directorio del programa llamado Taxonomia.xls  
        xLibro = objExcel.Workbooks.Open(Application.StartupPath & "\Geopark\Archivos\" & "Sabana.xlsx")
        'Hacemos el Excel InVisible  
        objExcel.Visible = True
    End Sub

    Private Sub Planeacion_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim Principal As New Principal
        Principal.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Ordenes.Show()

    End Sub

    Private Sub Planeacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = Login.Role

        If Label1.Text = "Admin" Or Label1.Text = "Supervisor" Or Label1.Text = "Planeador" Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If
    End Sub
End Class