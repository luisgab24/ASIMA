Public Class MttoCorrectivo

    'Variable de tipo Aplicación de Excel  
    Dim objExcel As New Microsoft.Office.Interop.Excel.Application
    'Una variable de tipo Libro de Excel y hoja
    Dim xLibro As Microsoft.Office.Interop.Excel.Workbook
    Dim xHoja As Microsoft.Office.Interop.Excel.Worksheet



    Private Sub Button6_Click(sender As Object, e As EventArgs) 
        'Usamos el método open para abrir el archivo que está en el directorio del programa llamado Taxonomia.xls  
        xLibro = objExcel.Workbooks.Open(Application.StartupPath & "\Geopark\Archivos\" & "MinMax.xlsx")
        'Hacemos el Excel InVisible  
        objExcel.Visible = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Principal As New Principal
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        Me.Close()
        Principal.Close()
        Dispose()

        End
    End Sub

    Private Sub MttoCorrectivo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim Principal As New Principal
        Principal.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MFalla As New MFalla
        MFalla.Show()
    End Sub

    Private Sub MttoCorrectivo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = Login.FullName
    End Sub
End Class