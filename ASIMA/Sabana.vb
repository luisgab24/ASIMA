Public Class Sabana
    Dim oDocument As Object

    'Variable de tipo Aplicación de Excel  
    Dim objExcel As New Microsoft.Office.Interop.Excel.Application
    'Una variable de tipo Libro de Excel y hoja
    Dim xLibro As Microsoft.Office.Interop.Excel.Workbook
    Dim xHoja As Microsoft.Office.Interop.Excel.Worksheet
    'otras variables
    Dim cfamilias As Integer

    Private Sub Sabana_Load(sender As Object, e As EventArgs) Handles Me.Load




    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim archivo As String
        Dim existe As Boolean

        ''Usamos el método open para abrir el archivo que está en el directorio del programa llamado Taxonomia.xls  
        'xLibro = objExcel.Workbooks.Open(Application.StartupPath & "\Taxonomia.xlsx")
        ''Hacemos el Excel InVisible  
        'objExcel.Visible = False
        ''hacemos referencia a la hoja TAX
        'xHoja = xLibro.Sheets("TAX")

        archivo = Application.StartupPath & "\Geopark\Archivos\" & "Sabana.xlsx"
        existe = System.IO.File.Exists(archivo)

        If existe = True Then
            Try

                WebBrowser1.Navigate(archivo)
            Catch ex As Exception
                MsgBox("Archivo no encontrado")

            End Try
        Else
            MsgBox("Archivo no encontrado")


        End If

    End Sub
End Class