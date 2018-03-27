<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordenes_Validar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PrioridadLabel As System.Windows.Forms.Label
        Dim OriginadorLabel As System.Windows.Forms.Label
        Dim Descripcion_ActividadLabel As System.Windows.Forms.Label
        Dim Duracion_planeadaLabel As System.Windows.Forms.Label
        Dim Fecha_ProgramadoLabel As System.Windows.Forms.Label
        Dim EspecialidadLabel As System.Windows.Forms.Label
        Dim Tipo_OTLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Unidad_NegocioLabel As System.Windows.Forms.Label
        Dim PlantaLabel As System.Windows.Forms.Label
        Dim SistemaLabel As System.Windows.Forms.Label
        Dim SubFuncionLabel As System.Windows.Forms.Label
        Dim Familia_EquipoLabel As System.Windows.Forms.Label
        Dim Tipo_EquipoLabel As System.Windows.Forms.Label
        Dim TAGLabel As System.Windows.Forms.Label
        Dim Como_quedoLabel As System.Windows.Forms.Label
        Dim Actividad_RealizadaLabel As System.Windows.Forms.Label
        Dim Como_encontroLabel As System.Windows.Forms.Label
        Dim Duracion_EjecucionLabel As System.Windows.Forms.Label
        Dim Horas_paroLabel As System.Windows.Forms.Label
        Dim Hora_Ejecucion_FinLabel As System.Windows.Forms.Label
        Dim Hora_Ejecucion_InicioLabel As System.Windows.Forms.Label
        Dim Fecha_Ejecucion_FinLabel As System.Windows.Forms.Label
        Dim Fecha_Ejecucion_InicioLabel As System.Windows.Forms.Label
        Dim Permiso_TrabajoLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim RecomendacionesLabel As System.Windows.Forms.Label
        Dim N_Articulo1Label As System.Windows.Forms.Label
        Dim ParteNumero1Label As System.Windows.Forms.Label
        Dim Unidad_Medida1Label As System.Windows.Forms.Label
        Dim Descripcion_Repuesto1Label As System.Windows.Forms.Label
        Dim Cantidad_Usada1Label As System.Windows.Forms.Label
        Dim Cantidad_Requerida1Label As System.Windows.Forms.Label
        Dim N_Requerimiento1Label As System.Windows.Forms.Label
        Dim Modo_de_Falla1Label As System.Windows.Forms.Label
        Dim Causa_MF1Label As System.Windows.Forms.Label
        Dim Tiempo_Fuera_Servicio1Label As System.Windows.Forms.Label
        Dim Tiempo_Reparacion1Label As System.Windows.Forms.Label
        Dim Afecta_Disponibilidad1Label As System.Windows.Forms.Label
        Dim NombreTecnico1Label As System.Windows.Forms.Label
        Dim CATMLabel As System.Windows.Forms.Label
        Dim DESPLabel As System.Windows.Forms.Label
        Dim PERMLabel As System.Windows.Forms.Label
        Dim AHERLabel As System.Windows.Forms.Label
        Dim OPUBLabel As System.Windows.Forms.Label
        Dim CSEGLabel As System.Windows.Forms.Label
        Dim DISPLabel As System.Windows.Forms.Label
        Dim HERRLabel As System.Windows.Forms.Label
        Dim REPULabel As System.Windows.Forms.Label
        Dim RECULabel As System.Windows.Forms.Label
        Dim CAPALabel As System.Windows.Forms.Label
        Dim AISLLabel As System.Windows.Forms.Label
        Dim DAUDLabel As System.Windows.Forms.Label
        Dim OTROLabel As System.Windows.Forms.Label
        Dim Tiempo_totalLabel As System.Windows.Forms.Label
        Dim Cargo1Label As System.Windows.Forms.Label
        Dim Especialidad1Label As System.Windows.Forms.Label
        Dim Fecha1Label As System.Windows.Forms.Label
        Dim Horas1Label As System.Windows.Forms.Label
        Dim Horas_Extra1Label As System.Windows.Forms.Label
        Dim Cod_OTLabel As System.Windows.Forms.Label
        Dim Tecnico_EjecutanteLabel As System.Windows.Forms.Label
        Dim Fecha_LlenadoLabel As System.Windows.Forms.Label
        Dim Fecha_ProgramadoLabel1 As System.Windows.Forms.Label
        Dim Fecha_CreacionLabel As System.Windows.Forms.Label
        Dim NotasLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ordenes_Validar))
        Me.OMBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.OMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstrategiaDataSet = New ASIMA.EstrategiaDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OMBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OriginadorTextBox = New System.Windows.Forms.TextBox()
        Me.PrioridadTextBox = New System.Windows.Forms.TextBox()
        Me.Descripcion_ActividadTextBox = New System.Windows.Forms.TextBox()
        Me.Duracion_planeadaNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Fecha_ProgramadoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TAGTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_EquipoTextBox = New System.Windows.Forms.TextBox()
        Me.Familia_EquipoTextBox = New System.Windows.Forms.TextBox()
        Me.SubFuncionTextBox = New System.Windows.Forms.TextBox()
        Me.SistemaTextBox = New System.Windows.Forms.TextBox()
        Me.PlantaTextBox = New System.Windows.Forms.TextBox()
        Me.Unidad_NegocioTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_OTTextBox = New System.Windows.Forms.TextBox()
        Me.EspecialidadTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_OTTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Como_quedoTextBox = New System.Windows.Forms.TextBox()
        Me.Actividad_RealizadaTextBox = New System.Windows.Forms.TextBox()
        Me.Como_encontroTextBox = New System.Windows.Forms.TextBox()
        Me.Duracion_EjecucionNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Horas_paroNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Hora_Ejecucion_FinDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Hora_Ejecucion_InicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_Ejecucion_FinDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_Ejecucion_InicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Permiso_TrabajoTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Modo_de_Falla2TextBox = New System.Windows.Forms.TextBox()
        Me.Modo_de_Falla1TextBox = New System.Windows.Forms.TextBox()
        Me.N_Articulo2TextBox = New System.Windows.Forms.TextBox()
        Me.ParteNumero2TextBox = New System.Windows.Forms.TextBox()
        Me.Unidad_Medida2TextBox = New System.Windows.Forms.TextBox()
        Me.Descripcion_Repuesto2TextBox = New System.Windows.Forms.TextBox()
        Me.Cantidad_Usada2NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Cantidad_Requerida2NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.N_Requerimiento2TextBox = New System.Windows.Forms.TextBox()
        Me.N_Articulo3TextBox = New System.Windows.Forms.TextBox()
        Me.ParteNumero3TextBox = New System.Windows.Forms.TextBox()
        Me.Unidad_Medida3TextBox = New System.Windows.Forms.TextBox()
        Me.Descripcion_Repuesto3TextBox = New System.Windows.Forms.TextBox()
        Me.Cantidad_Usada3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Cantidad_Requerida3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.N_Requerimiento3TextBox = New System.Windows.Forms.TextBox()
        Me.N_Articulo4TextBox = New System.Windows.Forms.TextBox()
        Me.ParteNumero4TextBox = New System.Windows.Forms.TextBox()
        Me.Unidad_Medida4TextBox = New System.Windows.Forms.TextBox()
        Me.Descripcion_Repuesto4TextBox = New System.Windows.Forms.TextBox()
        Me.Cantidad_Usada4NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Cantidad_Requerida4NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.N_Requerimiento4TextBox = New System.Windows.Forms.TextBox()
        Me.N_Articulo5TextBox = New System.Windows.Forms.TextBox()
        Me.ParteNumero5TextBox = New System.Windows.Forms.TextBox()
        Me.Unidad_Medida5TextBox = New System.Windows.Forms.TextBox()
        Me.Descripcion_Repuesto5TextBox = New System.Windows.Forms.TextBox()
        Me.Cantidad_Usada5NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Cantidad_Requerida5NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.N_Requerimiento5TextBox = New System.Windows.Forms.TextBox()
        Me.RecomendacionesTextBox = New System.Windows.Forms.TextBox()
        Me.N_Articulo1TextBox = New System.Windows.Forms.TextBox()
        Me.ParteNumero1TextBox = New System.Windows.Forms.TextBox()
        Me.Unidad_Medida1TextBox = New System.Windows.Forms.TextBox()
        Me.Descripcion_Repuesto1TextBox = New System.Windows.Forms.TextBox()
        Me.Cantidad_Usada1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Cantidad_Requerida1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.N_Requerimiento1TextBox = New System.Windows.Forms.TextBox()
        Me.Causa_MF1TextBox = New System.Windows.Forms.TextBox()
        Me.Tiempo_Fuera_Servicio1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Tiempo_Reparacion1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Afecta_Disponibilidad1CheckBox = New System.Windows.Forms.CheckBox()
        Me.Causa_MF2TextBox = New System.Windows.Forms.TextBox()
        Me.Tiempo_Fuera_Servicio2NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Tiempo_Reparacion2NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Afecta_Disponibilidad2CheckBox = New System.Windows.Forms.CheckBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.NombreTecnico6TextBox = New System.Windows.Forms.TextBox()
        Me.NombreTecnico5TextBox = New System.Windows.Forms.TextBox()
        Me.NombreTecnico4TextBox = New System.Windows.Forms.TextBox()
        Me.NombreTecnico3TextBox = New System.Windows.Forms.TextBox()
        Me.NombreTecnico2TextBox = New System.Windows.Forms.TextBox()
        Me.NombreTecnico1TextBox = New System.Windows.Forms.TextBox()
        Me.Especialidad6TextBox = New System.Windows.Forms.TextBox()
        Me.Cargo6TextBox = New System.Windows.Forms.TextBox()
        Me.Especialidad5TextBox = New System.Windows.Forms.TextBox()
        Me.Cargo5TextBox = New System.Windows.Forms.TextBox()
        Me.Especialidad4TextBox = New System.Windows.Forms.TextBox()
        Me.Cargo4TextBox = New System.Windows.Forms.TextBox()
        Me.Especialidad3TextBox = New System.Windows.Forms.TextBox()
        Me.Cargo3TextBox = New System.Windows.Forms.TextBox()
        Me.Especialidad2TextBox = New System.Windows.Forms.TextBox()
        Me.Cargo2TextBox = New System.Windows.Forms.TextBox()
        Me.Especialidad1TextBox = New System.Windows.Forms.TextBox()
        Me.Cargo1TextBox = New System.Windows.Forms.TextBox()
        Me.CATMNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.DESPNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.PERMNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AHERNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.OPUBNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CSEGNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.DISPNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.HERRNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.REPUNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.RECUNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CAPANumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AISLNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.DAUDNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.OTRONumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Tiempo_totalNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Fecha1DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Horas1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Horas_Extra1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Fecha2DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Horas2NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Horas_Extra2NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Fecha3DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Horas3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Horas_Extra3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Fecha4DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Horas4NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Horas_Extra4NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Fecha5DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Horas5NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Horas_Extra5NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Fecha6DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Horas6NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Horas_Extra6NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.NotasTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_CreacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_ProgramadoDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_LlenadoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tecnico_EjecutanteTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_OTComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OMTableAdapter = New ASIMA.EstrategiaDataSetTableAdapters.OMTableAdapter()
        Me.TableAdapterManager = New ASIMA.EstrategiaDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        PrioridadLabel = New System.Windows.Forms.Label()
        OriginadorLabel = New System.Windows.Forms.Label()
        Descripcion_ActividadLabel = New System.Windows.Forms.Label()
        Duracion_planeadaLabel = New System.Windows.Forms.Label()
        Fecha_ProgramadoLabel = New System.Windows.Forms.Label()
        EspecialidadLabel = New System.Windows.Forms.Label()
        Tipo_OTLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Unidad_NegocioLabel = New System.Windows.Forms.Label()
        PlantaLabel = New System.Windows.Forms.Label()
        SistemaLabel = New System.Windows.Forms.Label()
        SubFuncionLabel = New System.Windows.Forms.Label()
        Familia_EquipoLabel = New System.Windows.Forms.Label()
        Tipo_EquipoLabel = New System.Windows.Forms.Label()
        TAGLabel = New System.Windows.Forms.Label()
        Como_quedoLabel = New System.Windows.Forms.Label()
        Actividad_RealizadaLabel = New System.Windows.Forms.Label()
        Como_encontroLabel = New System.Windows.Forms.Label()
        Duracion_EjecucionLabel = New System.Windows.Forms.Label()
        Horas_paroLabel = New System.Windows.Forms.Label()
        Hora_Ejecucion_FinLabel = New System.Windows.Forms.Label()
        Hora_Ejecucion_InicioLabel = New System.Windows.Forms.Label()
        Fecha_Ejecucion_FinLabel = New System.Windows.Forms.Label()
        Fecha_Ejecucion_InicioLabel = New System.Windows.Forms.Label()
        Permiso_TrabajoLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        RecomendacionesLabel = New System.Windows.Forms.Label()
        N_Articulo1Label = New System.Windows.Forms.Label()
        ParteNumero1Label = New System.Windows.Forms.Label()
        Unidad_Medida1Label = New System.Windows.Forms.Label()
        Descripcion_Repuesto1Label = New System.Windows.Forms.Label()
        Cantidad_Usada1Label = New System.Windows.Forms.Label()
        Cantidad_Requerida1Label = New System.Windows.Forms.Label()
        N_Requerimiento1Label = New System.Windows.Forms.Label()
        Modo_de_Falla1Label = New System.Windows.Forms.Label()
        Causa_MF1Label = New System.Windows.Forms.Label()
        Tiempo_Fuera_Servicio1Label = New System.Windows.Forms.Label()
        Tiempo_Reparacion1Label = New System.Windows.Forms.Label()
        Afecta_Disponibilidad1Label = New System.Windows.Forms.Label()
        NombreTecnico1Label = New System.Windows.Forms.Label()
        CATMLabel = New System.Windows.Forms.Label()
        DESPLabel = New System.Windows.Forms.Label()
        PERMLabel = New System.Windows.Forms.Label()
        AHERLabel = New System.Windows.Forms.Label()
        OPUBLabel = New System.Windows.Forms.Label()
        CSEGLabel = New System.Windows.Forms.Label()
        DISPLabel = New System.Windows.Forms.Label()
        HERRLabel = New System.Windows.Forms.Label()
        REPULabel = New System.Windows.Forms.Label()
        RECULabel = New System.Windows.Forms.Label()
        CAPALabel = New System.Windows.Forms.Label()
        AISLLabel = New System.Windows.Forms.Label()
        DAUDLabel = New System.Windows.Forms.Label()
        OTROLabel = New System.Windows.Forms.Label()
        Tiempo_totalLabel = New System.Windows.Forms.Label()
        Cargo1Label = New System.Windows.Forms.Label()
        Especialidad1Label = New System.Windows.Forms.Label()
        Fecha1Label = New System.Windows.Forms.Label()
        Horas1Label = New System.Windows.Forms.Label()
        Horas_Extra1Label = New System.Windows.Forms.Label()
        Cod_OTLabel = New System.Windows.Forms.Label()
        Tecnico_EjecutanteLabel = New System.Windows.Forms.Label()
        Fecha_LlenadoLabel = New System.Windows.Forms.Label()
        Fecha_ProgramadoLabel1 = New System.Windows.Forms.Label()
        Fecha_CreacionLabel = New System.Windows.Forms.Label()
        NotasLabel = New System.Windows.Forms.Label()
        CType(Me.OMBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OMBindingNavigator.SuspendLayout()
        CType(Me.OMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstrategiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Duracion_planeadaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Duracion_EjecucionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas_paroNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Cantidad_Usada2NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cantidad_Requerida2NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cantidad_Usada3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cantidad_Requerida3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cantidad_Usada4NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cantidad_Requerida4NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cantidad_Usada5NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cantidad_Requerida5NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cantidad_Usada1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cantidad_Requerida1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tiempo_Fuera_Servicio1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tiempo_Reparacion1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tiempo_Fuera_Servicio2NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tiempo_Reparacion2NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.CATMNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DESPNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERMNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AHERNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPUBNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSEGNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DISPNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HERRNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPUNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECUNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAPANumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AISLNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAUDNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTRONumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tiempo_totalNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas_Extra1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas2NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas_Extra2NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas_Extra3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas4NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas_Extra4NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas5NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas_Extra5NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas6NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas_Extra6NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrioridadLabel
        '
        PrioridadLabel.AutoSize = True
        PrioridadLabel.Location = New System.Drawing.Point(6, 22)
        PrioridadLabel.Name = "PrioridadLabel"
        PrioridadLabel.Size = New System.Drawing.Size(51, 13)
        PrioridadLabel.TabIndex = 23
        PrioridadLabel.Text = "Prioridad:"
        '
        'OriginadorLabel
        '
        OriginadorLabel.AutoSize = True
        OriginadorLabel.Location = New System.Drawing.Point(360, 22)
        OriginadorLabel.Name = "OriginadorLabel"
        OriginadorLabel.Size = New System.Drawing.Size(58, 13)
        OriginadorLabel.TabIndex = 25
        OriginadorLabel.Text = "Originador:"
        '
        'Descripcion_ActividadLabel
        '
        Descripcion_ActividadLabel.AutoSize = True
        Descripcion_ActividadLabel.Location = New System.Drawing.Point(6, 49)
        Descripcion_ActividadLabel.Name = "Descripcion_ActividadLabel"
        Descripcion_ActividadLabel.Size = New System.Drawing.Size(113, 13)
        Descripcion_ActividadLabel.TabIndex = 27
        Descripcion_ActividadLabel.Text = "Descripcion Actividad:"
        '
        'Duracion_planeadaLabel
        '
        Duracion_planeadaLabel.AutoSize = True
        Duracion_planeadaLabel.Location = New System.Drawing.Point(6, 112)
        Duracion_planeadaLabel.Name = "Duracion_planeadaLabel"
        Duracion_planeadaLabel.Size = New System.Drawing.Size(100, 13)
        Duracion_planeadaLabel.TabIndex = 29
        Duracion_planeadaLabel.Text = "Duracion planeada:"
        '
        'Fecha_ProgramadoLabel
        '
        Fecha_ProgramadoLabel.AutoSize = True
        Fecha_ProgramadoLabel.Location = New System.Drawing.Point(318, 114)
        Fecha_ProgramadoLabel.Name = "Fecha_ProgramadoLabel"
        Fecha_ProgramadoLabel.Size = New System.Drawing.Size(100, 13)
        Fecha_ProgramadoLabel.TabIndex = 33
        Fecha_ProgramadoLabel.Text = "Fecha Programado:"
        '
        'EspecialidadLabel
        '
        EspecialidadLabel.AutoSize = True
        EspecialidadLabel.Location = New System.Drawing.Point(6, 25)
        EspecialidadLabel.Name = "EspecialidadLabel"
        EspecialidadLabel.Size = New System.Drawing.Size(70, 13)
        EspecialidadLabel.TabIndex = 3
        EspecialidadLabel.Text = "Especialidad:"
        '
        'Tipo_OTLabel
        '
        Tipo_OTLabel.AutoSize = True
        Tipo_OTLabel.Location = New System.Drawing.Point(6, 52)
        Tipo_OTLabel.Name = "Tipo_OTLabel"
        Tipo_OTLabel.Size = New System.Drawing.Size(49, 13)
        Tipo_OTLabel.TabIndex = 5
        Tipo_OTLabel.Text = "Tipo OT:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(6, 79)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(47, 13)
        Label1.TabIndex = 7
        Label1.Text = "Cod OT:"
        '
        'Unidad_NegocioLabel
        '
        Unidad_NegocioLabel.AutoSize = True
        Unidad_NegocioLabel.Location = New System.Drawing.Point(6, 105)
        Unidad_NegocioLabel.Name = "Unidad_NegocioLabel"
        Unidad_NegocioLabel.Size = New System.Drawing.Size(87, 13)
        Unidad_NegocioLabel.TabIndex = 9
        Unidad_NegocioLabel.Text = "Unidad Negocio:"
        '
        'PlantaLabel
        '
        PlantaLabel.AutoSize = True
        PlantaLabel.Location = New System.Drawing.Point(6, 132)
        PlantaLabel.Name = "PlantaLabel"
        PlantaLabel.Size = New System.Drawing.Size(40, 13)
        PlantaLabel.TabIndex = 11
        PlantaLabel.Text = "Planta:"
        '
        'SistemaLabel
        '
        SistemaLabel.AutoSize = True
        SistemaLabel.Location = New System.Drawing.Point(276, 25)
        SistemaLabel.Name = "SistemaLabel"
        SistemaLabel.Size = New System.Drawing.Size(47, 13)
        SistemaLabel.TabIndex = 13
        SistemaLabel.Text = "Sistema:"
        '
        'SubFuncionLabel
        '
        SubFuncionLabel.AutoSize = True
        SubFuncionLabel.Location = New System.Drawing.Point(276, 52)
        SubFuncionLabel.Name = "SubFuncionLabel"
        SubFuncionLabel.Size = New System.Drawing.Size(70, 13)
        SubFuncionLabel.TabIndex = 15
        SubFuncionLabel.Text = "Sub Funcion:"
        '
        'Familia_EquipoLabel
        '
        Familia_EquipoLabel.AutoSize = True
        Familia_EquipoLabel.Location = New System.Drawing.Point(276, 79)
        Familia_EquipoLabel.Name = "Familia_EquipoLabel"
        Familia_EquipoLabel.Size = New System.Drawing.Size(78, 13)
        Familia_EquipoLabel.TabIndex = 17
        Familia_EquipoLabel.Text = "Familia Equipo:"
        '
        'Tipo_EquipoLabel
        '
        Tipo_EquipoLabel.AutoSize = True
        Tipo_EquipoLabel.Location = New System.Drawing.Point(276, 106)
        Tipo_EquipoLabel.Name = "Tipo_EquipoLabel"
        Tipo_EquipoLabel.Size = New System.Drawing.Size(67, 13)
        Tipo_EquipoLabel.TabIndex = 19
        Tipo_EquipoLabel.Text = "Tipo Equipo:"
        '
        'TAGLabel
        '
        TAGLabel.AutoSize = True
        TAGLabel.Location = New System.Drawing.Point(276, 133)
        TAGLabel.Name = "TAGLabel"
        TAGLabel.Size = New System.Drawing.Size(32, 13)
        TAGLabel.TabIndex = 21
        TAGLabel.Text = "TAG:"
        '
        'Como_quedoLabel
        '
        Como_quedoLabel.AutoSize = True
        Como_quedoLabel.Location = New System.Drawing.Point(29, 311)
        Como_quedoLabel.Name = "Como_quedoLabel"
        Como_quedoLabel.Size = New System.Drawing.Size(70, 13)
        Como_quedoLabel.TabIndex = 18
        Como_quedoLabel.Text = "Como quedo:"
        '
        'Actividad_RealizadaLabel
        '
        Actividad_RealizadaLabel.AutoSize = True
        Actividad_RealizadaLabel.Location = New System.Drawing.Point(6, 209)
        Actividad_RealizadaLabel.Name = "Actividad_RealizadaLabel"
        Actividad_RealizadaLabel.Size = New System.Drawing.Size(104, 13)
        Actividad_RealizadaLabel.TabIndex = 16
        Actividad_RealizadaLabel.Text = "Actividad Realizada:"
        '
        'Como_encontroLabel
        '
        Como_encontroLabel.AutoSize = True
        Como_encontroLabel.Location = New System.Drawing.Point(6, 131)
        Como_encontroLabel.Name = "Como_encontroLabel"
        Como_encontroLabel.Size = New System.Drawing.Size(82, 13)
        Como_encontroLabel.TabIndex = 14
        Como_encontroLabel.Text = "Como encontro:"
        '
        'Duracion_EjecucionLabel
        '
        Duracion_EjecucionLabel.AutoSize = True
        Duracion_EjecucionLabel.Location = New System.Drawing.Point(365, 104)
        Duracion_EjecucionLabel.Name = "Duracion_EjecucionLabel"
        Duracion_EjecucionLabel.Size = New System.Drawing.Size(103, 13)
        Duracion_EjecucionLabel.TabIndex = 12
        Duracion_EjecucionLabel.Text = "Duracion Ejecucion:"
        '
        'Horas_paroLabel
        '
        Horas_paroLabel.AutoSize = True
        Horas_paroLabel.Location = New System.Drawing.Point(75, 106)
        Horas_paroLabel.Name = "Horas_paroLabel"
        Horas_paroLabel.Size = New System.Drawing.Size(62, 13)
        Horas_paroLabel.TabIndex = 10
        Horas_paroLabel.Text = "Horas paro:"
        '
        'Hora_Ejecucion_FinLabel
        '
        Hora_Ejecucion_FinLabel.AutoSize = True
        Hora_Ejecucion_FinLabel.Location = New System.Drawing.Point(368, 80)
        Hora_Ejecucion_FinLabel.Name = "Hora_Ejecucion_FinLabel"
        Hora_Ejecucion_FinLabel.Size = New System.Drawing.Size(100, 13)
        Hora_Ejecucion_FinLabel.TabIndex = 8
        Hora_Ejecucion_FinLabel.Text = "Hora Ejecucion Fin:"
        '
        'Hora_Ejecucion_InicioLabel
        '
        Hora_Ejecucion_InicioLabel.AutoSize = True
        Hora_Ejecucion_InicioLabel.Location = New System.Drawing.Point(357, 54)
        Hora_Ejecucion_InicioLabel.Name = "Hora_Ejecucion_InicioLabel"
        Hora_Ejecucion_InicioLabel.Size = New System.Drawing.Size(111, 13)
        Hora_Ejecucion_InicioLabel.TabIndex = 6
        Hora_Ejecucion_InicioLabel.Text = "Hora Ejecucion Inicio:"
        '
        'Fecha_Ejecucion_FinLabel
        '
        Fecha_Ejecucion_FinLabel.AutoSize = True
        Fecha_Ejecucion_FinLabel.Location = New System.Drawing.Point(30, 82)
        Fecha_Ejecucion_FinLabel.Name = "Fecha_Ejecucion_FinLabel"
        Fecha_Ejecucion_FinLabel.Size = New System.Drawing.Size(107, 13)
        Fecha_Ejecucion_FinLabel.TabIndex = 4
        Fecha_Ejecucion_FinLabel.Text = "Fecha Ejecucion Fin:"
        '
        'Fecha_Ejecucion_InicioLabel
        '
        Fecha_Ejecucion_InicioLabel.AutoSize = True
        Fecha_Ejecucion_InicioLabel.Location = New System.Drawing.Point(19, 56)
        Fecha_Ejecucion_InicioLabel.Name = "Fecha_Ejecucion_InicioLabel"
        Fecha_Ejecucion_InicioLabel.Size = New System.Drawing.Size(118, 13)
        Fecha_Ejecucion_InicioLabel.TabIndex = 2
        Fecha_Ejecucion_InicioLabel.Text = "Fecha Ejecucion Inicio:"
        '
        'Permiso_TrabajoLabel
        '
        Permiso_TrabajoLabel.AutoSize = True
        Permiso_TrabajoLabel.Location = New System.Drawing.Point(6, 16)
        Permiso_TrabajoLabel.Name = "Permiso_TrabajoLabel"
        Permiso_TrabajoLabel.Size = New System.Drawing.Size(86, 13)
        Permiso_TrabajoLabel.TabIndex = 0
        Permiso_TrabajoLabel.Text = "Permiso Trabajo:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(620, 274)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(75, 13)
        Label7.TabIndex = 327
        Label7.Text = "Disponibilidad:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(562, 274)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(65, 13)
        Label6.TabIndex = 326
        Label6.Text = "Reparacion:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(519, 274)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(45, 13)
        Label5.TabIndex = 325
        Label5.Text = "Servicio"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(523, 261)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(37, 13)
        Label4.TabIndex = 324
        Label4.Text = "Fuera "
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(542, 88)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(52, 13)
        Label3.TabIndex = 267
        Label3.Text = "Cantidad "
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(492, 104)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(38, 13)
        Label2.TabIndex = 266
        Label2.Text = "Usada"
        '
        'RecomendacionesLabel
        '
        RecomendacionesLabel.AutoSize = True
        RecomendacionesLabel.Location = New System.Drawing.Point(18, 16)
        RecomendacionesLabel.Name = "RecomendacionesLabel"
        RecomendacionesLabel.Size = New System.Drawing.Size(99, 13)
        RecomendacionesLabel.TabIndex = 54
        RecomendacionesLabel.Text = "Recomendaciones:"
        '
        'N_Articulo1Label
        '
        N_Articulo1Label.AutoSize = True
        N_Articulo1Label.Location = New System.Drawing.Point(8, 104)
        N_Articulo1Label.Name = "N_Articulo1Label"
        N_Articulo1Label.Size = New System.Drawing.Size(62, 13)
        N_Articulo1Label.TabIndex = 56
        N_Articulo1Label.Text = "N Articulo1:"
        '
        'ParteNumero1Label
        '
        ParteNumero1Label.AutoSize = True
        ParteNumero1Label.Location = New System.Drawing.Point(92, 104)
        ParteNumero1Label.Name = "ParteNumero1Label"
        ParteNumero1Label.Size = New System.Drawing.Size(81, 13)
        ParteNumero1Label.TabIndex = 58
        ParteNumero1Label.Text = "Parte Numero1:"
        '
        'Unidad_Medida1Label
        '
        Unidad_Medida1Label.AutoSize = True
        Unidad_Medida1Label.Location = New System.Drawing.Point(196, 104)
        Unidad_Medida1Label.Name = "Unidad_Medida1Label"
        Unidad_Medida1Label.Size = New System.Drawing.Size(70, 13)
        Unidad_Medida1Label.TabIndex = 60
        Unidad_Medida1Label.Text = "Unid. Medida"
        '
        'Descripcion_Repuesto1Label
        '
        Descripcion_Repuesto1Label.AutoSize = True
        Descripcion_Repuesto1Label.Location = New System.Drawing.Point(271, 104)
        Descripcion_Repuesto1Label.Name = "Descripcion_Repuesto1Label"
        Descripcion_Repuesto1Label.Size = New System.Drawing.Size(115, 13)
        Descripcion_Repuesto1Label.TabIndex = 62
        Descripcion_Repuesto1Label.Text = "Descripcion Repuesto:"
        '
        'Cantidad_Usada1Label
        '
        Cantidad_Usada1Label.AutoSize = True
        Cantidad_Usada1Label.Location = New System.Drawing.Point(487, 88)
        Cantidad_Usada1Label.Name = "Cantidad_Usada1Label"
        Cantidad_Usada1Label.Size = New System.Drawing.Size(52, 13)
        Cantidad_Usada1Label.TabIndex = 64
        Cantidad_Usada1Label.Text = "Cantidad "
        '
        'Cantidad_Requerida1Label
        '
        Cantidad_Requerida1Label.AutoSize = True
        Cantidad_Requerida1Label.Location = New System.Drawing.Point(538, 104)
        Cantidad_Requerida1Label.Name = "Cantidad_Requerida1Label"
        Cantidad_Requerida1Label.Size = New System.Drawing.Size(59, 13)
        Cantidad_Requerida1Label.TabIndex = 66
        Cantidad_Requerida1Label.Text = "Requerida:"
        '
        'N_Requerimiento1Label
        '
        N_Requerimiento1Label.AutoSize = True
        N_Requerimiento1Label.Location = New System.Drawing.Point(597, 103)
        N_Requerimiento1Label.Name = "N_Requerimiento1Label"
        N_Requerimiento1Label.Size = New System.Drawing.Size(89, 13)
        N_Requerimiento1Label.TabIndex = 68
        N_Requerimiento1Label.Text = "N Requerimiento:"
        '
        'Modo_de_Falla1Label
        '
        Modo_de_Falla1Label.AutoSize = True
        Modo_de_Falla1Label.Location = New System.Drawing.Point(8, 277)
        Modo_de_Falla1Label.Name = "Modo_de_Falla1Label"
        Modo_de_Falla1Label.Size = New System.Drawing.Size(83, 13)
        Modo_de_Falla1Label.TabIndex = 126
        Modo_de_Falla1Label.Text = "Modo de Falla1:"
        '
        'Causa_MF1Label
        '
        Causa_MF1Label.AutoSize = True
        Causa_MF1Label.Location = New System.Drawing.Point(204, 277)
        Causa_MF1Label.Name = "Causa_MF1Label"
        Causa_MF1Label.Size = New System.Drawing.Size(64, 13)
        Causa_MF1Label.TabIndex = 128
        Causa_MF1Label.Text = "Causa MF1:"
        '
        'Tiempo_Fuera_Servicio1Label
        '
        Tiempo_Fuera_Servicio1Label.AutoSize = True
        Tiempo_Fuera_Servicio1Label.Location = New System.Drawing.Point(520, 248)
        Tiempo_Fuera_Servicio1Label.Name = "Tiempo_Fuera_Servicio1Label"
        Tiempo_Fuera_Servicio1Label.Size = New System.Drawing.Size(42, 13)
        Tiempo_Fuera_Servicio1Label.TabIndex = 130
        Tiempo_Fuera_Servicio1Label.Text = "Tiempo"
        '
        'Tiempo_Reparacion1Label
        '
        Tiempo_Reparacion1Label.AutoSize = True
        Tiempo_Reparacion1Label.Location = New System.Drawing.Point(573, 261)
        Tiempo_Reparacion1Label.Name = "Tiempo_Reparacion1Label"
        Tiempo_Reparacion1Label.Size = New System.Drawing.Size(42, 13)
        Tiempo_Reparacion1Label.TabIndex = 132
        Tiempo_Reparacion1Label.Text = "Tiempo"
        '
        'Afecta_Disponibilidad1Label
        '
        Afecta_Disponibilidad1Label.AutoSize = True
        Afecta_Disponibilidad1Label.Location = New System.Drawing.Point(638, 261)
        Afecta_Disponibilidad1Label.Name = "Afecta_Disponibilidad1Label"
        Afecta_Disponibilidad1Label.Size = New System.Drawing.Size(38, 13)
        Afecta_Disponibilidad1Label.TabIndex = 134
        Afecta_Disponibilidad1Label.Text = "Afecta"
        '
        'NombreTecnico1Label
        '
        NombreTecnico1Label.AutoSize = True
        NombreTecnico1Label.Location = New System.Drawing.Point(12, 15)
        NombreTecnico1Label.Name = "NombreTecnico1Label"
        NombreTecnico1Label.Size = New System.Drawing.Size(89, 13)
        NombreTecnico1Label.TabIndex = 392
        NombreTecnico1Label.Text = "Nombre Tecnico:"
        '
        'CATMLabel
        '
        CATMLabel.AutoSize = True
        CATMLabel.Location = New System.Drawing.Point(20, 198)
        CATMLabel.Name = "CATMLabel"
        CATMLabel.Size = New System.Drawing.Size(40, 13)
        CATMLabel.TabIndex = 362
        CATMLabel.Text = "CATM:"
        '
        'DESPLabel
        '
        DESPLabel.AutoSize = True
        DESPLabel.Location = New System.Drawing.Point(20, 225)
        DESPLabel.Name = "DESPLabel"
        DESPLabel.Size = New System.Drawing.Size(39, 13)
        DESPLabel.TabIndex = 364
        DESPLabel.Text = "DESP:"
        '
        'PERMLabel
        '
        PERMLabel.AutoSize = True
        PERMLabel.Location = New System.Drawing.Point(20, 251)
        PERMLabel.Name = "PERMLabel"
        PERMLabel.Size = New System.Drawing.Size(41, 13)
        PERMLabel.TabIndex = 366
        PERMLabel.Text = "PERM:"
        '
        'AHERLabel
        '
        AHERLabel.AutoSize = True
        AHERLabel.Location = New System.Drawing.Point(20, 277)
        AHERLabel.Name = "AHERLabel"
        AHERLabel.Size = New System.Drawing.Size(40, 13)
        AHERLabel.TabIndex = 368
        AHERLabel.Text = "AHER:"
        '
        'OPUBLabel
        '
        OPUBLabel.AutoSize = True
        OPUBLabel.Location = New System.Drawing.Point(20, 303)
        OPUBLabel.Name = "OPUBLabel"
        OPUBLabel.Size = New System.Drawing.Size(40, 13)
        OPUBLabel.TabIndex = 370
        OPUBLabel.Text = "OPUB:"
        '
        'CSEGLabel
        '
        CSEGLabel.AutoSize = True
        CSEGLabel.Location = New System.Drawing.Point(265, 199)
        CSEGLabel.Name = "CSEGLabel"
        CSEGLabel.Size = New System.Drawing.Size(39, 13)
        CSEGLabel.TabIndex = 372
        CSEGLabel.Text = "CSEG:"
        '
        'DISPLabel
        '
        DISPLabel.AutoSize = True
        DISPLabel.Location = New System.Drawing.Point(265, 225)
        DISPLabel.Name = "DISPLabel"
        DISPLabel.Size = New System.Drawing.Size(35, 13)
        DISPLabel.TabIndex = 374
        DISPLabel.Text = "DISP:"
        '
        'HERRLabel
        '
        HERRLabel.AutoSize = True
        HERRLabel.Location = New System.Drawing.Point(265, 251)
        HERRLabel.Name = "HERRLabel"
        HERRLabel.Size = New System.Drawing.Size(41, 13)
        HERRLabel.TabIndex = 376
        HERRLabel.Text = "HERR:"
        '
        'REPULabel
        '
        REPULabel.AutoSize = True
        REPULabel.Location = New System.Drawing.Point(265, 277)
        REPULabel.Name = "REPULabel"
        REPULabel.Size = New System.Drawing.Size(40, 13)
        REPULabel.TabIndex = 378
        REPULabel.Text = "REPU:"
        '
        'RECULabel
        '
        RECULabel.AutoSize = True
        RECULabel.Location = New System.Drawing.Point(265, 303)
        RECULabel.Name = "RECULabel"
        RECULabel.Size = New System.Drawing.Size(40, 13)
        RECULabel.TabIndex = 380
        RECULabel.Text = "RECU:"
        '
        'CAPALabel
        '
        CAPALabel.AutoSize = True
        CAPALabel.Location = New System.Drawing.Point(493, 197)
        CAPALabel.Name = "CAPALabel"
        CAPALabel.Size = New System.Drawing.Size(38, 13)
        CAPALabel.TabIndex = 382
        CAPALabel.Text = "CAPA:"
        '
        'AISLLabel
        '
        AISLLabel.AutoSize = True
        AISLLabel.Location = New System.Drawing.Point(493, 223)
        AISLLabel.Name = "AISLLabel"
        AISLLabel.Size = New System.Drawing.Size(33, 13)
        AISLLabel.TabIndex = 384
        AISLLabel.Text = "AISL:"
        '
        'DAUDLabel
        '
        DAUDLabel.AutoSize = True
        DAUDLabel.Location = New System.Drawing.Point(493, 249)
        DAUDLabel.Name = "DAUDLabel"
        DAUDLabel.Size = New System.Drawing.Size(41, 13)
        DAUDLabel.TabIndex = 386
        DAUDLabel.Text = "DAUD:"
        '
        'OTROLabel
        '
        OTROLabel.AutoSize = True
        OTROLabel.Location = New System.Drawing.Point(493, 275)
        OTROLabel.Name = "OTROLabel"
        OTROLabel.Size = New System.Drawing.Size(41, 13)
        OTROLabel.TabIndex = 388
        OTROLabel.Text = "OTRO:"
        '
        'Tiempo_totalLabel
        '
        Tiempo_totalLabel.AutoSize = True
        Tiempo_totalLabel.Location = New System.Drawing.Point(493, 301)
        Tiempo_totalLabel.Name = "Tiempo_totalLabel"
        Tiempo_totalLabel.Size = New System.Drawing.Size(68, 13)
        Tiempo_totalLabel.TabIndex = 390
        Tiempo_totalLabel.Text = "Tiempo total:"
        '
        'Cargo1Label
        '
        Cargo1Label.AutoSize = True
        Cargo1Label.Location = New System.Drawing.Point(220, 13)
        Cargo1Label.Name = "Cargo1Label"
        Cargo1Label.Size = New System.Drawing.Size(38, 13)
        Cargo1Label.TabIndex = 290
        Cargo1Label.Text = "Cargo:"
        '
        'Especialidad1Label
        '
        Especialidad1Label.AutoSize = True
        Especialidad1Label.Location = New System.Drawing.Point(355, 13)
        Especialidad1Label.Name = "Especialidad1Label"
        Especialidad1Label.Size = New System.Drawing.Size(70, 13)
        Especialidad1Label.TabIndex = 292
        Especialidad1Label.Text = "Especialidad:"
        '
        'Fecha1Label
        '
        Fecha1Label.AutoSize = True
        Fecha1Label.Location = New System.Drawing.Point(465, 13)
        Fecha1Label.Name = "Fecha1Label"
        Fecha1Label.Size = New System.Drawing.Size(46, 13)
        Fecha1Label.TabIndex = 296
        Fecha1Label.Text = "Fecha1:"
        '
        'Horas1Label
        '
        Horas1Label.AutoSize = True
        Horas1Label.Location = New System.Drawing.Point(563, 13)
        Horas1Label.Name = "Horas1Label"
        Horas1Label.Size = New System.Drawing.Size(44, 13)
        Horas1Label.TabIndex = 298
        Horas1Label.Text = "Horas1:"
        '
        'Horas_Extra1Label
        '
        Horas_Extra1Label.AutoSize = True
        Horas_Extra1Label.Location = New System.Drawing.Point(617, 13)
        Horas_Extra1Label.Name = "Horas_Extra1Label"
        Horas_Extra1Label.Size = New System.Drawing.Size(71, 13)
        Horas_Extra1Label.TabIndex = 300
        Horas_Extra1Label.Text = "Horas Extra1:"
        '
        'Cod_OTLabel
        '
        Cod_OTLabel.AutoSize = True
        Cod_OTLabel.Location = New System.Drawing.Point(13, 65)
        Cod_OTLabel.Name = "Cod_OTLabel"
        Cod_OTLabel.Size = New System.Drawing.Size(47, 13)
        Cod_OTLabel.TabIndex = 2
        Cod_OTLabel.Text = "Cod OT:"
        '
        'Tecnico_EjecutanteLabel
        '
        Tecnico_EjecutanteLabel.AutoSize = True
        Tecnico_EjecutanteLabel.Location = New System.Drawing.Point(14, 53)
        Tecnico_EjecutanteLabel.Name = "Tecnico_EjecutanteLabel"
        Tecnico_EjecutanteLabel.Size = New System.Drawing.Size(103, 13)
        Tecnico_EjecutanteLabel.TabIndex = 0
        Tecnico_EjecutanteLabel.Text = "Tecnico Ejecutante:"
        '
        'Fecha_LlenadoLabel
        '
        Fecha_LlenadoLabel.AutoSize = True
        Fecha_LlenadoLabel.Location = New System.Drawing.Point(36, 167)
        Fecha_LlenadoLabel.Name = "Fecha_LlenadoLabel"
        Fecha_LlenadoLabel.Size = New System.Drawing.Size(81, 13)
        Fecha_LlenadoLabel.TabIndex = 2
        Fecha_LlenadoLabel.Text = "Fecha Llenado:"
        '
        'Fecha_ProgramadoLabel1
        '
        Fecha_ProgramadoLabel1.AutoSize = True
        Fecha_ProgramadoLabel1.Location = New System.Drawing.Point(17, 131)
        Fecha_ProgramadoLabel1.Name = "Fecha_ProgramadoLabel1"
        Fecha_ProgramadoLabel1.Size = New System.Drawing.Size(100, 13)
        Fecha_ProgramadoLabel1.TabIndex = 4
        Fecha_ProgramadoLabel1.Text = "Fecha Programado:"
        '
        'Fecha_CreacionLabel
        '
        Fecha_CreacionLabel.AutoSize = True
        Fecha_CreacionLabel.Location = New System.Drawing.Point(32, 95)
        Fecha_CreacionLabel.Name = "Fecha_CreacionLabel"
        Fecha_CreacionLabel.Size = New System.Drawing.Size(85, 13)
        Fecha_CreacionLabel.TabIndex = 6
        Fecha_CreacionLabel.Text = "Fecha Creacion:"
        '
        'NotasLabel
        '
        NotasLabel.AutoSize = True
        NotasLabel.Location = New System.Drawing.Point(6, 254)
        NotasLabel.Name = "NotasLabel"
        NotasLabel.Size = New System.Drawing.Size(38, 13)
        NotasLabel.TabIndex = 284
        NotasLabel.Text = "Notas:"
        '
        'OMBindingNavigator
        '
        Me.OMBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OMBindingNavigator.BindingSource = Me.OMBindingSource
        Me.OMBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OMBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OMBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OMBindingNavigatorSaveItem})
        Me.OMBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OMBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OMBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OMBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OMBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OMBindingNavigator.Name = "OMBindingNavigator"
        Me.OMBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OMBindingNavigator.Size = New System.Drawing.Size(768, 25)
        Me.OMBindingNavigator.TabIndex = 0
        Me.OMBindingNavigator.Text = "BindingNavigator1"
        Me.OMBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'OMBindingSource
        '
        Me.OMBindingSource.DataMember = "OM"
        Me.OMBindingSource.DataSource = Me.EstrategiaDataSet
        '
        'EstrategiaDataSet
        '
        Me.EstrategiaDataSet.DataSetName = "EstrategiaDataSet"
        Me.EstrategiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'OMBindingNavigatorSaveItem
        '
        Me.OMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OMBindingNavigatorSaveItem.Image = CType(resources.GetObject("OMBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OMBindingNavigatorSaveItem.Name = "OMBindingNavigatorSaveItem"
        Me.OMBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OMBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 89)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(726, 422)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(718, 396)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos OT"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OriginadorTextBox)
        Me.GroupBox2.Controls.Add(Me.PrioridadTextBox)
        Me.GroupBox2.Controls.Add(PrioridadLabel)
        Me.GroupBox2.Controls.Add(OriginadorLabel)
        Me.GroupBox2.Controls.Add(Descripcion_ActividadLabel)
        Me.GroupBox2.Controls.Add(Me.Descripcion_ActividadTextBox)
        Me.GroupBox2.Controls.Add(Duracion_planeadaLabel)
        Me.GroupBox2.Controls.Add(Me.Duracion_planeadaNumericUpDown)
        Me.GroupBox2.Controls.Add(Fecha_ProgramadoLabel)
        Me.GroupBox2.Controls.Add(Me.Fecha_ProgramadoDateTimePicker)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 157)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'OriginadorTextBox
        '
        Me.OriginadorTextBox.BackColor = System.Drawing.Color.White
        Me.OriginadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Originador", True))
        Me.OriginadorTextBox.Location = New System.Drawing.Point(424, 19)
        Me.OriginadorTextBox.Name = "OriginadorTextBox"
        Me.OriginadorTextBox.ReadOnly = True
        Me.OriginadorTextBox.Size = New System.Drawing.Size(191, 20)
        Me.OriginadorTextBox.TabIndex = 36
        '
        'PrioridadTextBox
        '
        Me.PrioridadTextBox.BackColor = System.Drawing.Color.White
        Me.PrioridadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Prioridad", True))
        Me.PrioridadTextBox.Location = New System.Drawing.Point(123, 20)
        Me.PrioridadTextBox.Name = "PrioridadTextBox"
        Me.PrioridadTextBox.ReadOnly = True
        Me.PrioridadTextBox.Size = New System.Drawing.Size(138, 20)
        Me.PrioridadTextBox.TabIndex = 35
        '
        'Descripcion_ActividadTextBox
        '
        Me.Descripcion_ActividadTextBox.BackColor = System.Drawing.Color.White
        Me.Descripcion_ActividadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Descripcion_Actividad", True))
        Me.Descripcion_ActividadTextBox.Location = New System.Drawing.Point(123, 46)
        Me.Descripcion_ActividadTextBox.Multiline = True
        Me.Descripcion_ActividadTextBox.Name = "Descripcion_ActividadTextBox"
        Me.Descripcion_ActividadTextBox.ReadOnly = True
        Me.Descripcion_ActividadTextBox.Size = New System.Drawing.Size(492, 60)
        Me.Descripcion_ActividadTextBox.TabIndex = 28
        '
        'Duracion_planeadaNumericUpDown
        '
        Me.Duracion_planeadaNumericUpDown.BackColor = System.Drawing.Color.White
        Me.Duracion_planeadaNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Duracion_planeada", True))
        Me.Duracion_planeadaNumericUpDown.Enabled = False
        Me.Duracion_planeadaNumericUpDown.Location = New System.Drawing.Point(123, 112)
        Me.Duracion_planeadaNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Duracion_planeadaNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Duracion_planeadaNumericUpDown.Name = "Duracion_planeadaNumericUpDown"
        Me.Duracion_planeadaNumericUpDown.Size = New System.Drawing.Size(51, 20)
        Me.Duracion_planeadaNumericUpDown.TabIndex = 30
        Me.Duracion_planeadaNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Fecha_ProgramadoDateTimePicker
        '
        Me.Fecha_ProgramadoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Fecha_Programado", True))
        Me.Fecha_ProgramadoDateTimePicker.Enabled = False
        Me.Fecha_ProgramadoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_ProgramadoDateTimePicker.Location = New System.Drawing.Point(436, 112)
        Me.Fecha_ProgramadoDateTimePicker.Name = "Fecha_ProgramadoDateTimePicker"
        Me.Fecha_ProgramadoDateTimePicker.Size = New System.Drawing.Size(179, 20)
        Me.Fecha_ProgramadoDateTimePicker.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TAGTextBox)
        Me.GroupBox1.Controls.Add(Me.Tipo_EquipoTextBox)
        Me.GroupBox1.Controls.Add(Me.Familia_EquipoTextBox)
        Me.GroupBox1.Controls.Add(Me.SubFuncionTextBox)
        Me.GroupBox1.Controls.Add(Me.SistemaTextBox)
        Me.GroupBox1.Controls.Add(Me.PlantaTextBox)
        Me.GroupBox1.Controls.Add(Me.Unidad_NegocioTextBox)
        Me.GroupBox1.Controls.Add(Me.Tipo_OTTextBox)
        Me.GroupBox1.Controls.Add(Me.EspecialidadTextBox)
        Me.GroupBox1.Controls.Add(EspecialidadLabel)
        Me.GroupBox1.Controls.Add(Tipo_OTLabel)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.Cod_OTTextBox)
        Me.GroupBox1.Controls.Add(Unidad_NegocioLabel)
        Me.GroupBox1.Controls.Add(PlantaLabel)
        Me.GroupBox1.Controls.Add(SistemaLabel)
        Me.GroupBox1.Controls.Add(SubFuncionLabel)
        Me.GroupBox1.Controls.Add(Familia_EquipoLabel)
        Me.GroupBox1.Controls.Add(Tipo_EquipoLabel)
        Me.GroupBox1.Controls.Add(TAGLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 178)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'TAGTextBox
        '
        Me.TAGTextBox.BackColor = System.Drawing.Color.White
        Me.TAGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "TAG", True))
        Me.TAGTextBox.Location = New System.Drawing.Point(374, 129)
        Me.TAGTextBox.Name = "TAGTextBox"
        Me.TAGTextBox.ReadOnly = True
        Me.TAGTextBox.Size = New System.Drawing.Size(241, 20)
        Me.TAGTextBox.TabIndex = 46
        '
        'Tipo_EquipoTextBox
        '
        Me.Tipo_EquipoTextBox.BackColor = System.Drawing.Color.White
        Me.Tipo_EquipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Tipo_Equipo", True))
        Me.Tipo_EquipoTextBox.Location = New System.Drawing.Point(374, 103)
        Me.Tipo_EquipoTextBox.Name = "Tipo_EquipoTextBox"
        Me.Tipo_EquipoTextBox.ReadOnly = True
        Me.Tipo_EquipoTextBox.Size = New System.Drawing.Size(241, 20)
        Me.Tipo_EquipoTextBox.TabIndex = 45
        '
        'Familia_EquipoTextBox
        '
        Me.Familia_EquipoTextBox.BackColor = System.Drawing.Color.White
        Me.Familia_EquipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Familia_Equipo", True))
        Me.Familia_EquipoTextBox.Location = New System.Drawing.Point(374, 76)
        Me.Familia_EquipoTextBox.Name = "Familia_EquipoTextBox"
        Me.Familia_EquipoTextBox.ReadOnly = True
        Me.Familia_EquipoTextBox.Size = New System.Drawing.Size(241, 20)
        Me.Familia_EquipoTextBox.TabIndex = 44
        '
        'SubFuncionTextBox
        '
        Me.SubFuncionTextBox.BackColor = System.Drawing.Color.White
        Me.SubFuncionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "SubFuncion", True))
        Me.SubFuncionTextBox.Location = New System.Drawing.Point(374, 49)
        Me.SubFuncionTextBox.Name = "SubFuncionTextBox"
        Me.SubFuncionTextBox.ReadOnly = True
        Me.SubFuncionTextBox.Size = New System.Drawing.Size(241, 20)
        Me.SubFuncionTextBox.TabIndex = 43
        '
        'SistemaTextBox
        '
        Me.SistemaTextBox.BackColor = System.Drawing.Color.White
        Me.SistemaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Sistema", True))
        Me.SistemaTextBox.Location = New System.Drawing.Point(374, 22)
        Me.SistemaTextBox.Name = "SistemaTextBox"
        Me.SistemaTextBox.ReadOnly = True
        Me.SistemaTextBox.Size = New System.Drawing.Size(241, 20)
        Me.SistemaTextBox.TabIndex = 42
        '
        'PlantaTextBox
        '
        Me.PlantaTextBox.BackColor = System.Drawing.Color.White
        Me.PlantaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Planta", True))
        Me.PlantaTextBox.Location = New System.Drawing.Point(123, 129)
        Me.PlantaTextBox.Name = "PlantaTextBox"
        Me.PlantaTextBox.ReadOnly = True
        Me.PlantaTextBox.Size = New System.Drawing.Size(138, 20)
        Me.PlantaTextBox.TabIndex = 41
        '
        'Unidad_NegocioTextBox
        '
        Me.Unidad_NegocioTextBox.BackColor = System.Drawing.Color.White
        Me.Unidad_NegocioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Unidad_Negocio", True))
        Me.Unidad_NegocioTextBox.Location = New System.Drawing.Point(123, 102)
        Me.Unidad_NegocioTextBox.Name = "Unidad_NegocioTextBox"
        Me.Unidad_NegocioTextBox.ReadOnly = True
        Me.Unidad_NegocioTextBox.Size = New System.Drawing.Size(138, 20)
        Me.Unidad_NegocioTextBox.TabIndex = 41
        '
        'Tipo_OTTextBox
        '
        Me.Tipo_OTTextBox.BackColor = System.Drawing.Color.White
        Me.Tipo_OTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Tipo_OT", True))
        Me.Tipo_OTTextBox.Location = New System.Drawing.Point(123, 49)
        Me.Tipo_OTTextBox.Name = "Tipo_OTTextBox"
        Me.Tipo_OTTextBox.ReadOnly = True
        Me.Tipo_OTTextBox.Size = New System.Drawing.Size(138, 20)
        Me.Tipo_OTTextBox.TabIndex = 41
        '
        'EspecialidadTextBox
        '
        Me.EspecialidadTextBox.BackColor = System.Drawing.Color.White
        Me.EspecialidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Especialidad", True))
        Me.EspecialidadTextBox.Location = New System.Drawing.Point(123, 22)
        Me.EspecialidadTextBox.Name = "EspecialidadTextBox"
        Me.EspecialidadTextBox.ReadOnly = True
        Me.EspecialidadTextBox.Size = New System.Drawing.Size(138, 20)
        Me.EspecialidadTextBox.TabIndex = 41
        '
        'Cod_OTTextBox
        '
        Me.Cod_OTTextBox.BackColor = System.Drawing.Color.White
        Me.Cod_OTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Cod_OT", True))
        Me.Cod_OTTextBox.Location = New System.Drawing.Point(123, 76)
        Me.Cod_OTTextBox.Name = "Cod_OTTextBox"
        Me.Cod_OTTextBox.ReadOnly = True
        Me.Cod_OTTextBox.Size = New System.Drawing.Size(138, 20)
        Me.Cod_OTTextBox.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Como_quedoLabel)
        Me.TabPage2.Controls.Add(Me.Como_quedoTextBox)
        Me.TabPage2.Controls.Add(Actividad_RealizadaLabel)
        Me.TabPage2.Controls.Add(Me.Actividad_RealizadaTextBox)
        Me.TabPage2.Controls.Add(Como_encontroLabel)
        Me.TabPage2.Controls.Add(Me.Como_encontroTextBox)
        Me.TabPage2.Controls.Add(Duracion_EjecucionLabel)
        Me.TabPage2.Controls.Add(Me.Duracion_EjecucionNumericUpDown)
        Me.TabPage2.Controls.Add(Horas_paroLabel)
        Me.TabPage2.Controls.Add(Me.Horas_paroNumericUpDown)
        Me.TabPage2.Controls.Add(Hora_Ejecucion_FinLabel)
        Me.TabPage2.Controls.Add(Me.Hora_Ejecucion_FinDateTimePicker)
        Me.TabPage2.Controls.Add(Hora_Ejecucion_InicioLabel)
        Me.TabPage2.Controls.Add(Me.Hora_Ejecucion_InicioDateTimePicker)
        Me.TabPage2.Controls.Add(Fecha_Ejecucion_FinLabel)
        Me.TabPage2.Controls.Add(Me.Fecha_Ejecucion_FinDateTimePicker)
        Me.TabPage2.Controls.Add(Fecha_Ejecucion_InicioLabel)
        Me.TabPage2.Controls.Add(Me.Fecha_Ejecucion_InicioDateTimePicker)
        Me.TabPage2.Controls.Add(Permiso_TrabajoLabel)
        Me.TabPage2.Controls.Add(Me.Permiso_TrabajoTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(718, 396)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Actividades"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Como_quedoTextBox
        '
        Me.Como_quedoTextBox.BackColor = System.Drawing.Color.White
        Me.Como_quedoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Como_quedo", True))
        Me.Como_quedoTextBox.Location = New System.Drawing.Point(98, 324)
        Me.Como_quedoTextBox.Multiline = True
        Me.Como_quedoTextBox.Name = "Como_quedoTextBox"
        Me.Como_quedoTextBox.ReadOnly = True
        Me.Como_quedoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Como_quedoTextBox.Size = New System.Drawing.Size(558, 60)
        Me.Como_quedoTextBox.TabIndex = 19
        '
        'Actividad_RealizadaTextBox
        '
        Me.Actividad_RealizadaTextBox.BackColor = System.Drawing.Color.White
        Me.Actividad_RealizadaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Actividad_Realizada", True))
        Me.Actividad_RealizadaTextBox.Location = New System.Drawing.Point(98, 225)
        Me.Actividad_RealizadaTextBox.Multiline = True
        Me.Actividad_RealizadaTextBox.Name = "Actividad_RealizadaTextBox"
        Me.Actividad_RealizadaTextBox.ReadOnly = True
        Me.Actividad_RealizadaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Actividad_RealizadaTextBox.Size = New System.Drawing.Size(558, 77)
        Me.Actividad_RealizadaTextBox.TabIndex = 17
        '
        'Como_encontroTextBox
        '
        Me.Como_encontroTextBox.BackColor = System.Drawing.Color.White
        Me.Como_encontroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Como_encontro", True))
        Me.Como_encontroTextBox.Location = New System.Drawing.Point(98, 144)
        Me.Como_encontroTextBox.Multiline = True
        Me.Como_encontroTextBox.Name = "Como_encontroTextBox"
        Me.Como_encontroTextBox.ReadOnly = True
        Me.Como_encontroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Como_encontroTextBox.Size = New System.Drawing.Size(558, 62)
        Me.Como_encontroTextBox.TabIndex = 15
        '
        'Duracion_EjecucionNumericUpDown
        '
        Me.Duracion_EjecucionNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Duracion_Ejecucion", True))
        Me.Duracion_EjecucionNumericUpDown.Enabled = False
        Me.Duracion_EjecucionNumericUpDown.Location = New System.Drawing.Point(474, 104)
        Me.Duracion_EjecucionNumericUpDown.Name = "Duracion_EjecucionNumericUpDown"
        Me.Duracion_EjecucionNumericUpDown.Size = New System.Drawing.Size(64, 20)
        Me.Duracion_EjecucionNumericUpDown.TabIndex = 13
        '
        'Horas_paroNumericUpDown
        '
        Me.Horas_paroNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Horas_paro", True))
        Me.Horas_paroNumericUpDown.Enabled = False
        Me.Horas_paroNumericUpDown.Location = New System.Drawing.Point(143, 106)
        Me.Horas_paroNumericUpDown.Name = "Horas_paroNumericUpDown"
        Me.Horas_paroNumericUpDown.Size = New System.Drawing.Size(62, 20)
        Me.Horas_paroNumericUpDown.TabIndex = 11
        '
        'Hora_Ejecucion_FinDateTimePicker
        '
        Me.Hora_Ejecucion_FinDateTimePicker.CustomFormat = "HH:mm"
        Me.Hora_Ejecucion_FinDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Hora_Ejecucion_Fin", True))
        Me.Hora_Ejecucion_FinDateTimePicker.Enabled = False
        Me.Hora_Ejecucion_FinDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Hora_Ejecucion_FinDateTimePicker.Location = New System.Drawing.Point(474, 76)
        Me.Hora_Ejecucion_FinDateTimePicker.Name = "Hora_Ejecucion_FinDateTimePicker"
        Me.Hora_Ejecucion_FinDateTimePicker.ShowUpDown = True
        Me.Hora_Ejecucion_FinDateTimePicker.Size = New System.Drawing.Size(64, 20)
        Me.Hora_Ejecucion_FinDateTimePicker.TabIndex = 9
        '
        'Hora_Ejecucion_InicioDateTimePicker
        '
        Me.Hora_Ejecucion_InicioDateTimePicker.CustomFormat = "HH:mm"
        Me.Hora_Ejecucion_InicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Hora_Ejecucion_Inicio", True))
        Me.Hora_Ejecucion_InicioDateTimePicker.Enabled = False
        Me.Hora_Ejecucion_InicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Hora_Ejecucion_InicioDateTimePicker.Location = New System.Drawing.Point(474, 50)
        Me.Hora_Ejecucion_InicioDateTimePicker.Name = "Hora_Ejecucion_InicioDateTimePicker"
        Me.Hora_Ejecucion_InicioDateTimePicker.ShowUpDown = True
        Me.Hora_Ejecucion_InicioDateTimePicker.Size = New System.Drawing.Size(64, 20)
        Me.Hora_Ejecucion_InicioDateTimePicker.TabIndex = 7
        '
        'Fecha_Ejecucion_FinDateTimePicker
        '
        Me.Fecha_Ejecucion_FinDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Fecha_Ejecucion_Fin", True))
        Me.Fecha_Ejecucion_FinDateTimePicker.Enabled = False
        Me.Fecha_Ejecucion_FinDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_Ejecucion_FinDateTimePicker.Location = New System.Drawing.Point(143, 78)
        Me.Fecha_Ejecucion_FinDateTimePicker.MaxDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.Fecha_Ejecucion_FinDateTimePicker.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.Fecha_Ejecucion_FinDateTimePicker.Name = "Fecha_Ejecucion_FinDateTimePicker"
        Me.Fecha_Ejecucion_FinDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_Ejecucion_FinDateTimePicker.TabIndex = 5
        Me.Fecha_Ejecucion_FinDateTimePicker.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'Fecha_Ejecucion_InicioDateTimePicker
        '
        Me.Fecha_Ejecucion_InicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Fecha_Ejecucion_Inicio", True))
        Me.Fecha_Ejecucion_InicioDateTimePicker.Enabled = False
        Me.Fecha_Ejecucion_InicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_Ejecucion_InicioDateTimePicker.Location = New System.Drawing.Point(143, 52)
        Me.Fecha_Ejecucion_InicioDateTimePicker.MaxDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.Fecha_Ejecucion_InicioDateTimePicker.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.Fecha_Ejecucion_InicioDateTimePicker.Name = "Fecha_Ejecucion_InicioDateTimePicker"
        Me.Fecha_Ejecucion_InicioDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_Ejecucion_InicioDateTimePicker.TabIndex = 3
        Me.Fecha_Ejecucion_InicioDateTimePicker.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'Permiso_TrabajoTextBox
        '
        Me.Permiso_TrabajoTextBox.BackColor = System.Drawing.Color.White
        Me.Permiso_TrabajoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Permiso_Trabajo", True))
        Me.Permiso_TrabajoTextBox.Location = New System.Drawing.Point(98, 13)
        Me.Permiso_TrabajoTextBox.Name = "Permiso_TrabajoTextBox"
        Me.Permiso_TrabajoTextBox.ReadOnly = True
        Me.Permiso_TrabajoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Permiso_TrabajoTextBox.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.Modo_de_Falla2TextBox)
        Me.TabPage3.Controls.Add(Me.Modo_de_Falla1TextBox)
        Me.TabPage3.Controls.Add(Label7)
        Me.TabPage3.Controls.Add(Label6)
        Me.TabPage3.Controls.Add(Label5)
        Me.TabPage3.Controls.Add(Label4)
        Me.TabPage3.Controls.Add(Me.N_Articulo2TextBox)
        Me.TabPage3.Controls.Add(Me.ParteNumero2TextBox)
        Me.TabPage3.Controls.Add(Me.Unidad_Medida2TextBox)
        Me.TabPage3.Controls.Add(Me.Descripcion_Repuesto2TextBox)
        Me.TabPage3.Controls.Add(Me.Cantidad_Usada2NumericUpDown)
        Me.TabPage3.Controls.Add(Me.Cantidad_Requerida2NumericUpDown)
        Me.TabPage3.Controls.Add(Me.N_Requerimiento2TextBox)
        Me.TabPage3.Controls.Add(Me.N_Articulo3TextBox)
        Me.TabPage3.Controls.Add(Me.ParteNumero3TextBox)
        Me.TabPage3.Controls.Add(Me.Unidad_Medida3TextBox)
        Me.TabPage3.Controls.Add(Me.Descripcion_Repuesto3TextBox)
        Me.TabPage3.Controls.Add(Me.Cantidad_Usada3NumericUpDown)
        Me.TabPage3.Controls.Add(Me.Cantidad_Requerida3NumericUpDown)
        Me.TabPage3.Controls.Add(Me.N_Requerimiento3TextBox)
        Me.TabPage3.Controls.Add(Me.N_Articulo4TextBox)
        Me.TabPage3.Controls.Add(Me.ParteNumero4TextBox)
        Me.TabPage3.Controls.Add(Me.Unidad_Medida4TextBox)
        Me.TabPage3.Controls.Add(Me.Descripcion_Repuesto4TextBox)
        Me.TabPage3.Controls.Add(Me.Cantidad_Usada4NumericUpDown)
        Me.TabPage3.Controls.Add(Me.Cantidad_Requerida4NumericUpDown)
        Me.TabPage3.Controls.Add(Me.N_Requerimiento4TextBox)
        Me.TabPage3.Controls.Add(Me.N_Articulo5TextBox)
        Me.TabPage3.Controls.Add(Me.ParteNumero5TextBox)
        Me.TabPage3.Controls.Add(Me.Unidad_Medida5TextBox)
        Me.TabPage3.Controls.Add(Me.Descripcion_Repuesto5TextBox)
        Me.TabPage3.Controls.Add(Me.Cantidad_Usada5NumericUpDown)
        Me.TabPage3.Controls.Add(Me.Cantidad_Requerida5NumericUpDown)
        Me.TabPage3.Controls.Add(Me.N_Requerimiento5TextBox)
        Me.TabPage3.Controls.Add(Label3)
        Me.TabPage3.Controls.Add(Label2)
        Me.TabPage3.Controls.Add(RecomendacionesLabel)
        Me.TabPage3.Controls.Add(Me.RecomendacionesTextBox)
        Me.TabPage3.Controls.Add(N_Articulo1Label)
        Me.TabPage3.Controls.Add(Me.N_Articulo1TextBox)
        Me.TabPage3.Controls.Add(ParteNumero1Label)
        Me.TabPage3.Controls.Add(Me.ParteNumero1TextBox)
        Me.TabPage3.Controls.Add(Unidad_Medida1Label)
        Me.TabPage3.Controls.Add(Me.Unidad_Medida1TextBox)
        Me.TabPage3.Controls.Add(Descripcion_Repuesto1Label)
        Me.TabPage3.Controls.Add(Me.Descripcion_Repuesto1TextBox)
        Me.TabPage3.Controls.Add(Cantidad_Usada1Label)
        Me.TabPage3.Controls.Add(Me.Cantidad_Usada1NumericUpDown)
        Me.TabPage3.Controls.Add(Cantidad_Requerida1Label)
        Me.TabPage3.Controls.Add(Me.Cantidad_Requerida1NumericUpDown)
        Me.TabPage3.Controls.Add(N_Requerimiento1Label)
        Me.TabPage3.Controls.Add(Me.N_Requerimiento1TextBox)
        Me.TabPage3.Controls.Add(Modo_de_Falla1Label)
        Me.TabPage3.Controls.Add(Causa_MF1Label)
        Me.TabPage3.Controls.Add(Me.Causa_MF1TextBox)
        Me.TabPage3.Controls.Add(Tiempo_Fuera_Servicio1Label)
        Me.TabPage3.Controls.Add(Me.Tiempo_Fuera_Servicio1NumericUpDown)
        Me.TabPage3.Controls.Add(Tiempo_Reparacion1Label)
        Me.TabPage3.Controls.Add(Me.Tiempo_Reparacion1NumericUpDown)
        Me.TabPage3.Controls.Add(Afecta_Disponibilidad1Label)
        Me.TabPage3.Controls.Add(Me.Afecta_Disponibilidad1CheckBox)
        Me.TabPage3.Controls.Add(Me.Causa_MF2TextBox)
        Me.TabPage3.Controls.Add(Me.Tiempo_Fuera_Servicio2NumericUpDown)
        Me.TabPage3.Controls.Add(Me.Tiempo_Reparacion2NumericUpDown)
        Me.TabPage3.Controls.Add(Me.Afecta_Disponibilidad2CheckBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(718, 396)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Repuestos/MF"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Modo_de_Falla2TextBox
        '
        Me.Modo_de_Falla2TextBox.BackColor = System.Drawing.Color.White
        Me.Modo_de_Falla2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Modo_de_Falla2", True))
        Me.Modo_de_Falla2TextBox.Location = New System.Drawing.Point(11, 320)
        Me.Modo_de_Falla2TextBox.Name = "Modo_de_Falla2TextBox"
        Me.Modo_de_Falla2TextBox.ReadOnly = True
        Me.Modo_de_Falla2TextBox.Size = New System.Drawing.Size(182, 20)
        Me.Modo_de_Falla2TextBox.TabIndex = 329
        '
        'Modo_de_Falla1TextBox
        '
        Me.Modo_de_Falla1TextBox.BackColor = System.Drawing.Color.White
        Me.Modo_de_Falla1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Modo_de_Falla1", True))
        Me.Modo_de_Falla1TextBox.Location = New System.Drawing.Point(11, 293)
        Me.Modo_de_Falla1TextBox.Name = "Modo_de_Falla1TextBox"
        Me.Modo_de_Falla1TextBox.ReadOnly = True
        Me.Modo_de_Falla1TextBox.Size = New System.Drawing.Size(182, 20)
        Me.Modo_de_Falla1TextBox.TabIndex = 328
        '
        'N_Articulo2TextBox
        '
        Me.N_Articulo2TextBox.BackColor = System.Drawing.Color.White
        Me.N_Articulo2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "N_Articulo2", True))
        Me.N_Articulo2TextBox.Location = New System.Drawing.Point(11, 146)
        Me.N_Articulo2TextBox.Name = "N_Articulo2TextBox"
        Me.N_Articulo2TextBox.ReadOnly = True
        Me.N_Articulo2TextBox.Size = New System.Drawing.Size(78, 20)
        Me.N_Articulo2TextBox.TabIndex = 269
        '
        'ParteNumero2TextBox
        '
        Me.ParteNumero2TextBox.BackColor = System.Drawing.Color.White
        Me.ParteNumero2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "ParteNumero2", True))
        Me.ParteNumero2TextBox.Location = New System.Drawing.Point(95, 146)
        Me.ParteNumero2TextBox.Name = "ParteNumero2TextBox"
        Me.ParteNumero2TextBox.ReadOnly = True
        Me.ParteNumero2TextBox.Size = New System.Drawing.Size(98, 20)
        Me.ParteNumero2TextBox.TabIndex = 271
        '
        'Unidad_Medida2TextBox
        '
        Me.Unidad_Medida2TextBox.BackColor = System.Drawing.Color.White
        Me.Unidad_Medida2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Unidad_Medida2", True))
        Me.Unidad_Medida2TextBox.Location = New System.Drawing.Point(199, 146)
        Me.Unidad_Medida2TextBox.Name = "Unidad_Medida2TextBox"
        Me.Unidad_Medida2TextBox.ReadOnly = True
        Me.Unidad_Medida2TextBox.Size = New System.Drawing.Size(69, 20)
        Me.Unidad_Medida2TextBox.TabIndex = 273
        '
        'Descripcion_Repuesto2TextBox
        '
        Me.Descripcion_Repuesto2TextBox.BackColor = System.Drawing.Color.White
        Me.Descripcion_Repuesto2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Descripcion_Repuesto2", True))
        Me.Descripcion_Repuesto2TextBox.Location = New System.Drawing.Point(274, 146)
        Me.Descripcion_Repuesto2TextBox.Name = "Descripcion_Repuesto2TextBox"
        Me.Descripcion_Repuesto2TextBox.ReadOnly = True
        Me.Descripcion_Repuesto2TextBox.Size = New System.Drawing.Size(215, 20)
        Me.Descripcion_Repuesto2TextBox.TabIndex = 275
        '
        'Cantidad_Usada2NumericUpDown
        '
        Me.Cantidad_Usada2NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Cantidad_Usada2", True))
        Me.Cantidad_Usada2NumericUpDown.Enabled = False
        Me.Cantidad_Usada2NumericUpDown.Location = New System.Drawing.Point(495, 145)
        Me.Cantidad_Usada2NumericUpDown.Name = "Cantidad_Usada2NumericUpDown"
        Me.Cantidad_Usada2NumericUpDown.Size = New System.Drawing.Size(44, 20)
        Me.Cantidad_Usada2NumericUpDown.TabIndex = 277
        '
        'Cantidad_Requerida2NumericUpDown
        '
        Me.Cantidad_Requerida2NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Cantidad_Requerida2", True))
        Me.Cantidad_Requerida2NumericUpDown.Enabled = False
        Me.Cantidad_Requerida2NumericUpDown.Location = New System.Drawing.Point(545, 145)
        Me.Cantidad_Requerida2NumericUpDown.Name = "Cantidad_Requerida2NumericUpDown"
        Me.Cantidad_Requerida2NumericUpDown.Size = New System.Drawing.Size(44, 20)
        Me.Cantidad_Requerida2NumericUpDown.TabIndex = 279
        '
        'N_Requerimiento2TextBox
        '
        Me.N_Requerimiento2TextBox.BackColor = System.Drawing.Color.White
        Me.N_Requerimiento2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "N_Requerimiento2", True))
        Me.N_Requerimiento2TextBox.Location = New System.Drawing.Point(595, 146)
        Me.N_Requerimiento2TextBox.Name = "N_Requerimiento2TextBox"
        Me.N_Requerimiento2TextBox.ReadOnly = True
        Me.N_Requerimiento2TextBox.Size = New System.Drawing.Size(77, 20)
        Me.N_Requerimiento2TextBox.TabIndex = 281
        '
        'N_Articulo3TextBox
        '
        Me.N_Articulo3TextBox.BackColor = System.Drawing.Color.White
        Me.N_Articulo3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "N_Articulo3", True))
        Me.N_Articulo3TextBox.Location = New System.Drawing.Point(11, 172)
        Me.N_Articulo3TextBox.Name = "N_Articulo3TextBox"
        Me.N_Articulo3TextBox.ReadOnly = True
        Me.N_Articulo3TextBox.Size = New System.Drawing.Size(78, 20)
        Me.N_Articulo3TextBox.TabIndex = 283
        '
        'ParteNumero3TextBox
        '
        Me.ParteNumero3TextBox.BackColor = System.Drawing.Color.White
        Me.ParteNumero3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "ParteNumero3", True))
        Me.ParteNumero3TextBox.Location = New System.Drawing.Point(95, 172)
        Me.ParteNumero3TextBox.Name = "ParteNumero3TextBox"
        Me.ParteNumero3TextBox.ReadOnly = True
        Me.ParteNumero3TextBox.Size = New System.Drawing.Size(98, 20)
        Me.ParteNumero3TextBox.TabIndex = 285
        '
        'Unidad_Medida3TextBox
        '
        Me.Unidad_Medida3TextBox.BackColor = System.Drawing.Color.White
        Me.Unidad_Medida3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Unidad_Medida3", True))
        Me.Unidad_Medida3TextBox.Location = New System.Drawing.Point(199, 172)
        Me.Unidad_Medida3TextBox.Name = "Unidad_Medida3TextBox"
        Me.Unidad_Medida3TextBox.ReadOnly = True
        Me.Unidad_Medida3TextBox.Size = New System.Drawing.Size(69, 20)
        Me.Unidad_Medida3TextBox.TabIndex = 287
        '
        'Descripcion_Repuesto3TextBox
        '
        Me.Descripcion_Repuesto3TextBox.BackColor = System.Drawing.Color.White
        Me.Descripcion_Repuesto3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Descripcion_Repuesto3", True))
        Me.Descripcion_Repuesto3TextBox.Location = New System.Drawing.Point(274, 172)
        Me.Descripcion_Repuesto3TextBox.Name = "Descripcion_Repuesto3TextBox"
        Me.Descripcion_Repuesto3TextBox.ReadOnly = True
        Me.Descripcion_Repuesto3TextBox.Size = New System.Drawing.Size(215, 20)
        Me.Descripcion_Repuesto3TextBox.TabIndex = 289
        '
        'Cantidad_Usada3NumericUpDown
        '
        Me.Cantidad_Usada3NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Cantidad_Usada3", True))
        Me.Cantidad_Usada3NumericUpDown.Enabled = False
        Me.Cantidad_Usada3NumericUpDown.Location = New System.Drawing.Point(495, 173)
        Me.Cantidad_Usada3NumericUpDown.Name = "Cantidad_Usada3NumericUpDown"
        Me.Cantidad_Usada3NumericUpDown.Size = New System.Drawing.Size(44, 20)
        Me.Cantidad_Usada3NumericUpDown.TabIndex = 291
        '
        'Cantidad_Requerida3NumericUpDown
        '
        Me.Cantidad_Requerida3NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Cantidad_Requerida3", True))
        Me.Cantidad_Requerida3NumericUpDown.Enabled = False
        Me.Cantidad_Requerida3NumericUpDown.Location = New System.Drawing.Point(545, 173)
        Me.Cantidad_Requerida3NumericUpDown.Name = "Cantidad_Requerida3NumericUpDown"
        Me.Cantidad_Requerida3NumericUpDown.Size = New System.Drawing.Size(44, 20)
        Me.Cantidad_Requerida3NumericUpDown.TabIndex = 293
        '
        'N_Requerimiento3TextBox
        '
        Me.N_Requerimiento3TextBox.BackColor = System.Drawing.Color.White
        Me.N_Requerimiento3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "N_Requerimiento3", True))
        Me.N_Requerimiento3TextBox.Location = New System.Drawing.Point(595, 172)
        Me.N_Requerimiento3TextBox.Name = "N_Requerimiento3TextBox"
        Me.N_Requerimiento3TextBox.ReadOnly = True
        Me.N_Requerimiento3TextBox.Size = New System.Drawing.Size(77, 20)
        Me.N_Requerimiento3TextBox.TabIndex = 295
        '
        'N_Articulo4TextBox
        '
        Me.N_Articulo4TextBox.BackColor = System.Drawing.Color.White
        Me.N_Articulo4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "N_Articulo4", True))
        Me.N_Articulo4TextBox.Location = New System.Drawing.Point(11, 198)
        Me.N_Articulo4TextBox.Name = "N_Articulo4TextBox"
        Me.N_Articulo4TextBox.ReadOnly = True
        Me.N_Articulo4TextBox.Size = New System.Drawing.Size(78, 20)
        Me.N_Articulo4TextBox.TabIndex = 297
        '
        'ParteNumero4TextBox
        '
        Me.ParteNumero4TextBox.BackColor = System.Drawing.Color.White
        Me.ParteNumero4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "ParteNumero4", True))
        Me.ParteNumero4TextBox.Location = New System.Drawing.Point(95, 198)
        Me.ParteNumero4TextBox.Name = "ParteNumero4TextBox"
        Me.ParteNumero4TextBox.ReadOnly = True
        Me.ParteNumero4TextBox.Size = New System.Drawing.Size(98, 20)
        Me.ParteNumero4TextBox.TabIndex = 299
        '
        'Unidad_Medida4TextBox
        '
        Me.Unidad_Medida4TextBox.BackColor = System.Drawing.Color.White
        Me.Unidad_Medida4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Unidad_Medida4", True))
        Me.Unidad_Medida4TextBox.Location = New System.Drawing.Point(199, 198)
        Me.Unidad_Medida4TextBox.Name = "Unidad_Medida4TextBox"
        Me.Unidad_Medida4TextBox.ReadOnly = True
        Me.Unidad_Medida4TextBox.Size = New System.Drawing.Size(69, 20)
        Me.Unidad_Medida4TextBox.TabIndex = 301
        '
        'Descripcion_Repuesto4TextBox
        '
        Me.Descripcion_Repuesto4TextBox.BackColor = System.Drawing.Color.White
        Me.Descripcion_Repuesto4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Descripcion_Repuesto4", True))
        Me.Descripcion_Repuesto4TextBox.Location = New System.Drawing.Point(274, 198)
        Me.Descripcion_Repuesto4TextBox.Name = "Descripcion_Repuesto4TextBox"
        Me.Descripcion_Repuesto4TextBox.ReadOnly = True
        Me.Descripcion_Repuesto4TextBox.Size = New System.Drawing.Size(215, 20)
        Me.Descripcion_Repuesto4TextBox.TabIndex = 303
        '
        'Cantidad_Usada4NumericUpDown
        '
        Me.Cantidad_Usada4NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Cantidad_Usada4", True))
        Me.Cantidad_Usada4NumericUpDown.Enabled = False
        Me.Cantidad_Usada4NumericUpDown.Location = New System.Drawing.Point(495, 199)
        Me.Cantidad_Usada4NumericUpDown.Name = "Cantidad_Usada4NumericUpDown"
        Me.Cantidad_Usada4NumericUpDown.Size = New System.Drawing.Size(44, 20)
        Me.Cantidad_Usada4NumericUpDown.TabIndex = 305
        '
        'Cantidad_Requerida4NumericUpDown
        '
        Me.Cantidad_Requerida4NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Cantidad_Requerida4", True))
        Me.Cantidad_Requerida4NumericUpDown.Enabled = False
        Me.Cantidad_Requerida4NumericUpDown.Location = New System.Drawing.Point(545, 198)
        Me.Cantidad_Requerida4NumericUpDown.Name = "Cantidad_Requerida4NumericUpDown"
        Me.Cantidad_Requerida4NumericUpDown.Size = New System.Drawing.Size(44, 20)
        Me.Cantidad_Requerida4NumericUpDown.TabIndex = 307
        '
        'N_Requerimiento4TextBox
        '
        Me.N_Requerimiento4TextBox.BackColor = System.Drawing.Color.White
        Me.N_Requerimiento4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "N_Requerimiento4", True))
        Me.N_Requerimiento4TextBox.Location = New System.Drawing.Point(595, 197)
        Me.N_Requerimiento4TextBox.Name = "N_Requerimiento4TextBox"
        Me.N_Requerimiento4TextBox.ReadOnly = True
        Me.N_Requerimiento4TextBox.Size = New System.Drawing.Size(77, 20)
        Me.N_Requerimiento4TextBox.TabIndex = 309
        '
        'N_Articulo5TextBox
        '
        Me.N_Articulo5TextBox.BackColor = System.Drawing.Color.White
        Me.N_Articulo5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "N_Articulo5", True))
        Me.N_Articulo5TextBox.Location = New System.Drawing.Point(11, 224)
        Me.N_Articulo5TextBox.Name = "N_Articulo5TextBox"
        Me.N_Articulo5TextBox.ReadOnly = True
        Me.N_Articulo5TextBox.Size = New System.Drawing.Size(78, 20)
        Me.N_Articulo5TextBox.TabIndex = 311
        '
        'ParteNumero5TextBox
        '
        Me.ParteNumero5TextBox.BackColor = System.Drawing.Color.White
        Me.ParteNumero5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "ParteNumero5", True))
        Me.ParteNumero5TextBox.Location = New System.Drawing.Point(95, 224)
        Me.ParteNumero5TextBox.Name = "ParteNumero5TextBox"
        Me.ParteNumero5TextBox.ReadOnly = True
        Me.ParteNumero5TextBox.Size = New System.Drawing.Size(98, 20)
        Me.ParteNumero5TextBox.TabIndex = 313
        '
        'Unidad_Medida5TextBox
        '
        Me.Unidad_Medida5TextBox.BackColor = System.Drawing.Color.White
        Me.Unidad_Medida5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Unidad_Medida5", True))
        Me.Unidad_Medida5TextBox.Location = New System.Drawing.Point(199, 224)
        Me.Unidad_Medida5TextBox.Name = "Unidad_Medida5TextBox"
        Me.Unidad_Medida5TextBox.ReadOnly = True
        Me.Unidad_Medida5TextBox.Size = New System.Drawing.Size(69, 20)
        Me.Unidad_Medida5TextBox.TabIndex = 315
        '
        'Descripcion_Repuesto5TextBox
        '
        Me.Descripcion_Repuesto5TextBox.BackColor = System.Drawing.Color.White
        Me.Descripcion_Repuesto5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Descripcion_Repuesto5", True))
        Me.Descripcion_Repuesto5TextBox.Location = New System.Drawing.Point(274, 224)
        Me.Descripcion_Repuesto5TextBox.Name = "Descripcion_Repuesto5TextBox"
        Me.Descripcion_Repuesto5TextBox.ReadOnly = True
        Me.Descripcion_Repuesto5TextBox.Size = New System.Drawing.Size(215, 20)
        Me.Descripcion_Repuesto5TextBox.TabIndex = 317
        '
        'Cantidad_Usada5NumericUpDown
        '
        Me.Cantidad_Usada5NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Cantidad_Usada5", True))
        Me.Cantidad_Usada5NumericUpDown.Enabled = False
        Me.Cantidad_Usada5NumericUpDown.Location = New System.Drawing.Point(495, 224)
        Me.Cantidad_Usada5NumericUpDown.Name = "Cantidad_Usada5NumericUpDown"
        Me.Cantidad_Usada5NumericUpDown.Size = New System.Drawing.Size(44, 20)
        Me.Cantidad_Usada5NumericUpDown.TabIndex = 319
        '
        'Cantidad_Requerida5NumericUpDown
        '
        Me.Cantidad_Requerida5NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Cantidad_Requerida5", True))
        Me.Cantidad_Requerida5NumericUpDown.Enabled = False
        Me.Cantidad_Requerida5NumericUpDown.Location = New System.Drawing.Point(545, 225)
        Me.Cantidad_Requerida5NumericUpDown.Name = "Cantidad_Requerida5NumericUpDown"
        Me.Cantidad_Requerida5NumericUpDown.Size = New System.Drawing.Size(44, 20)
        Me.Cantidad_Requerida5NumericUpDown.TabIndex = 321
        '
        'N_Requerimiento5TextBox
        '
        Me.N_Requerimiento5TextBox.BackColor = System.Drawing.Color.White
        Me.N_Requerimiento5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "N_Requerimiento5", True))
        Me.N_Requerimiento5TextBox.Location = New System.Drawing.Point(595, 225)
        Me.N_Requerimiento5TextBox.Name = "N_Requerimiento5TextBox"
        Me.N_Requerimiento5TextBox.ReadOnly = True
        Me.N_Requerimiento5TextBox.Size = New System.Drawing.Size(77, 20)
        Me.N_Requerimiento5TextBox.TabIndex = 323
        '
        'RecomendacionesTextBox
        '
        Me.RecomendacionesTextBox.BackColor = System.Drawing.Color.White
        Me.RecomendacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Recomendaciones", True))
        Me.RecomendacionesTextBox.Location = New System.Drawing.Point(123, 16)
        Me.RecomendacionesTextBox.Multiline = True
        Me.RecomendacionesTextBox.Name = "RecomendacionesTextBox"
        Me.RecomendacionesTextBox.ReadOnly = True
        Me.RecomendacionesTextBox.Size = New System.Drawing.Size(521, 69)
        Me.RecomendacionesTextBox.TabIndex = 55
        '
        'N_Articulo1TextBox
        '
        Me.N_Articulo1TextBox.BackColor = System.Drawing.Color.White
        Me.N_Articulo1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "N_Articulo1", True))
        Me.N_Articulo1TextBox.Location = New System.Drawing.Point(11, 120)
        Me.N_Articulo1TextBox.Name = "N_Articulo1TextBox"
        Me.N_Articulo1TextBox.ReadOnly = True
        Me.N_Articulo1TextBox.Size = New System.Drawing.Size(78, 20)
        Me.N_Articulo1TextBox.TabIndex = 57
        '
        'ParteNumero1TextBox
        '
        Me.ParteNumero1TextBox.BackColor = System.Drawing.Color.White
        Me.ParteNumero1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "ParteNumero1", True))
        Me.ParteNumero1TextBox.Location = New System.Drawing.Point(95, 120)
        Me.ParteNumero1TextBox.Name = "ParteNumero1TextBox"
        Me.ParteNumero1TextBox.ReadOnly = True
        Me.ParteNumero1TextBox.Size = New System.Drawing.Size(98, 20)
        Me.ParteNumero1TextBox.TabIndex = 59
        '
        'Unidad_Medida1TextBox
        '
        Me.Unidad_Medida1TextBox.BackColor = System.Drawing.Color.White
        Me.Unidad_Medida1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Unidad_Medida1", True))
        Me.Unidad_Medida1TextBox.Location = New System.Drawing.Point(199, 120)
        Me.Unidad_Medida1TextBox.Name = "Unidad_Medida1TextBox"
        Me.Unidad_Medida1TextBox.ReadOnly = True
        Me.Unidad_Medida1TextBox.Size = New System.Drawing.Size(69, 20)
        Me.Unidad_Medida1TextBox.TabIndex = 61
        '
        'Descripcion_Repuesto1TextBox
        '
        Me.Descripcion_Repuesto1TextBox.BackColor = System.Drawing.Color.White
        Me.Descripcion_Repuesto1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Descripcion_Repuesto1", True))
        Me.Descripcion_Repuesto1TextBox.Location = New System.Drawing.Point(274, 120)
        Me.Descripcion_Repuesto1TextBox.Name = "Descripcion_Repuesto1TextBox"
        Me.Descripcion_Repuesto1TextBox.ReadOnly = True
        Me.Descripcion_Repuesto1TextBox.Size = New System.Drawing.Size(215, 20)
        Me.Descripcion_Repuesto1TextBox.TabIndex = 63
        '
        'Cantidad_Usada1NumericUpDown
        '
        Me.Cantidad_Usada1NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Cantidad_Usada1", True))
        Me.Cantidad_Usada1NumericUpDown.Enabled = False
        Me.Cantidad_Usada1NumericUpDown.Location = New System.Drawing.Point(495, 120)
        Me.Cantidad_Usada1NumericUpDown.Name = "Cantidad_Usada1NumericUpDown"
        Me.Cantidad_Usada1NumericUpDown.Size = New System.Drawing.Size(44, 20)
        Me.Cantidad_Usada1NumericUpDown.TabIndex = 65
        '
        'Cantidad_Requerida1NumericUpDown
        '
        Me.Cantidad_Requerida1NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Cantidad_Requerida1", True))
        Me.Cantidad_Requerida1NumericUpDown.Enabled = False
        Me.Cantidad_Requerida1NumericUpDown.Location = New System.Drawing.Point(545, 120)
        Me.Cantidad_Requerida1NumericUpDown.Name = "Cantidad_Requerida1NumericUpDown"
        Me.Cantidad_Requerida1NumericUpDown.Size = New System.Drawing.Size(44, 20)
        Me.Cantidad_Requerida1NumericUpDown.TabIndex = 67
        '
        'N_Requerimiento1TextBox
        '
        Me.N_Requerimiento1TextBox.BackColor = System.Drawing.Color.White
        Me.N_Requerimiento1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "N_Requerimiento1", True))
        Me.N_Requerimiento1TextBox.Location = New System.Drawing.Point(595, 119)
        Me.N_Requerimiento1TextBox.Name = "N_Requerimiento1TextBox"
        Me.N_Requerimiento1TextBox.ReadOnly = True
        Me.N_Requerimiento1TextBox.Size = New System.Drawing.Size(77, 20)
        Me.N_Requerimiento1TextBox.TabIndex = 69
        '
        'Causa_MF1TextBox
        '
        Me.Causa_MF1TextBox.BackColor = System.Drawing.Color.White
        Me.Causa_MF1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Causa_MF1", True))
        Me.Causa_MF1TextBox.Location = New System.Drawing.Point(199, 293)
        Me.Causa_MF1TextBox.Name = "Causa_MF1TextBox"
        Me.Causa_MF1TextBox.ReadOnly = True
        Me.Causa_MF1TextBox.Size = New System.Drawing.Size(304, 20)
        Me.Causa_MF1TextBox.TabIndex = 129
        '
        'Tiempo_Fuera_Servicio1NumericUpDown
        '
        Me.Tiempo_Fuera_Servicio1NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Tiempo_Fuera_Servicio1", True))
        Me.Tiempo_Fuera_Servicio1NumericUpDown.Enabled = False
        Me.Tiempo_Fuera_Servicio1NumericUpDown.Location = New System.Drawing.Point(518, 291)
        Me.Tiempo_Fuera_Servicio1NumericUpDown.Name = "Tiempo_Fuera_Servicio1NumericUpDown"
        Me.Tiempo_Fuera_Servicio1NumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.Tiempo_Fuera_Servicio1NumericUpDown.TabIndex = 131
        '
        'Tiempo_Reparacion1NumericUpDown
        '
        Me.Tiempo_Reparacion1NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Tiempo_Reparacion1", True))
        Me.Tiempo_Reparacion1NumericUpDown.Enabled = False
        Me.Tiempo_Reparacion1NumericUpDown.Location = New System.Drawing.Point(570, 291)
        Me.Tiempo_Reparacion1NumericUpDown.Name = "Tiempo_Reparacion1NumericUpDown"
        Me.Tiempo_Reparacion1NumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.Tiempo_Reparacion1NumericUpDown.TabIndex = 133
        '
        'Afecta_Disponibilidad1CheckBox
        '
        Me.Afecta_Disponibilidad1CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OMBindingSource, "Afecta_Disponibilidad1", True))
        Me.Afecta_Disponibilidad1CheckBox.Enabled = False
        Me.Afecta_Disponibilidad1CheckBox.Location = New System.Drawing.Point(640, 287)
        Me.Afecta_Disponibilidad1CheckBox.Name = "Afecta_Disponibilidad1CheckBox"
        Me.Afecta_Disponibilidad1CheckBox.Size = New System.Drawing.Size(32, 24)
        Me.Afecta_Disponibilidad1CheckBox.TabIndex = 135
        Me.Afecta_Disponibilidad1CheckBox.UseVisualStyleBackColor = True
        '
        'Causa_MF2TextBox
        '
        Me.Causa_MF2TextBox.BackColor = System.Drawing.Color.White
        Me.Causa_MF2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Causa_MF2", True))
        Me.Causa_MF2TextBox.Location = New System.Drawing.Point(199, 320)
        Me.Causa_MF2TextBox.Name = "Causa_MF2TextBox"
        Me.Causa_MF2TextBox.ReadOnly = True
        Me.Causa_MF2TextBox.Size = New System.Drawing.Size(304, 20)
        Me.Causa_MF2TextBox.TabIndex = 139
        '
        'Tiempo_Fuera_Servicio2NumericUpDown
        '
        Me.Tiempo_Fuera_Servicio2NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Tiempo_Fuera_Servicio2", True))
        Me.Tiempo_Fuera_Servicio2NumericUpDown.Enabled = False
        Me.Tiempo_Fuera_Servicio2NumericUpDown.Location = New System.Drawing.Point(518, 321)
        Me.Tiempo_Fuera_Servicio2NumericUpDown.Name = "Tiempo_Fuera_Servicio2NumericUpDown"
        Me.Tiempo_Fuera_Servicio2NumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.Tiempo_Fuera_Servicio2NumericUpDown.TabIndex = 141
        '
        'Tiempo_Reparacion2NumericUpDown
        '
        Me.Tiempo_Reparacion2NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Tiempo_Reparacion2", True))
        Me.Tiempo_Reparacion2NumericUpDown.Enabled = False
        Me.Tiempo_Reparacion2NumericUpDown.Location = New System.Drawing.Point(570, 321)
        Me.Tiempo_Reparacion2NumericUpDown.Name = "Tiempo_Reparacion2NumericUpDown"
        Me.Tiempo_Reparacion2NumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.Tiempo_Reparacion2NumericUpDown.TabIndex = 143
        '
        'Afecta_Disponibilidad2CheckBox
        '
        Me.Afecta_Disponibilidad2CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OMBindingSource, "Afecta_Disponibilidad2", True))
        Me.Afecta_Disponibilidad2CheckBox.Enabled = False
        Me.Afecta_Disponibilidad2CheckBox.Location = New System.Drawing.Point(640, 321)
        Me.Afecta_Disponibilidad2CheckBox.Name = "Afecta_Disponibilidad2CheckBox"
        Me.Afecta_Disponibilidad2CheckBox.Size = New System.Drawing.Size(22, 24)
        Me.Afecta_Disponibilidad2CheckBox.TabIndex = 145
        Me.Afecta_Disponibilidad2CheckBox.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.NombreTecnico6TextBox)
        Me.TabPage4.Controls.Add(Me.NombreTecnico5TextBox)
        Me.TabPage4.Controls.Add(Me.NombreTecnico4TextBox)
        Me.TabPage4.Controls.Add(Me.NombreTecnico3TextBox)
        Me.TabPage4.Controls.Add(Me.NombreTecnico2TextBox)
        Me.TabPage4.Controls.Add(Me.NombreTecnico1TextBox)
        Me.TabPage4.Controls.Add(Me.Especialidad6TextBox)
        Me.TabPage4.Controls.Add(Me.Cargo6TextBox)
        Me.TabPage4.Controls.Add(Me.Especialidad5TextBox)
        Me.TabPage4.Controls.Add(Me.Cargo5TextBox)
        Me.TabPage4.Controls.Add(Me.Especialidad4TextBox)
        Me.TabPage4.Controls.Add(Me.Cargo4TextBox)
        Me.TabPage4.Controls.Add(Me.Especialidad3TextBox)
        Me.TabPage4.Controls.Add(Me.Cargo3TextBox)
        Me.TabPage4.Controls.Add(Me.Especialidad2TextBox)
        Me.TabPage4.Controls.Add(Me.Cargo2TextBox)
        Me.TabPage4.Controls.Add(Me.Especialidad1TextBox)
        Me.TabPage4.Controls.Add(Me.Cargo1TextBox)
        Me.TabPage4.Controls.Add(NombreTecnico1Label)
        Me.TabPage4.Controls.Add(CATMLabel)
        Me.TabPage4.Controls.Add(Me.CATMNumericUpDown)
        Me.TabPage4.Controls.Add(DESPLabel)
        Me.TabPage4.Controls.Add(Me.DESPNumericUpDown)
        Me.TabPage4.Controls.Add(PERMLabel)
        Me.TabPage4.Controls.Add(Me.PERMNumericUpDown)
        Me.TabPage4.Controls.Add(AHERLabel)
        Me.TabPage4.Controls.Add(Me.AHERNumericUpDown)
        Me.TabPage4.Controls.Add(OPUBLabel)
        Me.TabPage4.Controls.Add(Me.OPUBNumericUpDown)
        Me.TabPage4.Controls.Add(CSEGLabel)
        Me.TabPage4.Controls.Add(Me.CSEGNumericUpDown)
        Me.TabPage4.Controls.Add(DISPLabel)
        Me.TabPage4.Controls.Add(Me.DISPNumericUpDown)
        Me.TabPage4.Controls.Add(HERRLabel)
        Me.TabPage4.Controls.Add(Me.HERRNumericUpDown)
        Me.TabPage4.Controls.Add(REPULabel)
        Me.TabPage4.Controls.Add(Me.REPUNumericUpDown)
        Me.TabPage4.Controls.Add(RECULabel)
        Me.TabPage4.Controls.Add(Me.RECUNumericUpDown)
        Me.TabPage4.Controls.Add(CAPALabel)
        Me.TabPage4.Controls.Add(Me.CAPANumericUpDown)
        Me.TabPage4.Controls.Add(AISLLabel)
        Me.TabPage4.Controls.Add(Me.AISLNumericUpDown)
        Me.TabPage4.Controls.Add(DAUDLabel)
        Me.TabPage4.Controls.Add(Me.DAUDNumericUpDown)
        Me.TabPage4.Controls.Add(OTROLabel)
        Me.TabPage4.Controls.Add(Me.OTRONumericUpDown)
        Me.TabPage4.Controls.Add(Tiempo_totalLabel)
        Me.TabPage4.Controls.Add(Me.Tiempo_totalNumericUpDown)
        Me.TabPage4.Controls.Add(Cargo1Label)
        Me.TabPage4.Controls.Add(Especialidad1Label)
        Me.TabPage4.Controls.Add(Fecha1Label)
        Me.TabPage4.Controls.Add(Me.Fecha1DateTimePicker)
        Me.TabPage4.Controls.Add(Horas1Label)
        Me.TabPage4.Controls.Add(Me.Horas1NumericUpDown)
        Me.TabPage4.Controls.Add(Horas_Extra1Label)
        Me.TabPage4.Controls.Add(Me.Horas_Extra1NumericUpDown)
        Me.TabPage4.Controls.Add(Me.Fecha2DateTimePicker)
        Me.TabPage4.Controls.Add(Me.Horas2NumericUpDown)
        Me.TabPage4.Controls.Add(Me.Horas_Extra2NumericUpDown)
        Me.TabPage4.Controls.Add(Me.Fecha3DateTimePicker)
        Me.TabPage4.Controls.Add(Me.Horas3NumericUpDown)
        Me.TabPage4.Controls.Add(Me.Horas_Extra3NumericUpDown)
        Me.TabPage4.Controls.Add(Me.Fecha4DateTimePicker)
        Me.TabPage4.Controls.Add(Me.Horas4NumericUpDown)
        Me.TabPage4.Controls.Add(Me.Horas_Extra4NumericUpDown)
        Me.TabPage4.Controls.Add(Me.Fecha5DateTimePicker)
        Me.TabPage4.Controls.Add(Me.Horas5NumericUpDown)
        Me.TabPage4.Controls.Add(Me.Horas_Extra5NumericUpDown)
        Me.TabPage4.Controls.Add(Me.Fecha6DateTimePicker)
        Me.TabPage4.Controls.Add(Me.Horas6NumericUpDown)
        Me.TabPage4.Controls.Add(Me.Horas_Extra6NumericUpDown)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(718, 396)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Tiempos"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'NombreTecnico6TextBox
        '
        Me.NombreTecnico6TextBox.BackColor = System.Drawing.Color.White
        Me.NombreTecnico6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "NombreTecnico6", True))
        Me.NombreTecnico6TextBox.Location = New System.Drawing.Point(15, 166)
        Me.NombreTecnico6TextBox.Name = "NombreTecnico6TextBox"
        Me.NombreTecnico6TextBox.ReadOnly = True
        Me.NombreTecnico6TextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTecnico6TextBox.TabIndex = 416
        '
        'NombreTecnico5TextBox
        '
        Me.NombreTecnico5TextBox.BackColor = System.Drawing.Color.White
        Me.NombreTecnico5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "NombreTecnico5", True))
        Me.NombreTecnico5TextBox.Location = New System.Drawing.Point(15, 139)
        Me.NombreTecnico5TextBox.Name = "NombreTecnico5TextBox"
        Me.NombreTecnico5TextBox.ReadOnly = True
        Me.NombreTecnico5TextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTecnico5TextBox.TabIndex = 415
        '
        'NombreTecnico4TextBox
        '
        Me.NombreTecnico4TextBox.BackColor = System.Drawing.Color.White
        Me.NombreTecnico4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "NombreTecnico4", True))
        Me.NombreTecnico4TextBox.Location = New System.Drawing.Point(15, 113)
        Me.NombreTecnico4TextBox.Name = "NombreTecnico4TextBox"
        Me.NombreTecnico4TextBox.ReadOnly = True
        Me.NombreTecnico4TextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTecnico4TextBox.TabIndex = 414
        '
        'NombreTecnico3TextBox
        '
        Me.NombreTecnico3TextBox.BackColor = System.Drawing.Color.White
        Me.NombreTecnico3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "NombreTecnico3", True))
        Me.NombreTecnico3TextBox.Location = New System.Drawing.Point(15, 85)
        Me.NombreTecnico3TextBox.Name = "NombreTecnico3TextBox"
        Me.NombreTecnico3TextBox.ReadOnly = True
        Me.NombreTecnico3TextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTecnico3TextBox.TabIndex = 413
        '
        'NombreTecnico2TextBox
        '
        Me.NombreTecnico2TextBox.BackColor = System.Drawing.Color.White
        Me.NombreTecnico2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "NombreTecnico2", True))
        Me.NombreTecnico2TextBox.Location = New System.Drawing.Point(15, 59)
        Me.NombreTecnico2TextBox.Name = "NombreTecnico2TextBox"
        Me.NombreTecnico2TextBox.ReadOnly = True
        Me.NombreTecnico2TextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTecnico2TextBox.TabIndex = 412
        '
        'NombreTecnico1TextBox
        '
        Me.NombreTecnico1TextBox.BackColor = System.Drawing.Color.White
        Me.NombreTecnico1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "NombreTecnico1", True))
        Me.NombreTecnico1TextBox.Location = New System.Drawing.Point(15, 32)
        Me.NombreTecnico1TextBox.Name = "NombreTecnico1TextBox"
        Me.NombreTecnico1TextBox.ReadOnly = True
        Me.NombreTecnico1TextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTecnico1TextBox.TabIndex = 411
        '
        'Especialidad6TextBox
        '
        Me.Especialidad6TextBox.BackColor = System.Drawing.Color.White
        Me.Especialidad6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Especialidad6", True))
        Me.Especialidad6TextBox.Location = New System.Drawing.Point(341, 167)
        Me.Especialidad6TextBox.Name = "Especialidad6TextBox"
        Me.Especialidad6TextBox.ReadOnly = True
        Me.Especialidad6TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Especialidad6TextBox.TabIndex = 410
        '
        'Cargo6TextBox
        '
        Me.Cargo6TextBox.BackColor = System.Drawing.Color.White
        Me.Cargo6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Cargo6", True))
        Me.Cargo6TextBox.Location = New System.Drawing.Point(221, 166)
        Me.Cargo6TextBox.Name = "Cargo6TextBox"
        Me.Cargo6TextBox.ReadOnly = True
        Me.Cargo6TextBox.Size = New System.Drawing.Size(114, 20)
        Me.Cargo6TextBox.TabIndex = 409
        '
        'Especialidad5TextBox
        '
        Me.Especialidad5TextBox.BackColor = System.Drawing.Color.White
        Me.Especialidad5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Especialidad5", True))
        Me.Especialidad5TextBox.Location = New System.Drawing.Point(341, 140)
        Me.Especialidad5TextBox.Name = "Especialidad5TextBox"
        Me.Especialidad5TextBox.ReadOnly = True
        Me.Especialidad5TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Especialidad5TextBox.TabIndex = 408
        '
        'Cargo5TextBox
        '
        Me.Cargo5TextBox.BackColor = System.Drawing.Color.White
        Me.Cargo5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Cargo5", True))
        Me.Cargo5TextBox.Location = New System.Drawing.Point(221, 140)
        Me.Cargo5TextBox.Name = "Cargo5TextBox"
        Me.Cargo5TextBox.ReadOnly = True
        Me.Cargo5TextBox.Size = New System.Drawing.Size(114, 20)
        Me.Cargo5TextBox.TabIndex = 407
        '
        'Especialidad4TextBox
        '
        Me.Especialidad4TextBox.BackColor = System.Drawing.Color.White
        Me.Especialidad4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Especialidad4", True))
        Me.Especialidad4TextBox.Location = New System.Drawing.Point(341, 113)
        Me.Especialidad4TextBox.Name = "Especialidad4TextBox"
        Me.Especialidad4TextBox.ReadOnly = True
        Me.Especialidad4TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Especialidad4TextBox.TabIndex = 406
        '
        'Cargo4TextBox
        '
        Me.Cargo4TextBox.BackColor = System.Drawing.Color.White
        Me.Cargo4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Cargo4", True))
        Me.Cargo4TextBox.Location = New System.Drawing.Point(221, 113)
        Me.Cargo4TextBox.Name = "Cargo4TextBox"
        Me.Cargo4TextBox.ReadOnly = True
        Me.Cargo4TextBox.Size = New System.Drawing.Size(114, 20)
        Me.Cargo4TextBox.TabIndex = 405
        '
        'Especialidad3TextBox
        '
        Me.Especialidad3TextBox.BackColor = System.Drawing.Color.White
        Me.Especialidad3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Especialidad3", True))
        Me.Especialidad3TextBox.Location = New System.Drawing.Point(341, 84)
        Me.Especialidad3TextBox.Name = "Especialidad3TextBox"
        Me.Especialidad3TextBox.ReadOnly = True
        Me.Especialidad3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Especialidad3TextBox.TabIndex = 404
        '
        'Cargo3TextBox
        '
        Me.Cargo3TextBox.BackColor = System.Drawing.Color.White
        Me.Cargo3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Cargo3", True))
        Me.Cargo3TextBox.Location = New System.Drawing.Point(221, 84)
        Me.Cargo3TextBox.Name = "Cargo3TextBox"
        Me.Cargo3TextBox.ReadOnly = True
        Me.Cargo3TextBox.Size = New System.Drawing.Size(114, 20)
        Me.Cargo3TextBox.TabIndex = 403
        '
        'Especialidad2TextBox
        '
        Me.Especialidad2TextBox.BackColor = System.Drawing.Color.White
        Me.Especialidad2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Especialidad2", True))
        Me.Especialidad2TextBox.Location = New System.Drawing.Point(341, 59)
        Me.Especialidad2TextBox.Name = "Especialidad2TextBox"
        Me.Especialidad2TextBox.ReadOnly = True
        Me.Especialidad2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Especialidad2TextBox.TabIndex = 402
        '
        'Cargo2TextBox
        '
        Me.Cargo2TextBox.BackColor = System.Drawing.Color.White
        Me.Cargo2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Cargo2", True))
        Me.Cargo2TextBox.Location = New System.Drawing.Point(221, 59)
        Me.Cargo2TextBox.Name = "Cargo2TextBox"
        Me.Cargo2TextBox.ReadOnly = True
        Me.Cargo2TextBox.Size = New System.Drawing.Size(114, 20)
        Me.Cargo2TextBox.TabIndex = 401
        '
        'Especialidad1TextBox
        '
        Me.Especialidad1TextBox.BackColor = System.Drawing.Color.White
        Me.Especialidad1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Especialidad1", True))
        Me.Especialidad1TextBox.Location = New System.Drawing.Point(341, 31)
        Me.Especialidad1TextBox.Name = "Especialidad1TextBox"
        Me.Especialidad1TextBox.ReadOnly = True
        Me.Especialidad1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Especialidad1TextBox.TabIndex = 400
        '
        'Cargo1TextBox
        '
        Me.Cargo1TextBox.BackColor = System.Drawing.Color.White
        Me.Cargo1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Cargo1", True))
        Me.Cargo1TextBox.Location = New System.Drawing.Point(221, 32)
        Me.Cargo1TextBox.Name = "Cargo1TextBox"
        Me.Cargo1TextBox.ReadOnly = True
        Me.Cargo1TextBox.Size = New System.Drawing.Size(114, 20)
        Me.Cargo1TextBox.TabIndex = 399
        '
        'CATMNumericUpDown
        '
        Me.CATMNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "CATM", True))
        Me.CATMNumericUpDown.Enabled = False
        Me.CATMNumericUpDown.Location = New System.Drawing.Point(148, 198)
        Me.CATMNumericUpDown.Name = "CATMNumericUpDown"
        Me.CATMNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.CATMNumericUpDown.TabIndex = 363
        '
        'DESPNumericUpDown
        '
        Me.DESPNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "DESP", True))
        Me.DESPNumericUpDown.Enabled = False
        Me.DESPNumericUpDown.Location = New System.Drawing.Point(148, 225)
        Me.DESPNumericUpDown.Name = "DESPNumericUpDown"
        Me.DESPNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.DESPNumericUpDown.TabIndex = 365
        '
        'PERMNumericUpDown
        '
        Me.PERMNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "PERM", True))
        Me.PERMNumericUpDown.Enabled = False
        Me.PERMNumericUpDown.Location = New System.Drawing.Point(148, 251)
        Me.PERMNumericUpDown.Name = "PERMNumericUpDown"
        Me.PERMNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.PERMNumericUpDown.TabIndex = 367
        '
        'AHERNumericUpDown
        '
        Me.AHERNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "AHER", True))
        Me.AHERNumericUpDown.Enabled = False
        Me.AHERNumericUpDown.Location = New System.Drawing.Point(148, 277)
        Me.AHERNumericUpDown.Name = "AHERNumericUpDown"
        Me.AHERNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.AHERNumericUpDown.TabIndex = 369
        '
        'OPUBNumericUpDown
        '
        Me.OPUBNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "OPUB", True))
        Me.OPUBNumericUpDown.Enabled = False
        Me.OPUBNumericUpDown.Location = New System.Drawing.Point(148, 303)
        Me.OPUBNumericUpDown.Name = "OPUBNumericUpDown"
        Me.OPUBNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.OPUBNumericUpDown.TabIndex = 371
        '
        'CSEGNumericUpDown
        '
        Me.CSEGNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "CSEG", True))
        Me.CSEGNumericUpDown.Enabled = False
        Me.CSEGNumericUpDown.Location = New System.Drawing.Point(393, 199)
        Me.CSEGNumericUpDown.Name = "CSEGNumericUpDown"
        Me.CSEGNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.CSEGNumericUpDown.TabIndex = 373
        '
        'DISPNumericUpDown
        '
        Me.DISPNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "DISP", True))
        Me.DISPNumericUpDown.Enabled = False
        Me.DISPNumericUpDown.Location = New System.Drawing.Point(393, 225)
        Me.DISPNumericUpDown.Name = "DISPNumericUpDown"
        Me.DISPNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.DISPNumericUpDown.TabIndex = 375
        '
        'HERRNumericUpDown
        '
        Me.HERRNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "HERR", True))
        Me.HERRNumericUpDown.Enabled = False
        Me.HERRNumericUpDown.Location = New System.Drawing.Point(393, 251)
        Me.HERRNumericUpDown.Name = "HERRNumericUpDown"
        Me.HERRNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.HERRNumericUpDown.TabIndex = 377
        '
        'REPUNumericUpDown
        '
        Me.REPUNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "REPU", True))
        Me.REPUNumericUpDown.Enabled = False
        Me.REPUNumericUpDown.Location = New System.Drawing.Point(393, 277)
        Me.REPUNumericUpDown.Name = "REPUNumericUpDown"
        Me.REPUNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.REPUNumericUpDown.TabIndex = 379
        '
        'RECUNumericUpDown
        '
        Me.RECUNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "RECU", True))
        Me.RECUNumericUpDown.Enabled = False
        Me.RECUNumericUpDown.Location = New System.Drawing.Point(393, 303)
        Me.RECUNumericUpDown.Name = "RECUNumericUpDown"
        Me.RECUNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.RECUNumericUpDown.TabIndex = 381
        '
        'CAPANumericUpDown
        '
        Me.CAPANumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "CAPA", True))
        Me.CAPANumericUpDown.Enabled = False
        Me.CAPANumericUpDown.Location = New System.Drawing.Point(621, 197)
        Me.CAPANumericUpDown.Name = "CAPANumericUpDown"
        Me.CAPANumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.CAPANumericUpDown.TabIndex = 383
        '
        'AISLNumericUpDown
        '
        Me.AISLNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "AISL", True))
        Me.AISLNumericUpDown.Enabled = False
        Me.AISLNumericUpDown.Location = New System.Drawing.Point(621, 223)
        Me.AISLNumericUpDown.Name = "AISLNumericUpDown"
        Me.AISLNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.AISLNumericUpDown.TabIndex = 385
        '
        'DAUDNumericUpDown
        '
        Me.DAUDNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "DAUD", True))
        Me.DAUDNumericUpDown.Enabled = False
        Me.DAUDNumericUpDown.Location = New System.Drawing.Point(621, 249)
        Me.DAUDNumericUpDown.Name = "DAUDNumericUpDown"
        Me.DAUDNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.DAUDNumericUpDown.TabIndex = 387
        '
        'OTRONumericUpDown
        '
        Me.OTRONumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "OTRO", True))
        Me.OTRONumericUpDown.Enabled = False
        Me.OTRONumericUpDown.Location = New System.Drawing.Point(621, 275)
        Me.OTRONumericUpDown.Name = "OTRONumericUpDown"
        Me.OTRONumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.OTRONumericUpDown.TabIndex = 389
        '
        'Tiempo_totalNumericUpDown
        '
        Me.Tiempo_totalNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Tiempo_total", True))
        Me.Tiempo_totalNumericUpDown.Enabled = False
        Me.Tiempo_totalNumericUpDown.Location = New System.Drawing.Point(621, 301)
        Me.Tiempo_totalNumericUpDown.Name = "Tiempo_totalNumericUpDown"
        Me.Tiempo_totalNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.Tiempo_totalNumericUpDown.TabIndex = 391
        '
        'Fecha1DateTimePicker
        '
        Me.Fecha1DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Fecha1", True))
        Me.Fecha1DateTimePicker.Enabled = False
        Me.Fecha1DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha1DateTimePicker.Location = New System.Drawing.Point(446, 32)
        Me.Fecha1DateTimePicker.MaxDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.Fecha1DateTimePicker.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.Fecha1DateTimePicker.Name = "Fecha1DateTimePicker"
        Me.Fecha1DateTimePicker.Size = New System.Drawing.Size(114, 20)
        Me.Fecha1DateTimePicker.TabIndex = 297
        Me.Fecha1DateTimePicker.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'Horas1NumericUpDown
        '
        Me.Horas1NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Horas1", True))
        Me.Horas1NumericUpDown.Enabled = False
        Me.Horas1NumericUpDown.Location = New System.Drawing.Point(566, 32)
        Me.Horas1NumericUpDown.Name = "Horas1NumericUpDown"
        Me.Horas1NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.Horas1NumericUpDown.TabIndex = 299
        '
        'Horas_Extra1NumericUpDown
        '
        Me.Horas_Extra1NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Horas_Extra1", True))
        Me.Horas_Extra1NumericUpDown.Enabled = False
        Me.Horas_Extra1NumericUpDown.Location = New System.Drawing.Point(620, 31)
        Me.Horas_Extra1NumericUpDown.Name = "Horas_Extra1NumericUpDown"
        Me.Horas_Extra1NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.Horas_Extra1NumericUpDown.TabIndex = 301
        '
        'Fecha2DateTimePicker
        '
        Me.Fecha2DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Fecha2", True))
        Me.Fecha2DateTimePicker.Enabled = False
        Me.Fecha2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha2DateTimePicker.Location = New System.Drawing.Point(446, 59)
        Me.Fecha2DateTimePicker.MaxDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.Fecha2DateTimePicker.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.Fecha2DateTimePicker.Name = "Fecha2DateTimePicker"
        Me.Fecha2DateTimePicker.Size = New System.Drawing.Size(114, 20)
        Me.Fecha2DateTimePicker.TabIndex = 309
        Me.Fecha2DateTimePicker.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'Horas2NumericUpDown
        '
        Me.Horas2NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Horas2", True))
        Me.Horas2NumericUpDown.Enabled = False
        Me.Horas2NumericUpDown.Location = New System.Drawing.Point(566, 58)
        Me.Horas2NumericUpDown.Name = "Horas2NumericUpDown"
        Me.Horas2NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.Horas2NumericUpDown.TabIndex = 311
        '
        'Horas_Extra2NumericUpDown
        '
        Me.Horas_Extra2NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Horas_Extra2", True))
        Me.Horas_Extra2NumericUpDown.Enabled = False
        Me.Horas_Extra2NumericUpDown.Location = New System.Drawing.Point(620, 57)
        Me.Horas_Extra2NumericUpDown.Name = "Horas_Extra2NumericUpDown"
        Me.Horas_Extra2NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.Horas_Extra2NumericUpDown.TabIndex = 313
        '
        'Fecha3DateTimePicker
        '
        Me.Fecha3DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Fecha3", True))
        Me.Fecha3DateTimePicker.Enabled = False
        Me.Fecha3DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha3DateTimePicker.Location = New System.Drawing.Point(446, 85)
        Me.Fecha3DateTimePicker.MaxDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.Fecha3DateTimePicker.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.Fecha3DateTimePicker.Name = "Fecha3DateTimePicker"
        Me.Fecha3DateTimePicker.Size = New System.Drawing.Size(114, 20)
        Me.Fecha3DateTimePicker.TabIndex = 321
        Me.Fecha3DateTimePicker.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'Horas3NumericUpDown
        '
        Me.Horas3NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Horas3", True))
        Me.Horas3NumericUpDown.Enabled = False
        Me.Horas3NumericUpDown.Location = New System.Drawing.Point(566, 85)
        Me.Horas3NumericUpDown.Name = "Horas3NumericUpDown"
        Me.Horas3NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.Horas3NumericUpDown.TabIndex = 323
        '
        'Horas_Extra3NumericUpDown
        '
        Me.Horas_Extra3NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Horas_Extra3", True))
        Me.Horas_Extra3NumericUpDown.Enabled = False
        Me.Horas_Extra3NumericUpDown.Location = New System.Drawing.Point(620, 85)
        Me.Horas_Extra3NumericUpDown.Name = "Horas_Extra3NumericUpDown"
        Me.Horas_Extra3NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.Horas_Extra3NumericUpDown.TabIndex = 325
        '
        'Fecha4DateTimePicker
        '
        Me.Fecha4DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Fecha4", True))
        Me.Fecha4DateTimePicker.Enabled = False
        Me.Fecha4DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha4DateTimePicker.Location = New System.Drawing.Point(446, 113)
        Me.Fecha4DateTimePicker.MaxDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.Fecha4DateTimePicker.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.Fecha4DateTimePicker.Name = "Fecha4DateTimePicker"
        Me.Fecha4DateTimePicker.Size = New System.Drawing.Size(114, 20)
        Me.Fecha4DateTimePicker.TabIndex = 333
        Me.Fecha4DateTimePicker.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'Horas4NumericUpDown
        '
        Me.Horas4NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Horas4", True))
        Me.Horas4NumericUpDown.Enabled = False
        Me.Horas4NumericUpDown.Location = New System.Drawing.Point(566, 113)
        Me.Horas4NumericUpDown.Name = "Horas4NumericUpDown"
        Me.Horas4NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.Horas4NumericUpDown.TabIndex = 335
        '
        'Horas_Extra4NumericUpDown
        '
        Me.Horas_Extra4NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Horas_Extra4", True))
        Me.Horas_Extra4NumericUpDown.Enabled = False
        Me.Horas_Extra4NumericUpDown.Location = New System.Drawing.Point(620, 113)
        Me.Horas_Extra4NumericUpDown.Name = "Horas_Extra4NumericUpDown"
        Me.Horas_Extra4NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.Horas_Extra4NumericUpDown.TabIndex = 337
        '
        'Fecha5DateTimePicker
        '
        Me.Fecha5DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Fecha5", True))
        Me.Fecha5DateTimePicker.Enabled = False
        Me.Fecha5DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha5DateTimePicker.Location = New System.Drawing.Point(446, 140)
        Me.Fecha5DateTimePicker.MaxDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.Fecha5DateTimePicker.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.Fecha5DateTimePicker.Name = "Fecha5DateTimePicker"
        Me.Fecha5DateTimePicker.Size = New System.Drawing.Size(114, 20)
        Me.Fecha5DateTimePicker.TabIndex = 345
        Me.Fecha5DateTimePicker.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'Horas5NumericUpDown
        '
        Me.Horas5NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Horas5", True))
        Me.Horas5NumericUpDown.Enabled = False
        Me.Horas5NumericUpDown.Location = New System.Drawing.Point(566, 140)
        Me.Horas5NumericUpDown.Name = "Horas5NumericUpDown"
        Me.Horas5NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.Horas5NumericUpDown.TabIndex = 347
        '
        'Horas_Extra5NumericUpDown
        '
        Me.Horas_Extra5NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Horas_Extra5", True))
        Me.Horas_Extra5NumericUpDown.Enabled = False
        Me.Horas_Extra5NumericUpDown.Location = New System.Drawing.Point(620, 140)
        Me.Horas_Extra5NumericUpDown.Name = "Horas_Extra5NumericUpDown"
        Me.Horas_Extra5NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.Horas_Extra5NumericUpDown.TabIndex = 349
        '
        'Fecha6DateTimePicker
        '
        Me.Fecha6DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Fecha6", True))
        Me.Fecha6DateTimePicker.Enabled = False
        Me.Fecha6DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha6DateTimePicker.Location = New System.Drawing.Point(446, 167)
        Me.Fecha6DateTimePicker.MaxDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.Fecha6DateTimePicker.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.Fecha6DateTimePicker.Name = "Fecha6DateTimePicker"
        Me.Fecha6DateTimePicker.Size = New System.Drawing.Size(114, 20)
        Me.Fecha6DateTimePicker.TabIndex = 357
        Me.Fecha6DateTimePicker.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'Horas6NumericUpDown
        '
        Me.Horas6NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Horas6", True))
        Me.Horas6NumericUpDown.Enabled = False
        Me.Horas6NumericUpDown.Location = New System.Drawing.Point(566, 167)
        Me.Horas6NumericUpDown.Name = "Horas6NumericUpDown"
        Me.Horas6NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.Horas6NumericUpDown.TabIndex = 359
        '
        'Horas_Extra6NumericUpDown
        '
        Me.Horas_Extra6NumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Horas_Extra6", True))
        Me.Horas_Extra6NumericUpDown.Enabled = False
        Me.Horas_Extra6NumericUpDown.Location = New System.Drawing.Point(620, 167)
        Me.Horas_Extra6NumericUpDown.Name = "Horas_Extra6NumericUpDown"
        Me.Horas_Extra6NumericUpDown.Size = New System.Drawing.Size(48, 20)
        Me.Horas_Extra6NumericUpDown.TabIndex = 361
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.NotasTextBox)
        Me.TabPage5.Controls.Add(NotasLabel)
        Me.TabPage5.Controls.Add(Fecha_CreacionLabel)
        Me.TabPage5.Controls.Add(Me.Fecha_CreacionDateTimePicker)
        Me.TabPage5.Controls.Add(Fecha_ProgramadoLabel1)
        Me.TabPage5.Controls.Add(Me.Fecha_ProgramadoDateTimePicker1)
        Me.TabPage5.Controls.Add(Fecha_LlenadoLabel)
        Me.TabPage5.Controls.Add(Me.Fecha_LlenadoDateTimePicker)
        Me.TabPage5.Controls.Add(Tecnico_EjecutanteLabel)
        Me.TabPage5.Controls.Add(Me.Tecnico_EjecutanteTextBox)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(718, 396)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Datos"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'NotasTextBox
        '
        Me.NotasTextBox.BackColor = System.Drawing.Color.White
        Me.NotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Notas", True))
        Me.NotasTextBox.Location = New System.Drawing.Point(50, 251)
        Me.NotasTextBox.Multiline = True
        Me.NotasTextBox.Name = "NotasTextBox"
        Me.NotasTextBox.Size = New System.Drawing.Size(604, 101)
        Me.NotasTextBox.TabIndex = 285
        '
        'Fecha_CreacionDateTimePicker
        '
        Me.Fecha_CreacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Fecha_Creacion", True))
        Me.Fecha_CreacionDateTimePicker.Enabled = False
        Me.Fecha_CreacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_CreacionDateTimePicker.Location = New System.Drawing.Point(123, 91)
        Me.Fecha_CreacionDateTimePicker.Name = "Fecha_CreacionDateTimePicker"
        Me.Fecha_CreacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_CreacionDateTimePicker.TabIndex = 7
        '
        'Fecha_ProgramadoDateTimePicker1
        '
        Me.Fecha_ProgramadoDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Fecha_Programado", True))
        Me.Fecha_ProgramadoDateTimePicker1.Enabled = False
        Me.Fecha_ProgramadoDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_ProgramadoDateTimePicker1.Location = New System.Drawing.Point(123, 127)
        Me.Fecha_ProgramadoDateTimePicker1.Name = "Fecha_ProgramadoDateTimePicker1"
        Me.Fecha_ProgramadoDateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_ProgramadoDateTimePicker1.TabIndex = 5
        '
        'Fecha_LlenadoDateTimePicker
        '
        Me.Fecha_LlenadoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Fecha_Llenado", True))
        Me.Fecha_LlenadoDateTimePicker.Enabled = False
        Me.Fecha_LlenadoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_LlenadoDateTimePicker.Location = New System.Drawing.Point(123, 163)
        Me.Fecha_LlenadoDateTimePicker.Name = "Fecha_LlenadoDateTimePicker"
        Me.Fecha_LlenadoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_LlenadoDateTimePicker.TabIndex = 3
        '
        'Tecnico_EjecutanteTextBox
        '
        Me.Tecnico_EjecutanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Tecnico_Ejecutante", True))
        Me.Tecnico_EjecutanteTextBox.Location = New System.Drawing.Point(123, 50)
        Me.Tecnico_EjecutanteTextBox.Name = "Tecnico_EjecutanteTextBox"
        Me.Tecnico_EjecutanteTextBox.ReadOnly = True
        Me.Tecnico_EjecutanteTextBox.Size = New System.Drawing.Size(280, 20)
        Me.Tecnico_EjecutanteTextBox.TabIndex = 1
        '
        'Cod_OTComboBox
        '
        Me.Cod_OTComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Cod_OT", True))
        Me.Cod_OTComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cod_OTComboBox.FormattingEnabled = True
        Me.Cod_OTComboBox.Location = New System.Drawing.Point(66, 62)
        Me.Cod_OTComboBox.Name = "Cod_OTComboBox"
        Me.Cod_OTComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cod_OTComboBox.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Validar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(368, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Corregir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(659, 62)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Regresar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OMTableAdapter
        '
        Me.OMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.Estrategia_de_MantenimientoTableAdapter = Nothing
        Me.TableAdapterManager.Modos_de_FallaTableAdapter = Nothing
        Me.TableAdapterManager.OMTableAdapter = Me.OMTableAdapter
        Me.TableAdapterManager.RutinasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ASIMA.EstrategiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(602, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(132, 51)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 44
        Me.PictureBox5.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(222, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(298, 51)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "OT"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Ordenes_Validar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 524)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Cod_OTLabel)
        Me.Controls.Add(Me.Cod_OTComboBox)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.OMBindingNavigator)
        Me.Name = "Ordenes_Validar"
        Me.Text = "Ordenes_Validar"
        CType(Me.OMBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OMBindingNavigator.ResumeLayout(False)
        Me.OMBindingNavigator.PerformLayout()
        CType(Me.OMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstrategiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Duracion_planeadaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Duracion_EjecucionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas_paroNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.Cantidad_Usada2NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cantidad_Requerida2NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cantidad_Usada3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cantidad_Requerida3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cantidad_Usada4NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cantidad_Requerida4NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cantidad_Usada5NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cantidad_Requerida5NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cantidad_Usada1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cantidad_Requerida1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tiempo_Fuera_Servicio1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tiempo_Reparacion1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tiempo_Fuera_Servicio2NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tiempo_Reparacion2NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.CATMNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DESPNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERMNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AHERNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPUBNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSEGNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DISPNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HERRNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPUNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECUNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAPANumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AISLNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAUDNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTRONumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tiempo_totalNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas_Extra1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas2NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas_Extra2NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas_Extra3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas4NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas_Extra4NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas5NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas_Extra5NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas6NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas_Extra6NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EstrategiaDataSet As EstrategiaDataSet
    Friend WithEvents OMBindingSource As BindingSource
    Friend WithEvents OMTableAdapter As EstrategiaDataSetTableAdapters.OMTableAdapter
    Friend WithEvents TableAdapterManager As EstrategiaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OMBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents OMBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OriginadorTextBox As TextBox
    Friend WithEvents PrioridadTextBox As TextBox
    Friend WithEvents Descripcion_ActividadTextBox As TextBox
    Friend WithEvents Duracion_planeadaNumericUpDown As NumericUpDown
    Friend WithEvents Fecha_ProgramadoDateTimePicker As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TAGTextBox As TextBox
    Friend WithEvents Tipo_EquipoTextBox As TextBox
    Friend WithEvents Familia_EquipoTextBox As TextBox
    Friend WithEvents SubFuncionTextBox As TextBox
    Friend WithEvents SistemaTextBox As TextBox
    Friend WithEvents PlantaTextBox As TextBox
    Friend WithEvents Unidad_NegocioTextBox As TextBox
    Friend WithEvents Tipo_OTTextBox As TextBox
    Friend WithEvents EspecialidadTextBox As TextBox
    Friend WithEvents Cod_OTTextBox As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Como_quedoTextBox As TextBox
    Friend WithEvents Actividad_RealizadaTextBox As TextBox
    Friend WithEvents Como_encontroTextBox As TextBox
    Friend WithEvents Duracion_EjecucionNumericUpDown As NumericUpDown
    Friend WithEvents Horas_paroNumericUpDown As NumericUpDown
    Friend WithEvents Hora_Ejecucion_FinDateTimePicker As DateTimePicker
    Friend WithEvents Hora_Ejecucion_InicioDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_Ejecucion_FinDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_Ejecucion_InicioDateTimePicker As DateTimePicker
    Friend WithEvents Permiso_TrabajoTextBox As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Modo_de_Falla2TextBox As TextBox
    Friend WithEvents Modo_de_Falla1TextBox As TextBox
    Friend WithEvents N_Articulo2TextBox As TextBox
    Friend WithEvents ParteNumero2TextBox As TextBox
    Friend WithEvents Unidad_Medida2TextBox As TextBox
    Friend WithEvents Descripcion_Repuesto2TextBox As TextBox
    Friend WithEvents Cantidad_Usada2NumericUpDown As NumericUpDown
    Friend WithEvents Cantidad_Requerida2NumericUpDown As NumericUpDown
    Friend WithEvents N_Requerimiento2TextBox As TextBox
    Friend WithEvents N_Articulo3TextBox As TextBox
    Friend WithEvents ParteNumero3TextBox As TextBox
    Friend WithEvents Unidad_Medida3TextBox As TextBox
    Friend WithEvents Descripcion_Repuesto3TextBox As TextBox
    Friend WithEvents Cantidad_Usada3NumericUpDown As NumericUpDown
    Friend WithEvents Cantidad_Requerida3NumericUpDown As NumericUpDown
    Friend WithEvents N_Requerimiento3TextBox As TextBox
    Friend WithEvents N_Articulo4TextBox As TextBox
    Friend WithEvents ParteNumero4TextBox As TextBox
    Friend WithEvents Unidad_Medida4TextBox As TextBox
    Friend WithEvents Descripcion_Repuesto4TextBox As TextBox
    Friend WithEvents Cantidad_Usada4NumericUpDown As NumericUpDown
    Friend WithEvents Cantidad_Requerida4NumericUpDown As NumericUpDown
    Friend WithEvents N_Requerimiento4TextBox As TextBox
    Friend WithEvents N_Articulo5TextBox As TextBox
    Friend WithEvents ParteNumero5TextBox As TextBox
    Friend WithEvents Unidad_Medida5TextBox As TextBox
    Friend WithEvents Descripcion_Repuesto5TextBox As TextBox
    Friend WithEvents Cantidad_Usada5NumericUpDown As NumericUpDown
    Friend WithEvents Cantidad_Requerida5NumericUpDown As NumericUpDown
    Friend WithEvents N_Requerimiento5TextBox As TextBox
    Friend WithEvents RecomendacionesTextBox As TextBox
    Friend WithEvents N_Articulo1TextBox As TextBox
    Friend WithEvents ParteNumero1TextBox As TextBox
    Friend WithEvents Unidad_Medida1TextBox As TextBox
    Friend WithEvents Descripcion_Repuesto1TextBox As TextBox
    Friend WithEvents Cantidad_Usada1NumericUpDown As NumericUpDown
    Friend WithEvents Cantidad_Requerida1NumericUpDown As NumericUpDown
    Friend WithEvents N_Requerimiento1TextBox As TextBox
    Friend WithEvents Causa_MF1TextBox As TextBox
    Friend WithEvents Tiempo_Fuera_Servicio1NumericUpDown As NumericUpDown
    Friend WithEvents Tiempo_Reparacion1NumericUpDown As NumericUpDown
    Friend WithEvents Afecta_Disponibilidad1CheckBox As CheckBox
    Friend WithEvents Causa_MF2TextBox As TextBox
    Friend WithEvents Tiempo_Fuera_Servicio2NumericUpDown As NumericUpDown
    Friend WithEvents Tiempo_Reparacion2NumericUpDown As NumericUpDown
    Friend WithEvents Afecta_Disponibilidad2CheckBox As CheckBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents NombreTecnico6TextBox As TextBox
    Friend WithEvents NombreTecnico5TextBox As TextBox
    Friend WithEvents NombreTecnico4TextBox As TextBox
    Friend WithEvents NombreTecnico3TextBox As TextBox
    Friend WithEvents NombreTecnico2TextBox As TextBox
    Friend WithEvents NombreTecnico1TextBox As TextBox
    Friend WithEvents Especialidad6TextBox As TextBox
    Friend WithEvents Cargo6TextBox As TextBox
    Friend WithEvents Especialidad5TextBox As TextBox
    Friend WithEvents Cargo5TextBox As TextBox
    Friend WithEvents Especialidad4TextBox As TextBox
    Friend WithEvents Cargo4TextBox As TextBox
    Friend WithEvents Especialidad3TextBox As TextBox
    Friend WithEvents Cargo3TextBox As TextBox
    Friend WithEvents Especialidad2TextBox As TextBox
    Friend WithEvents Cargo2TextBox As TextBox
    Friend WithEvents Especialidad1TextBox As TextBox
    Friend WithEvents Cargo1TextBox As TextBox
    Friend WithEvents CATMNumericUpDown As NumericUpDown
    Friend WithEvents DESPNumericUpDown As NumericUpDown
    Friend WithEvents PERMNumericUpDown As NumericUpDown
    Friend WithEvents AHERNumericUpDown As NumericUpDown
    Friend WithEvents OPUBNumericUpDown As NumericUpDown
    Friend WithEvents CSEGNumericUpDown As NumericUpDown
    Friend WithEvents DISPNumericUpDown As NumericUpDown
    Friend WithEvents HERRNumericUpDown As NumericUpDown
    Friend WithEvents REPUNumericUpDown As NumericUpDown
    Friend WithEvents RECUNumericUpDown As NumericUpDown
    Friend WithEvents CAPANumericUpDown As NumericUpDown
    Friend WithEvents AISLNumericUpDown As NumericUpDown
    Friend WithEvents DAUDNumericUpDown As NumericUpDown
    Friend WithEvents OTRONumericUpDown As NumericUpDown
    Friend WithEvents Tiempo_totalNumericUpDown As NumericUpDown
    Friend WithEvents Fecha1DateTimePicker As DateTimePicker
    Friend WithEvents Horas1NumericUpDown As NumericUpDown
    Friend WithEvents Horas_Extra1NumericUpDown As NumericUpDown
    Friend WithEvents Fecha2DateTimePicker As DateTimePicker
    Friend WithEvents Horas2NumericUpDown As NumericUpDown
    Friend WithEvents Horas_Extra2NumericUpDown As NumericUpDown
    Friend WithEvents Fecha3DateTimePicker As DateTimePicker
    Friend WithEvents Horas3NumericUpDown As NumericUpDown
    Friend WithEvents Horas_Extra3NumericUpDown As NumericUpDown
    Friend WithEvents Fecha4DateTimePicker As DateTimePicker
    Friend WithEvents Horas4NumericUpDown As NumericUpDown
    Friend WithEvents Horas_Extra4NumericUpDown As NumericUpDown
    Friend WithEvents Fecha5DateTimePicker As DateTimePicker
    Friend WithEvents Horas5NumericUpDown As NumericUpDown
    Friend WithEvents Horas_Extra5NumericUpDown As NumericUpDown
    Friend WithEvents Fecha6DateTimePicker As DateTimePicker
    Friend WithEvents Horas6NumericUpDown As NumericUpDown
    Friend WithEvents Horas_Extra6NumericUpDown As NumericUpDown
    Friend WithEvents Cod_OTComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Fecha_CreacionDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_ProgramadoDateTimePicker1 As DateTimePicker
    Friend WithEvents Fecha_LlenadoDateTimePicker As DateTimePicker
    Friend WithEvents Tecnico_EjecutanteTextBox As TextBox
    Friend WithEvents NotasTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label9 As Label
End Class
