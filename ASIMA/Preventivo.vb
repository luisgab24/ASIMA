Public Class Preventivo
    'quitar bloton X
    Dim _enabledCerrar As Boolean = False
    <System.ComponentModel.DefaultValue(False), System.ComponentModel.Description("Define si se habilita el botón cerrar en el formulario")> _
    Public Property EnabledCerrar() As Boolean
        Get
            Return _enabledCerrar
        End Get
        Set(ByVal Value As Boolean)
            If _enabledCerrar <> Value Then
                _enabledCerrar = Value
            End If
        End Set
    End Property
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If _enabledCerrar = False Then
                Const CS_NOCLOSE As Integer = &H200
                cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            End If
            Return cp
        End Get
    End Property



    'Variable de tipo Aplicación de Excel  
    Dim objExcel As New Microsoft.Office.Interop.Excel.Application
    'Una variable de tipo Libro de Excel y hoja
    Dim xLibro As Microsoft.Office.Interop.Excel.Workbook
    Dim xHoja As Microsoft.Office.Interop.Excel.Worksheet
    'otras variables
    Dim cfamilias As Integer
    Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Usamos el método open para abrir el archivo que está en el directorio del programa llamado Taxonomia.xls  
        xLibro = objExcel.Workbooks.Open(Application.StartupPath & "\Taxonomia.xlsx")
        'Hacemos el Excel InVisible  
        objExcel.Visible = False
        'hacemos referencia a la hoja TAX
        xHoja = xLibro.Sheets("TAX")
        'posicionarse en celda a1 y contar familias
        Dim valor As String
        Dim Fila As Integer


        cfamilias = 0
        valor = xHoja.Cells.Item(2, 1).value

        'Obtenemos el numero de familias
        While valor <> ""
            cfamilias = cfamilias + 1
            valor = xHoja.Cells.Item(cfamilias + 2, 1).value
        End While

        'Recorremos la Columna 1 desde la 2 hasta cfamilias+2 
        For Fila = 2 To (cfamilias + 1)
            'Agregamos el valor de la fila que corresponde a la columna 1  
            ComboBox1.Items.Add(xHoja.Cells.Item(Fila, 1).value)
        Next

    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Dim Col As Integer, vFila As String, cfila As Integer

        ComboBox2.Items.Clear()
        cfila = 2

        'como ya sabemos el numero de familia buscams por columnas hasta encontrar la familia escogida
        For Col = 2 To (cfamilias + 1)
            If xHoja.Cells.Item(Col, 1).value = ComboBox1.Text Then
                vFila = xHoja.Cells.Item(cfila, Col).value

                While vFila <> ""
                    ComboBox2.Items.Add(vFila)
                    cfila = (cfila + 1)
                    vFila = xHoja.Cells.Item(cfila, Col).value

                End While
            End If

        Next

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim archivo As String
        Dim existe As Boolean

        archivo = Application.StartupPath & "\Procedimientos\Preventivo\" & ComboBox1.Text & "\" & ComboBox2.Text & ".pdf"
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

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        xLibro.Close(SaveChanges:=False)
        'Eliminamos los objetos si ya no los usamos  
        objExcel = Nothing
        xLibro = Nothing
        Dim Principal As New Principal
        Me.Close()
        Principal.Show()

    End Sub
End Class
