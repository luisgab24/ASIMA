<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordenes_Nueva
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
        Dim EspecialidadLabel As System.Windows.Forms.Label
        Dim Tipo_OTLabel As System.Windows.Forms.Label
        Dim Unidad_NegocioLabel As System.Windows.Forms.Label
        Dim PlantaLabel As System.Windows.Forms.Label
        Dim SistemaLabel As System.Windows.Forms.Label
        Dim SubFuncionLabel As System.Windows.Forms.Label
        Dim Familia_EquipoLabel As System.Windows.Forms.Label
        Dim Tipo_EquipoLabel As System.Windows.Forms.Label
        Dim TAGLabel As System.Windows.Forms.Label
        Dim PrioridadLabel As System.Windows.Forms.Label
        Dim OriginadorLabel As System.Windows.Forms.Label
        Dim Descripcion_ActividadLabel As System.Windows.Forms.Label
        Dim Duracion_planeadaLabel As System.Windows.Forms.Label
        Dim Fecha_ProgramadoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ordenes_Nueva))
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
        Me.EspecialidadComboBox = New System.Windows.Forms.ComboBox()
        Me.Tipo_OTComboBox = New System.Windows.Forms.ComboBox()
        Me.Unidad_NegocioComboBox = New System.Windows.Forms.ComboBox()
        Me.PlantaComboBox = New System.Windows.Forms.ComboBox()
        Me.SistemaComboBox = New System.Windows.Forms.ComboBox()
        Me.SubFuncionComboBox = New System.Windows.Forms.ComboBox()
        Me.Familia_EquipoComboBox = New System.Windows.Forms.ComboBox()
        Me.Tipo_EquipoComboBox = New System.Windows.Forms.ComboBox()
        Me.PrioridadComboBox = New System.Windows.Forms.ComboBox()
        Me.Descripcion_ActividadTextBox = New System.Windows.Forms.TextBox()
        Me.Duracion_planeadaNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Fecha_ProgramadoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TAGComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OriginadorLabel2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OMTableAdapter = New ASIMA.EstrategiaDataSetTableAdapters.OMTableAdapter()
        Me.TableAdapterManager = New ASIMA.EstrategiaDataSetTableAdapters.TableAdapterManager()
        Me.Estrategia_de_MantenimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Estrategia_de_MantenimientoTableAdapter = New ASIMA.EstrategiaDataSetTableAdapters.Estrategia_de_MantenimientoTableAdapter()
        EspecialidadLabel = New System.Windows.Forms.Label()
        Tipo_OTLabel = New System.Windows.Forms.Label()
        Unidad_NegocioLabel = New System.Windows.Forms.Label()
        PlantaLabel = New System.Windows.Forms.Label()
        SistemaLabel = New System.Windows.Forms.Label()
        SubFuncionLabel = New System.Windows.Forms.Label()
        Familia_EquipoLabel = New System.Windows.Forms.Label()
        Tipo_EquipoLabel = New System.Windows.Forms.Label()
        TAGLabel = New System.Windows.Forms.Label()
        PrioridadLabel = New System.Windows.Forms.Label()
        OriginadorLabel = New System.Windows.Forms.Label()
        Descripcion_ActividadLabel = New System.Windows.Forms.Label()
        Duracion_planeadaLabel = New System.Windows.Forms.Label()
        Fecha_ProgramadoLabel = New System.Windows.Forms.Label()
        CType(Me.OMBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OMBindingNavigator.SuspendLayout()
        CType(Me.OMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstrategiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Duracion_planeadaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Estrategia_de_MantenimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.OMBindingNavigator.Size = New System.Drawing.Size(658, 25)
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
        'EspecialidadComboBox
        '
        Me.EspecialidadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Especialidad", True))
        Me.EspecialidadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EspecialidadComboBox.FormattingEnabled = True
        Me.EspecialidadComboBox.Location = New System.Drawing.Point(123, 22)
        Me.EspecialidadComboBox.Name = "EspecialidadComboBox"
        Me.EspecialidadComboBox.Size = New System.Drawing.Size(138, 21)
        Me.EspecialidadComboBox.TabIndex = 4
        '
        'Tipo_OTComboBox
        '
        Me.Tipo_OTComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Tipo_OT", True))
        Me.Tipo_OTComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tipo_OTComboBox.FormattingEnabled = True
        Me.Tipo_OTComboBox.Location = New System.Drawing.Point(123, 49)
        Me.Tipo_OTComboBox.Name = "Tipo_OTComboBox"
        Me.Tipo_OTComboBox.Size = New System.Drawing.Size(138, 21)
        Me.Tipo_OTComboBox.TabIndex = 6
        '
        'Unidad_NegocioComboBox
        '
        Me.Unidad_NegocioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Unidad_Negocio", True))
        Me.Unidad_NegocioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Unidad_NegocioComboBox.FormattingEnabled = True
        Me.Unidad_NegocioComboBox.Location = New System.Drawing.Point(123, 102)
        Me.Unidad_NegocioComboBox.Name = "Unidad_NegocioComboBox"
        Me.Unidad_NegocioComboBox.Size = New System.Drawing.Size(138, 21)
        Me.Unidad_NegocioComboBox.TabIndex = 10
        '
        'PlantaComboBox
        '
        Me.PlantaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Planta", True))
        Me.PlantaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlantaComboBox.FormattingEnabled = True
        Me.PlantaComboBox.Location = New System.Drawing.Point(123, 129)
        Me.PlantaComboBox.Name = "PlantaComboBox"
        Me.PlantaComboBox.Size = New System.Drawing.Size(138, 21)
        Me.PlantaComboBox.TabIndex = 12
        '
        'SistemaComboBox
        '
        Me.SistemaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Sistema", True))
        Me.SistemaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SistemaComboBox.FormattingEnabled = True
        Me.SistemaComboBox.Location = New System.Drawing.Point(374, 22)
        Me.SistemaComboBox.Name = "SistemaComboBox"
        Me.SistemaComboBox.Size = New System.Drawing.Size(241, 21)
        Me.SistemaComboBox.TabIndex = 14
        '
        'SubFuncionComboBox
        '
        Me.SubFuncionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "SubFuncion", True))
        Me.SubFuncionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubFuncionComboBox.FormattingEnabled = True
        Me.SubFuncionComboBox.Location = New System.Drawing.Point(374, 49)
        Me.SubFuncionComboBox.Name = "SubFuncionComboBox"
        Me.SubFuncionComboBox.Size = New System.Drawing.Size(241, 21)
        Me.SubFuncionComboBox.TabIndex = 16
        '
        'Familia_EquipoComboBox
        '
        Me.Familia_EquipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Familia_Equipo", True))
        Me.Familia_EquipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Familia_EquipoComboBox.FormattingEnabled = True
        Me.Familia_EquipoComboBox.Location = New System.Drawing.Point(374, 76)
        Me.Familia_EquipoComboBox.Name = "Familia_EquipoComboBox"
        Me.Familia_EquipoComboBox.Size = New System.Drawing.Size(241, 21)
        Me.Familia_EquipoComboBox.TabIndex = 18
        '
        'Tipo_EquipoComboBox
        '
        Me.Tipo_EquipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Tipo_Equipo", True))
        Me.Tipo_EquipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tipo_EquipoComboBox.FormattingEnabled = True
        Me.Tipo_EquipoComboBox.Location = New System.Drawing.Point(374, 103)
        Me.Tipo_EquipoComboBox.Name = "Tipo_EquipoComboBox"
        Me.Tipo_EquipoComboBox.Size = New System.Drawing.Size(241, 21)
        Me.Tipo_EquipoComboBox.TabIndex = 20
        '
        'PrioridadComboBox
        '
        Me.PrioridadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Prioridad", True))
        Me.PrioridadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PrioridadComboBox.FormattingEnabled = True
        Me.PrioridadComboBox.Location = New System.Drawing.Point(123, 19)
        Me.PrioridadComboBox.Name = "PrioridadComboBox"
        Me.PrioridadComboBox.Size = New System.Drawing.Size(138, 21)
        Me.PrioridadComboBox.TabIndex = 24
        '
        'Descripcion_ActividadTextBox
        '
        Me.Descripcion_ActividadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Descripcion_Actividad", True))
        Me.Descripcion_ActividadTextBox.Location = New System.Drawing.Point(123, 46)
        Me.Descripcion_ActividadTextBox.Multiline = True
        Me.Descripcion_ActividadTextBox.Name = "Descripcion_ActividadTextBox"
        Me.Descripcion_ActividadTextBox.Size = New System.Drawing.Size(492, 60)
        Me.Descripcion_ActividadTextBox.TabIndex = 28
        '
        'Duracion_planeadaNumericUpDown
        '
        Me.Duracion_planeadaNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Duracion_planeada", True))
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
        Me.Fecha_ProgramadoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_ProgramadoDateTimePicker.Location = New System.Drawing.Point(436, 112)
        Me.Fecha_ProgramadoDateTimePicker.Name = "Fecha_ProgramadoDateTimePicker"
        Me.Fecha_ProgramadoDateTimePicker.Size = New System.Drawing.Size(179, 20)
        Me.Fecha_ProgramadoDateTimePicker.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(485, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Crear OT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(566, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(EspecialidadLabel)
        Me.GroupBox1.Controls.Add(Me.EspecialidadComboBox)
        Me.GroupBox1.Controls.Add(Tipo_OTLabel)
        Me.GroupBox1.Controls.Add(Me.Tipo_OTComboBox)
        Me.GroupBox1.Controls.Add(Unidad_NegocioLabel)
        Me.GroupBox1.Controls.Add(Me.Unidad_NegocioComboBox)
        Me.GroupBox1.Controls.Add(PlantaLabel)
        Me.GroupBox1.Controls.Add(Me.PlantaComboBox)
        Me.GroupBox1.Controls.Add(SistemaLabel)
        Me.GroupBox1.Controls.Add(Me.SistemaComboBox)
        Me.GroupBox1.Controls.Add(SubFuncionLabel)
        Me.GroupBox1.Controls.Add(Me.SubFuncionComboBox)
        Me.GroupBox1.Controls.Add(Familia_EquipoLabel)
        Me.GroupBox1.Controls.Add(Me.Familia_EquipoComboBox)
        Me.GroupBox1.Controls.Add(Tipo_EquipoLabel)
        Me.GroupBox1.Controls.Add(Me.Tipo_EquipoComboBox)
        Me.GroupBox1.Controls.Add(TAGLabel)
        Me.GroupBox1.Controls.Add(Me.TAGComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 170)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'TAGComboBox
        '
        Me.TAGComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "TAG", True))
        Me.TAGComboBox.FormattingEnabled = True
        Me.TAGComboBox.Location = New System.Drawing.Point(374, 130)
        Me.TAGComboBox.Name = "TAGComboBox"
        Me.TAGComboBox.Size = New System.Drawing.Size(179, 21)
        Me.TAGComboBox.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OriginadorLabel2)
        Me.GroupBox2.Controls.Add(PrioridadLabel)
        Me.GroupBox2.Controls.Add(Me.PrioridadComboBox)
        Me.GroupBox2.Controls.Add(OriginadorLabel)
        Me.GroupBox2.Controls.Add(Descripcion_ActividadLabel)
        Me.GroupBox2.Controls.Add(Me.Descripcion_ActividadTextBox)
        Me.GroupBox2.Controls.Add(Duracion_planeadaLabel)
        Me.GroupBox2.Controls.Add(Me.Duracion_planeadaNumericUpDown)
        Me.GroupBox2.Controls.Add(Fecha_ProgramadoLabel)
        Me.GroupBox2.Controls.Add(Me.Fecha_ProgramadoDateTimePicker)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 157)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'OriginadorLabel2
        '
        Me.OriginadorLabel2.BackColor = System.Drawing.Color.White
        Me.OriginadorLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Originador", True))
        Me.OriginadorLabel2.Location = New System.Drawing.Point(424, 20)
        Me.OriginadorLabel2.Name = "OriginadorLabel2"
        Me.OriginadorLabel2.Size = New System.Drawing.Size(191, 20)
        Me.OriginadorLabel2.TabIndex = 36
        Me.OriginadorLabel2.Text = "Label4"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(509, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(132, 51)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 39
        Me.PictureBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(186, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 51)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "OT"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Label3"
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
        'Estrategia_de_MantenimientoBindingSource
        '
        Me.Estrategia_de_MantenimientoBindingSource.DataMember = "Estrategia de Mantenimiento"
        Me.Estrategia_de_MantenimientoBindingSource.DataSource = Me.EstrategiaDataSet
        '
        'Estrategia_de_MantenimientoTableAdapter
        '
        Me.Estrategia_de_MantenimientoTableAdapter.ClearBeforeFill = True
        '
        'Ordenes_Nueva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(658, 448)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OMBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ordenes_Nueva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenes_Nueva"
        CType(Me.OMBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OMBindingNavigator.ResumeLayout(False)
        Me.OMBindingNavigator.PerformLayout()
        CType(Me.OMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstrategiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Duracion_planeadaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Estrategia_de_MantenimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents EspecialidadComboBox As ComboBox
    Friend WithEvents Tipo_OTComboBox As ComboBox
    Friend WithEvents Unidad_NegocioComboBox As ComboBox
    Friend WithEvents PlantaComboBox As ComboBox
    Friend WithEvents SistemaComboBox As ComboBox
    Friend WithEvents SubFuncionComboBox As ComboBox
    Friend WithEvents Familia_EquipoComboBox As ComboBox
    Friend WithEvents Tipo_EquipoComboBox As ComboBox
    Friend WithEvents PrioridadComboBox As ComboBox
    Friend WithEvents Descripcion_ActividadTextBox As TextBox
    Friend WithEvents Duracion_planeadaNumericUpDown As NumericUpDown
    Friend WithEvents Fecha_ProgramadoDateTimePicker As DateTimePicker
    Friend WithEvents Estrategia_de_MantenimientoBindingSource As BindingSource
    Friend WithEvents Estrategia_de_MantenimientoTableAdapter As EstrategiaDataSetTableAdapters.Estrategia_de_MantenimientoTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TAGComboBox As ComboBox
    Friend WithEvents OriginadorLabel2 As Label
End Class
