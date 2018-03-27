<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MFalla
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
        Dim DisciplinaLabel As System.Windows.Forms.Label
        Dim Código_GrupoLabel As System.Windows.Forms.Label
        Dim Código_Modo_FallaLabel As System.Windows.Forms.Label
        Dim Modo_de_DeteccionLabel As System.Windows.Forms.Label
        Dim Causa_de_Modo_de_FallaLabel As System.Windows.Forms.Label
        Dim Criticidad_Modo_de_FallaLabel As System.Windows.Forms.Label
        Dim Tipo_de_TareaLabel As System.Windows.Forms.Label
        Dim Descripción_de_la_Actividad_CorrectivaLabel As System.Windows.Forms.Label
        Dim Fallas___AñoLabel As System.Windows.Forms.Label
        Dim Duracion__Mins_Label As System.Windows.Forms.Label
        Dim Htas_Especiales_1Label As System.Windows.Forms.Label
        Dim Htas_Especiales_2Label As System.Windows.Forms.Label
        Dim Htas_Especiales_3Label As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim Htas_Especiales_4Label As System.Windows.Forms.Label
        Dim Tipo_AislamientoLabel As System.Windows.Forms.Label
        Dim Familia__Nivel_6_Label1 As System.Windows.Forms.Label
        Dim Tipo_Equipo__Nivel_7_Label1 As System.Windows.Forms.Label
        Dim Modo_FallaLabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MFalla))
        Me.DisciplinaTextBox = New System.Windows.Forms.TextBox()
        Me.Modos_de_FallaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstrategiaDataSet = New ASIMA.EstrategiaDataSet()
        Me.Código_GrupoTextBox = New System.Windows.Forms.TextBox()
        Me.Código_Modo_FallaTextBox = New System.Windows.Forms.TextBox()
        Me.Modo_de_DeteccionTextBox = New System.Windows.Forms.TextBox()
        Me.Causa_de_Modo_de_FallaTextBox = New System.Windows.Forms.TextBox()
        Me.Criticidad_Modo_de_FallaTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_de_TareaTextBox = New System.Windows.Forms.TextBox()
        Me.Descripción_de_la_Actividad_CorrectivaTextBox = New System.Windows.Forms.TextBox()
        Me.Fallas___AñoTextBox = New System.Windows.Forms.TextBox()
        Me.Duracion__Mins_TextBox = New System.Windows.Forms.TextBox()
        Me.Htas_Especiales_1TextBox = New System.Windows.Forms.TextBox()
        Me.Htas_Especiales_2TextBox = New System.Windows.Forms.TextBox()
        Me.Htas_Especiales_3TextBox = New System.Windows.Forms.TextBox()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.Htas_Especiales_4TextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_AislamientoTextBox = New System.Windows.Forms.TextBox()
        Me.Familia__Nivel_6_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Tipo_Equipo__Nivel_7_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Modo_FallaComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Modos_de_FallaTableAdapter = New ASIMA.EstrategiaDataSetTableAdapters.Modos_de_FallaTableAdapter()
        Me.TableAdapterManager = New ASIMA.EstrategiaDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        DisciplinaLabel = New System.Windows.Forms.Label()
        Código_GrupoLabel = New System.Windows.Forms.Label()
        Código_Modo_FallaLabel = New System.Windows.Forms.Label()
        Modo_de_DeteccionLabel = New System.Windows.Forms.Label()
        Causa_de_Modo_de_FallaLabel = New System.Windows.Forms.Label()
        Criticidad_Modo_de_FallaLabel = New System.Windows.Forms.Label()
        Tipo_de_TareaLabel = New System.Windows.Forms.Label()
        Descripción_de_la_Actividad_CorrectivaLabel = New System.Windows.Forms.Label()
        Fallas___AñoLabel = New System.Windows.Forms.Label()
        Duracion__Mins_Label = New System.Windows.Forms.Label()
        Htas_Especiales_1Label = New System.Windows.Forms.Label()
        Htas_Especiales_2Label = New System.Windows.Forms.Label()
        Htas_Especiales_3Label = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        Htas_Especiales_4Label = New System.Windows.Forms.Label()
        Tipo_AislamientoLabel = New System.Windows.Forms.Label()
        Familia__Nivel_6_Label1 = New System.Windows.Forms.Label()
        Tipo_Equipo__Nivel_7_Label1 = New System.Windows.Forms.Label()
        Modo_FallaLabel1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.Modos_de_FallaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstrategiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisciplinaLabel
        '
        DisciplinaLabel.AutoSize = True
        DisciplinaLabel.Location = New System.Drawing.Point(52, 186)
        DisciplinaLabel.Name = "DisciplinaLabel"
        DisciplinaLabel.Size = New System.Drawing.Size(55, 13)
        DisciplinaLabel.TabIndex = 3
        DisciplinaLabel.Text = "Disciplina:"
        '
        'Código_GrupoLabel
        '
        Código_GrupoLabel.AutoSize = True
        Código_GrupoLabel.Location = New System.Drawing.Point(32, 214)
        Código_GrupoLabel.Name = "Código_GrupoLabel"
        Código_GrupoLabel.Size = New System.Drawing.Size(75, 13)
        Código_GrupoLabel.TabIndex = 9
        Código_GrupoLabel.Text = "Código Grupo:"
        '
        'Código_Modo_FallaLabel
        '
        Código_Modo_FallaLabel.AutoSize = True
        Código_Modo_FallaLabel.Location = New System.Drawing.Point(9, 240)
        Código_Modo_FallaLabel.Name = "Código_Modo_FallaLabel"
        Código_Modo_FallaLabel.Size = New System.Drawing.Size(98, 13)
        Código_Modo_FallaLabel.TabIndex = 11
        Código_Modo_FallaLabel.Text = "Código Modo Falla:"
        '
        'Modo_de_DeteccionLabel
        '
        Modo_de_DeteccionLabel.AutoSize = True
        Modo_de_DeteccionLabel.Location = New System.Drawing.Point(376, 192)
        Modo_de_DeteccionLabel.Name = "Modo_de_DeteccionLabel"
        Modo_de_DeteccionLabel.Size = New System.Drawing.Size(104, 13)
        Modo_de_DeteccionLabel.TabIndex = 15
        Modo_de_DeteccionLabel.Text = "Modo de Deteccion:"
        '
        'Causa_de_Modo_de_FallaLabel
        '
        Causa_de_Modo_de_FallaLabel.AutoSize = True
        Causa_de_Modo_de_FallaLabel.Location = New System.Drawing.Point(355, 218)
        Causa_de_Modo_de_FallaLabel.Name = "Causa_de_Modo_de_FallaLabel"
        Causa_de_Modo_de_FallaLabel.Size = New System.Drawing.Size(125, 13)
        Causa_de_Modo_de_FallaLabel.TabIndex = 17
        Causa_de_Modo_de_FallaLabel.Text = "Causa de Modo de Falla:"
        '
        'Criticidad_Modo_de_FallaLabel
        '
        Criticidad_Modo_de_FallaLabel.AutoSize = True
        Criticidad_Modo_de_FallaLabel.Location = New System.Drawing.Point(357, 240)
        Criticidad_Modo_de_FallaLabel.Name = "Criticidad_Modo_de_FallaLabel"
        Criticidad_Modo_de_FallaLabel.Size = New System.Drawing.Size(123, 13)
        Criticidad_Modo_de_FallaLabel.TabIndex = 19
        Criticidad_Modo_de_FallaLabel.Text = "Criticidad Modo de Falla:"
        '
        'Tipo_de_TareaLabel
        '
        Tipo_de_TareaLabel.AutoSize = True
        Tipo_de_TareaLabel.Location = New System.Drawing.Point(28, 272)
        Tipo_de_TareaLabel.Name = "Tipo_de_TareaLabel"
        Tipo_de_TareaLabel.Size = New System.Drawing.Size(77, 13)
        Tipo_de_TareaLabel.TabIndex = 21
        Tipo_de_TareaLabel.Text = "Tipo de Tarea:"
        '
        'Descripción_de_la_Actividad_CorrectivaLabel
        '
        Descripción_de_la_Actividad_CorrectivaLabel.AutoSize = True
        Descripción_de_la_Actividad_CorrectivaLabel.Location = New System.Drawing.Point(18, 291)
        Descripción_de_la_Actividad_CorrectivaLabel.Name = "Descripción_de_la_Actividad_CorrectivaLabel"
        Descripción_de_la_Actividad_CorrectivaLabel.Size = New System.Drawing.Size(89, 13)
        Descripción_de_la_Actividad_CorrectivaLabel.TabIndex = 23
        Descripción_de_la_Actividad_CorrectivaLabel.Text = "Descripción de la"
        '
        'Fallas___AñoLabel
        '
        Fallas___AñoLabel.AutoSize = True
        Fallas___AñoLabel.Location = New System.Drawing.Point(38, 324)
        Fallas___AñoLabel.Name = "Fallas___AñoLabel"
        Fallas___AñoLabel.Size = New System.Drawing.Size(67, 13)
        Fallas___AñoLabel.TabIndex = 25
        Fallas___AñoLabel.Text = "Fallas / Año:"
        '
        'Duracion__Mins_Label
        '
        Duracion__Mins_Label.AutoSize = True
        Duracion__Mins_Label.Location = New System.Drawing.Point(23, 349)
        Duracion__Mins_Label.Name = "Duracion__Mins_Label"
        Duracion__Mins_Label.Size = New System.Drawing.Size(84, 13)
        Duracion__Mins_Label.TabIndex = 27
        Duracion__Mins_Label.Text = "Duracion (Mins):"
        '
        'Htas_Especiales_1Label
        '
        Htas_Especiales_1Label.AutoSize = True
        Htas_Especiales_1Label.Location = New System.Drawing.Point(385, 268)
        Htas_Especiales_1Label.Name = "Htas_Especiales_1Label"
        Htas_Especiales_1Label.Size = New System.Drawing.Size(95, 13)
        Htas_Especiales_1Label.TabIndex = 29
        Htas_Especiales_1Label.Text = "Htas Especiales 1:"
        '
        'Htas_Especiales_2Label
        '
        Htas_Especiales_2Label.AutoSize = True
        Htas_Especiales_2Label.Location = New System.Drawing.Point(385, 294)
        Htas_Especiales_2Label.Name = "Htas_Especiales_2Label"
        Htas_Especiales_2Label.Size = New System.Drawing.Size(95, 13)
        Htas_Especiales_2Label.TabIndex = 31
        Htas_Especiales_2Label.Text = "Htas Especiales 2:"
        '
        'Htas_Especiales_3Label
        '
        Htas_Especiales_3Label.AutoSize = True
        Htas_Especiales_3Label.Location = New System.Drawing.Point(385, 320)
        Htas_Especiales_3Label.Name = "Htas_Especiales_3Label"
        Htas_Especiales_3Label.Size = New System.Drawing.Size(95, 13)
        Htas_Especiales_3Label.TabIndex = 33
        Htas_Especiales_3Label.Text = "Htas Especiales 3:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(412, 375)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(68, 13)
        ComentariosLabel.TabIndex = 35
        ComentariosLabel.Text = "Comentarios:"
        '
        'Htas_Especiales_4Label
        '
        Htas_Especiales_4Label.AutoSize = True
        Htas_Especiales_4Label.Location = New System.Drawing.Point(385, 346)
        Htas_Especiales_4Label.Name = "Htas_Especiales_4Label"
        Htas_Especiales_4Label.Size = New System.Drawing.Size(95, 13)
        Htas_Especiales_4Label.TabIndex = 37
        Htas_Especiales_4Label.Text = "Htas Especiales 4:"
        '
        'Tipo_AislamientoLabel
        '
        Tipo_AislamientoLabel.AutoSize = True
        Tipo_AislamientoLabel.Location = New System.Drawing.Point(20, 375)
        Tipo_AislamientoLabel.Name = "Tipo_AislamientoLabel"
        Tipo_AislamientoLabel.Size = New System.Drawing.Size(87, 13)
        Tipo_AislamientoLabel.TabIndex = 39
        Tipo_AislamientoLabel.Text = "Tipo Aislamiento:"
        '
        'Familia__Nivel_6_Label1
        '
        Familia__Nivel_6_Label1.AutoSize = True
        Familia__Nivel_6_Label1.Location = New System.Drawing.Point(1, 25)
        Familia__Nivel_6_Label1.Name = "Familia__Nivel_6_Label1"
        Familia__Nivel_6_Label1.Size = New System.Drawing.Size(96, 13)
        Familia__Nivel_6_Label1.TabIndex = 40
        Familia__Nivel_6_Label1.Text = "1. Familia (Nivel 6):"
        '
        'Tipo_Equipo__Nivel_7_Label1
        '
        Tipo_Equipo__Nivel_7_Label1.AutoSize = True
        Tipo_Equipo__Nivel_7_Label1.Location = New System.Drawing.Point(362, 25)
        Tipo_Equipo__Nivel_7_Label1.Name = "Tipo_Equipo__Nivel_7_Label1"
        Tipo_Equipo__Nivel_7_Label1.Size = New System.Drawing.Size(121, 13)
        Tipo_Equipo__Nivel_7_Label1.TabIndex = 41
        Tipo_Equipo__Nivel_7_Label1.Text = "2. Tipo Equipo (Nivel 7):"
        '
        'Modo_FallaLabel1
        '
        Modo_FallaLabel1.AutoSize = True
        Modo_FallaLabel1.Location = New System.Drawing.Point(1, 60)
        Modo_FallaLabel1.Name = "Modo_FallaLabel1"
        Modo_FallaLabel1.Size = New System.Drawing.Size(74, 13)
        Modo_FallaLabel1.TabIndex = 44
        Modo_FallaLabel1.Text = "3. Modo Falla:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(2, 303)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(105, 13)
        Label2.TabIndex = 49
        Label2.Text = "Actividad Correctiva:"
        '
        'DisciplinaTextBox
        '
        Me.DisciplinaTextBox.BackColor = System.Drawing.Color.White
        Me.DisciplinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Disciplina", True))
        Me.DisciplinaTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DisciplinaTextBox.Location = New System.Drawing.Point(120, 183)
        Me.DisciplinaTextBox.Name = "DisciplinaTextBox"
        Me.DisciplinaTextBox.ReadOnly = True
        Me.DisciplinaTextBox.Size = New System.Drawing.Size(89, 20)
        Me.DisciplinaTextBox.TabIndex = 4
        '
        'Modos_de_FallaBindingSource
        '
        Me.Modos_de_FallaBindingSource.DataMember = "Modos de Falla"
        Me.Modos_de_FallaBindingSource.DataSource = Me.EstrategiaDataSet
        '
        'EstrategiaDataSet
        '
        Me.EstrategiaDataSet.DataSetName = "EstrategiaDataSet"
        Me.EstrategiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Código_GrupoTextBox
        '
        Me.Código_GrupoTextBox.BackColor = System.Drawing.Color.White
        Me.Código_GrupoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Código Grupo", True))
        Me.Código_GrupoTextBox.Location = New System.Drawing.Point(120, 212)
        Me.Código_GrupoTextBox.Name = "Código_GrupoTextBox"
        Me.Código_GrupoTextBox.ReadOnly = True
        Me.Código_GrupoTextBox.Size = New System.Drawing.Size(89, 20)
        Me.Código_GrupoTextBox.TabIndex = 10
        '
        'Código_Modo_FallaTextBox
        '
        Me.Código_Modo_FallaTextBox.BackColor = System.Drawing.Color.White
        Me.Código_Modo_FallaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Código Modo Falla", True))
        Me.Código_Modo_FallaTextBox.Location = New System.Drawing.Point(120, 238)
        Me.Código_Modo_FallaTextBox.Name = "Código_Modo_FallaTextBox"
        Me.Código_Modo_FallaTextBox.ReadOnly = True
        Me.Código_Modo_FallaTextBox.Size = New System.Drawing.Size(89, 20)
        Me.Código_Modo_FallaTextBox.TabIndex = 12
        '
        'Modo_de_DeteccionTextBox
        '
        Me.Modo_de_DeteccionTextBox.BackColor = System.Drawing.Color.White
        Me.Modo_de_DeteccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Modo de Deteccion", True))
        Me.Modo_de_DeteccionTextBox.Location = New System.Drawing.Point(498, 185)
        Me.Modo_de_DeteccionTextBox.Name = "Modo_de_DeteccionTextBox"
        Me.Modo_de_DeteccionTextBox.ReadOnly = True
        Me.Modo_de_DeteccionTextBox.Size = New System.Drawing.Size(247, 20)
        Me.Modo_de_DeteccionTextBox.TabIndex = 16
        '
        'Causa_de_Modo_de_FallaTextBox
        '
        Me.Causa_de_Modo_de_FallaTextBox.BackColor = System.Drawing.Color.White
        Me.Causa_de_Modo_de_FallaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Causa de Modo de Falla", True))
        Me.Causa_de_Modo_de_FallaTextBox.Location = New System.Drawing.Point(498, 211)
        Me.Causa_de_Modo_de_FallaTextBox.Name = "Causa_de_Modo_de_FallaTextBox"
        Me.Causa_de_Modo_de_FallaTextBox.ReadOnly = True
        Me.Causa_de_Modo_de_FallaTextBox.Size = New System.Drawing.Size(247, 20)
        Me.Causa_de_Modo_de_FallaTextBox.TabIndex = 18
        '
        'Criticidad_Modo_de_FallaTextBox
        '
        Me.Criticidad_Modo_de_FallaTextBox.BackColor = System.Drawing.Color.White
        Me.Criticidad_Modo_de_FallaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Criticidad Modo de Falla", True))
        Me.Criticidad_Modo_de_FallaTextBox.Location = New System.Drawing.Point(498, 237)
        Me.Criticidad_Modo_de_FallaTextBox.Name = "Criticidad_Modo_de_FallaTextBox"
        Me.Criticidad_Modo_de_FallaTextBox.ReadOnly = True
        Me.Criticidad_Modo_de_FallaTextBox.Size = New System.Drawing.Size(247, 20)
        Me.Criticidad_Modo_de_FallaTextBox.TabIndex = 20
        '
        'Tipo_de_TareaTextBox
        '
        Me.Tipo_de_TareaTextBox.BackColor = System.Drawing.Color.White
        Me.Tipo_de_TareaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Tipo de Tarea", True))
        Me.Tipo_de_TareaTextBox.Location = New System.Drawing.Point(121, 268)
        Me.Tipo_de_TareaTextBox.Name = "Tipo_de_TareaTextBox"
        Me.Tipo_de_TareaTextBox.ReadOnly = True
        Me.Tipo_de_TareaTextBox.Size = New System.Drawing.Size(220, 20)
        Me.Tipo_de_TareaTextBox.TabIndex = 22
        '
        'Descripción_de_la_Actividad_CorrectivaTextBox
        '
        Me.Descripción_de_la_Actividad_CorrectivaTextBox.BackColor = System.Drawing.Color.White
        Me.Descripción_de_la_Actividad_CorrectivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Descripción de la Actividad Correctiva", True))
        Me.Descripción_de_la_Actividad_CorrectivaTextBox.Location = New System.Drawing.Point(121, 294)
        Me.Descripción_de_la_Actividad_CorrectivaTextBox.Name = "Descripción_de_la_Actividad_CorrectivaTextBox"
        Me.Descripción_de_la_Actividad_CorrectivaTextBox.ReadOnly = True
        Me.Descripción_de_la_Actividad_CorrectivaTextBox.Size = New System.Drawing.Size(220, 20)
        Me.Descripción_de_la_Actividad_CorrectivaTextBox.TabIndex = 24
        '
        'Fallas___AñoTextBox
        '
        Me.Fallas___AñoTextBox.BackColor = System.Drawing.Color.White
        Me.Fallas___AñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Fallas / Año", True))
        Me.Fallas___AñoTextBox.Location = New System.Drawing.Point(121, 320)
        Me.Fallas___AñoTextBox.Name = "Fallas___AñoTextBox"
        Me.Fallas___AñoTextBox.ReadOnly = True
        Me.Fallas___AñoTextBox.Size = New System.Drawing.Size(220, 20)
        Me.Fallas___AñoTextBox.TabIndex = 26
        '
        'Duracion__Mins_TextBox
        '
        Me.Duracion__Mins_TextBox.BackColor = System.Drawing.Color.White
        Me.Duracion__Mins_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Duracion (Mins)", True))
        Me.Duracion__Mins_TextBox.Location = New System.Drawing.Point(121, 346)
        Me.Duracion__Mins_TextBox.Name = "Duracion__Mins_TextBox"
        Me.Duracion__Mins_TextBox.ReadOnly = True
        Me.Duracion__Mins_TextBox.Size = New System.Drawing.Size(220, 20)
        Me.Duracion__Mins_TextBox.TabIndex = 28
        '
        'Htas_Especiales_1TextBox
        '
        Me.Htas_Especiales_1TextBox.BackColor = System.Drawing.Color.White
        Me.Htas_Especiales_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Htas Especiales 1", True))
        Me.Htas_Especiales_1TextBox.Location = New System.Drawing.Point(498, 265)
        Me.Htas_Especiales_1TextBox.Name = "Htas_Especiales_1TextBox"
        Me.Htas_Especiales_1TextBox.ReadOnly = True
        Me.Htas_Especiales_1TextBox.Size = New System.Drawing.Size(247, 20)
        Me.Htas_Especiales_1TextBox.TabIndex = 30
        '
        'Htas_Especiales_2TextBox
        '
        Me.Htas_Especiales_2TextBox.BackColor = System.Drawing.Color.White
        Me.Htas_Especiales_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Htas Especiales 2", True))
        Me.Htas_Especiales_2TextBox.Location = New System.Drawing.Point(498, 291)
        Me.Htas_Especiales_2TextBox.Name = "Htas_Especiales_2TextBox"
        Me.Htas_Especiales_2TextBox.ReadOnly = True
        Me.Htas_Especiales_2TextBox.Size = New System.Drawing.Size(247, 20)
        Me.Htas_Especiales_2TextBox.TabIndex = 32
        '
        'Htas_Especiales_3TextBox
        '
        Me.Htas_Especiales_3TextBox.BackColor = System.Drawing.Color.White
        Me.Htas_Especiales_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Htas Especiales 3", True))
        Me.Htas_Especiales_3TextBox.Location = New System.Drawing.Point(498, 317)
        Me.Htas_Especiales_3TextBox.Name = "Htas_Especiales_3TextBox"
        Me.Htas_Especiales_3TextBox.ReadOnly = True
        Me.Htas_Especiales_3TextBox.Size = New System.Drawing.Size(247, 20)
        Me.Htas_Especiales_3TextBox.TabIndex = 34
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.BackColor = System.Drawing.Color.White
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Comentarios", True))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(498, 372)
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.ReadOnly = True
        Me.ComentariosTextBox.Size = New System.Drawing.Size(247, 104)
        Me.ComentariosTextBox.TabIndex = 36
        '
        'Htas_Especiales_4TextBox
        '
        Me.Htas_Especiales_4TextBox.BackColor = System.Drawing.Color.White
        Me.Htas_Especiales_4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Htas Especiales 4", True))
        Me.Htas_Especiales_4TextBox.Location = New System.Drawing.Point(498, 343)
        Me.Htas_Especiales_4TextBox.Name = "Htas_Especiales_4TextBox"
        Me.Htas_Especiales_4TextBox.ReadOnly = True
        Me.Htas_Especiales_4TextBox.Size = New System.Drawing.Size(247, 20)
        Me.Htas_Especiales_4TextBox.TabIndex = 38
        '
        'Tipo_AislamientoTextBox
        '
        Me.Tipo_AislamientoTextBox.BackColor = System.Drawing.Color.White
        Me.Tipo_AislamientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Tipo Aislamiento", True))
        Me.Tipo_AislamientoTextBox.Location = New System.Drawing.Point(121, 372)
        Me.Tipo_AislamientoTextBox.Name = "Tipo_AislamientoTextBox"
        Me.Tipo_AislamientoTextBox.ReadOnly = True
        Me.Tipo_AislamientoTextBox.Size = New System.Drawing.Size(220, 20)
        Me.Tipo_AislamientoTextBox.TabIndex = 40
        '
        'Familia__Nivel_6_ComboBox
        '
        Me.Familia__Nivel_6_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Familia (Nivel 6)", True))
        Me.Familia__Nivel_6_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Modos_de_FallaBindingSource, "Familia (Nivel 6)", True))
        Me.Familia__Nivel_6_ComboBox.FormattingEnabled = True
        Me.Familia__Nivel_6_ComboBox.Location = New System.Drawing.Point(98, 22)
        Me.Familia__Nivel_6_ComboBox.Name = "Familia__Nivel_6_ComboBox"
        Me.Familia__Nivel_6_ComboBox.Size = New System.Drawing.Size(256, 21)
        Me.Familia__Nivel_6_ComboBox.TabIndex = 41
        '
        'Tipo_Equipo__Nivel_7_ComboBox
        '
        Me.Tipo_Equipo__Nivel_7_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Tipo Equipo (Nivel 7)", True))
        Me.Tipo_Equipo__Nivel_7_ComboBox.FormattingEnabled = True
        Me.Tipo_Equipo__Nivel_7_ComboBox.Location = New System.Drawing.Point(486, 22)
        Me.Tipo_Equipo__Nivel_7_ComboBox.Name = "Tipo_Equipo__Nivel_7_ComboBox"
        Me.Tipo_Equipo__Nivel_7_ComboBox.Size = New System.Drawing.Size(247, 21)
        Me.Tipo_Equipo__Nivel_7_ComboBox.TabIndex = 42
        '
        'Modo_FallaComboBox
        '
        Me.Modo_FallaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Modos_de_FallaBindingSource, "Modo Falla", True))
        Me.Modo_FallaComboBox.FormattingEnabled = True
        Me.Modo_FallaComboBox.Location = New System.Drawing.Point(98, 55)
        Me.Modo_FallaComboBox.Name = "Modo_FallaComboBox"
        Me.Modo_FallaComboBox.Size = New System.Drawing.Size(256, 21)
        Me.Modo_FallaComboBox.TabIndex = 45
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(634, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(111, 63)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 47
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(114, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 25)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "MODOS DE FALLA"
        '
        'Modos_de_FallaTableAdapter
        '
        Me.Modos_de_FallaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Estrategia_de_MantenimientoTableAdapter = Nothing
        Me.TableAdapterManager.Modos_de_FallaTableAdapter = Me.Modos_de_FallaTableAdapter
        Me.TableAdapterManager.RutinasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ASIMA.EstrategiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Modo_FallaLabel1)
        Me.GroupBox1.Controls.Add(Me.Modo_FallaComboBox)
        Me.GroupBox1.Controls.Add(Tipo_Equipo__Nivel_7_Label1)
        Me.GroupBox1.Controls.Add(Me.Tipo_Equipo__Nivel_7_ComboBox)
        Me.GroupBox1.Controls.Add(Familia__Nivel_6_Label1)
        Me.GroupBox1.Controls.Add(Me.Familia__Nivel_6_ComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(740, 93)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Búsqueda"
        '
        'MFalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(764, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(DisciplinaLabel)
        Me.Controls.Add(Me.DisciplinaTextBox)
        Me.Controls.Add(Código_GrupoLabel)
        Me.Controls.Add(Me.Código_GrupoTextBox)
        Me.Controls.Add(Código_Modo_FallaLabel)
        Me.Controls.Add(Me.Código_Modo_FallaTextBox)
        Me.Controls.Add(Modo_de_DeteccionLabel)
        Me.Controls.Add(Me.Modo_de_DeteccionTextBox)
        Me.Controls.Add(Causa_de_Modo_de_FallaLabel)
        Me.Controls.Add(Me.Causa_de_Modo_de_FallaTextBox)
        Me.Controls.Add(Criticidad_Modo_de_FallaLabel)
        Me.Controls.Add(Me.Criticidad_Modo_de_FallaTextBox)
        Me.Controls.Add(Tipo_de_TareaLabel)
        Me.Controls.Add(Me.Tipo_de_TareaTextBox)
        Me.Controls.Add(Descripción_de_la_Actividad_CorrectivaLabel)
        Me.Controls.Add(Me.Descripción_de_la_Actividad_CorrectivaTextBox)
        Me.Controls.Add(Fallas___AñoLabel)
        Me.Controls.Add(Me.Fallas___AñoTextBox)
        Me.Controls.Add(Duracion__Mins_Label)
        Me.Controls.Add(Me.Duracion__Mins_TextBox)
        Me.Controls.Add(Htas_Especiales_1Label)
        Me.Controls.Add(Me.Htas_Especiales_1TextBox)
        Me.Controls.Add(Htas_Especiales_2Label)
        Me.Controls.Add(Me.Htas_Especiales_2TextBox)
        Me.Controls.Add(Htas_Especiales_3Label)
        Me.Controls.Add(Me.Htas_Especiales_3TextBox)
        Me.Controls.Add(ComentariosLabel)
        Me.Controls.Add(Me.ComentariosTextBox)
        Me.Controls.Add(Htas_Especiales_4Label)
        Me.Controls.Add(Me.Htas_Especiales_4TextBox)
        Me.Controls.Add(Tipo_AislamientoLabel)
        Me.Controls.Add(Me.Tipo_AislamientoTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MFalla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modos de Falla"
        CType(Me.Modos_de_FallaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstrategiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EstrategiaDataSet As EstrategiaDataSet
    Friend WithEvents Modos_de_FallaBindingSource As BindingSource
    Friend WithEvents Modos_de_FallaTableAdapter As EstrategiaDataSetTableAdapters.Modos_de_FallaTableAdapter
    Friend WithEvents TableAdapterManager As EstrategiaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DisciplinaTextBox As TextBox
    Friend WithEvents Código_GrupoTextBox As TextBox
    Friend WithEvents Código_Modo_FallaTextBox As TextBox
    Friend WithEvents Modo_de_DeteccionTextBox As TextBox
    Friend WithEvents Causa_de_Modo_de_FallaTextBox As TextBox
    Friend WithEvents Criticidad_Modo_de_FallaTextBox As TextBox
    Friend WithEvents Tipo_de_TareaTextBox As TextBox
    Friend WithEvents Descripción_de_la_Actividad_CorrectivaTextBox As TextBox
    Friend WithEvents Fallas___AñoTextBox As TextBox
    Friend WithEvents Duracion__Mins_TextBox As TextBox
    Friend WithEvents Htas_Especiales_1TextBox As TextBox
    Friend WithEvents Htas_Especiales_2TextBox As TextBox
    Friend WithEvents Htas_Especiales_3TextBox As TextBox
    Friend WithEvents ComentariosTextBox As TextBox
    Friend WithEvents Htas_Especiales_4TextBox As TextBox
    Friend WithEvents Tipo_AislamientoTextBox As TextBox
    Friend WithEvents Familia__Nivel_6_ComboBox As ComboBox
    Friend WithEvents Tipo_Equipo__Nivel_7_ComboBox As ComboBox
    Friend WithEvents Modo_FallaComboBox As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
