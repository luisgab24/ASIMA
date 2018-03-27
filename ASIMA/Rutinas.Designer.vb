<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rutinas
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
        Dim Código_GrupoLabel As System.Windows.Forms.Label
        Dim Descripción_de_la_RutinaLabel As System.Windows.Forms.Label
        Dim Tipo_de_TareaLabel As System.Windows.Forms.Label
        Dim Cantidad_de_TécnicosLabel As System.Windows.Forms.Label
        Dim Frecuencia_x_AñoLabel As System.Windows.Forms.Label
        Dim Modos_de_Falla_AsociadosLabel As System.Windows.Forms.Label
        Dim Duración__Mins_Label As System.Windows.Forms.Label
        Dim Htas_Especiales_1Label As System.Windows.Forms.Label
        Dim Htas_Especiales_2Label As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim Htas_Especiales_3Label As System.Windows.Forms.Label
        Dim Htas_Especiales_4Label As System.Windows.Forms.Label
        Dim Familia__Nivel_6_Label As System.Windows.Forms.Label
        Dim Tipo_Equipo__Nivel_7_Label As System.Windows.Forms.Label
        Dim DisciplinaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rutinas))
        Me.EstrategiaDataSet = New ASIMA.EstrategiaDataSet()
        Me.RutinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RutinasTableAdapter = New ASIMA.EstrategiaDataSetTableAdapters.RutinasTableAdapter()
        Me.TableAdapterManager = New ASIMA.EstrategiaDataSetTableAdapters.TableAdapterManager()
        Me.Código_GrupoTextBox = New System.Windows.Forms.TextBox()
        Me.Descripción_de_la_RutinaTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_de_TareaTextBox = New System.Windows.Forms.TextBox()
        Me.Cantidad_de_TécnicosTextBox = New System.Windows.Forms.TextBox()
        Me.Frecuencia_x_AñoTextBox = New System.Windows.Forms.TextBox()
        Me.Modos_de_Falla_AsociadosTextBox = New System.Windows.Forms.TextBox()
        Me.Duración__Mins_TextBox = New System.Windows.Forms.TextBox()
        Me.Htas_Especiales_1TextBox = New System.Windows.Forms.TextBox()
        Me.Htas_Especiales_2TextBox = New System.Windows.Forms.TextBox()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.Htas_Especiales_3TextBox = New System.Windows.Forms.TextBox()
        Me.Htas_Especiales_4TextBox = New System.Windows.Forms.TextBox()
        Me.Familia__Nivel_6_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Tipo_Equipo__Nivel_7_ComboBox = New System.Windows.Forms.ComboBox()
        Me.DisciplinaComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Código_GrupoLabel = New System.Windows.Forms.Label()
        Descripción_de_la_RutinaLabel = New System.Windows.Forms.Label()
        Tipo_de_TareaLabel = New System.Windows.Forms.Label()
        Cantidad_de_TécnicosLabel = New System.Windows.Forms.Label()
        Frecuencia_x_AñoLabel = New System.Windows.Forms.Label()
        Modos_de_Falla_AsociadosLabel = New System.Windows.Forms.Label()
        Duración__Mins_Label = New System.Windows.Forms.Label()
        Htas_Especiales_1Label = New System.Windows.Forms.Label()
        Htas_Especiales_2Label = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        Htas_Especiales_3Label = New System.Windows.Forms.Label()
        Htas_Especiales_4Label = New System.Windows.Forms.Label()
        Familia__Nivel_6_Label = New System.Windows.Forms.Label()
        Tipo_Equipo__Nivel_7_Label = New System.Windows.Forms.Label()
        DisciplinaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.EstrategiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RutinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Código_GrupoLabel
        '
        Código_GrupoLabel.AutoSize = True
        Código_GrupoLabel.Location = New System.Drawing.Point(12, 181)
        Código_GrupoLabel.Name = "Código_GrupoLabel"
        Código_GrupoLabel.Size = New System.Drawing.Size(75, 13)
        Código_GrupoLabel.TabIndex = 3
        Código_GrupoLabel.Text = "Código Grupo:"
        '
        'Descripción_de_la_RutinaLabel
        '
        Descripción_de_la_RutinaLabel.AutoSize = True
        Descripción_de_la_RutinaLabel.Location = New System.Drawing.Point(271, 233)
        Descripción_de_la_RutinaLabel.Name = "Descripción_de_la_RutinaLabel"
        Descripción_de_la_RutinaLabel.Size = New System.Drawing.Size(126, 13)
        Descripción_de_la_RutinaLabel.TabIndex = 11
        Descripción_de_la_RutinaLabel.Text = "Descripción de la Rutina:"
        '
        'Tipo_de_TareaLabel
        '
        Tipo_de_TareaLabel.AutoSize = True
        Tipo_de_TareaLabel.Location = New System.Drawing.Point(328, 181)
        Tipo_de_TareaLabel.Name = "Tipo_de_TareaLabel"
        Tipo_de_TareaLabel.Size = New System.Drawing.Size(77, 13)
        Tipo_de_TareaLabel.TabIndex = 15
        Tipo_de_TareaLabel.Text = "Tipo de Tarea:"
        '
        'Cantidad_de_TécnicosLabel
        '
        Cantidad_de_TécnicosLabel.AutoSize = True
        Cantidad_de_TécnicosLabel.Location = New System.Drawing.Point(12, 207)
        Cantidad_de_TécnicosLabel.Name = "Cantidad_de_TécnicosLabel"
        Cantidad_de_TécnicosLabel.Size = New System.Drawing.Size(114, 13)
        Cantidad_de_TécnicosLabel.TabIndex = 17
        Cantidad_de_TécnicosLabel.Text = "Cantidad de Técnicos:"
        '
        'Frecuencia_x_AñoLabel
        '
        Frecuencia_x_AñoLabel.AutoSize = True
        Frecuencia_x_AñoLabel.Location = New System.Drawing.Point(607, 181)
        Frecuencia_x_AñoLabel.Name = "Frecuencia_x_AñoLabel"
        Frecuencia_x_AñoLabel.Size = New System.Drawing.Size(63, 13)
        Frecuencia_x_AñoLabel.TabIndex = 19
        Frecuencia_x_AñoLabel.Text = "Frecuencia:"
        '
        'Modos_de_Falla_AsociadosLabel
        '
        Modos_de_Falla_AsociadosLabel.AutoSize = True
        Modos_de_Falla_AsociadosLabel.Location = New System.Drawing.Point(271, 207)
        Modos_de_Falla_AsociadosLabel.Name = "Modos_de_Falla_AsociadosLabel"
        Modos_de_Falla_AsociadosLabel.Size = New System.Drawing.Size(134, 13)
        Modos_de_Falla_AsociadosLabel.TabIndex = 21
        Modos_de_Falla_AsociadosLabel.Text = "Modos de Falla Asociados:"
        '
        'Duración__Mins_Label
        '
        Duración__Mins_Label.AutoSize = True
        Duración__Mins_Label.Location = New System.Drawing.Point(12, 230)
        Duración__Mins_Label.Name = "Duración__Mins_Label"
        Duración__Mins_Label.Size = New System.Drawing.Size(84, 13)
        Duración__Mins_Label.TabIndex = 23
        Duración__Mins_Label.Text = "Duración (Mins):"
        '
        'Htas_Especiales_1Label
        '
        Htas_Especiales_1Label.AutoSize = True
        Htas_Especiales_1Label.Location = New System.Drawing.Point(12, 256)
        Htas_Especiales_1Label.Name = "Htas_Especiales_1Label"
        Htas_Especiales_1Label.Size = New System.Drawing.Size(95, 13)
        Htas_Especiales_1Label.TabIndex = 25
        Htas_Especiales_1Label.Text = "Htas Especiales 1:"
        '
        'Htas_Especiales_2Label
        '
        Htas_Especiales_2Label.AutoSize = True
        Htas_Especiales_2Label.Location = New System.Drawing.Point(12, 282)
        Htas_Especiales_2Label.Name = "Htas_Especiales_2Label"
        Htas_Especiales_2Label.Size = New System.Drawing.Size(95, 13)
        Htas_Especiales_2Label.TabIndex = 27
        Htas_Especiales_2Label.Text = "Htas Especiales 2:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(12, 360)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(68, 13)
        ComentariosLabel.TabIndex = 29
        ComentariosLabel.Text = "Comentarios:"
        '
        'Htas_Especiales_3Label
        '
        Htas_Especiales_3Label.AutoSize = True
        Htas_Especiales_3Label.Location = New System.Drawing.Point(12, 308)
        Htas_Especiales_3Label.Name = "Htas_Especiales_3Label"
        Htas_Especiales_3Label.Size = New System.Drawing.Size(95, 13)
        Htas_Especiales_3Label.TabIndex = 31
        Htas_Especiales_3Label.Text = "Htas Especiales 3:"
        '
        'Htas_Especiales_4Label
        '
        Htas_Especiales_4Label.AutoSize = True
        Htas_Especiales_4Label.Location = New System.Drawing.Point(12, 334)
        Htas_Especiales_4Label.Name = "Htas_Especiales_4Label"
        Htas_Especiales_4Label.Size = New System.Drawing.Size(95, 13)
        Htas_Especiales_4Label.TabIndex = 33
        Htas_Especiales_4Label.Text = "Htas Especiales 4:"
        '
        'Familia__Nivel_6_Label
        '
        Familia__Nivel_6_Label.AutoSize = True
        Familia__Nivel_6_Label.Location = New System.Drawing.Point(3, 23)
        Familia__Nivel_6_Label.Name = "Familia__Nivel_6_Label"
        Familia__Nivel_6_Label.Size = New System.Drawing.Size(96, 13)
        Familia__Nivel_6_Label.TabIndex = 34
        Familia__Nivel_6_Label.Text = "1. Familia (Nivel 6):"
        '
        'Tipo_Equipo__Nivel_7_Label
        '
        Tipo_Equipo__Nivel_7_Label.AutoSize = True
        Tipo_Equipo__Nivel_7_Label.Location = New System.Drawing.Point(383, 23)
        Tipo_Equipo__Nivel_7_Label.Name = "Tipo_Equipo__Nivel_7_Label"
        Tipo_Equipo__Nivel_7_Label.Size = New System.Drawing.Size(121, 13)
        Tipo_Equipo__Nivel_7_Label.TabIndex = 35
        Tipo_Equipo__Nivel_7_Label.Text = "2. Tipo Equipo (Nivel 7):"
        '
        'DisciplinaLabel
        '
        DisciplinaLabel.AutoSize = True
        DisciplinaLabel.Location = New System.Drawing.Point(4, 50)
        DisciplinaLabel.Name = "DisciplinaLabel"
        DisciplinaLabel.Size = New System.Drawing.Size(67, 13)
        DisciplinaLabel.TabIndex = 36
        DisciplinaLabel.Text = "3. Disciplina:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(383, 51)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 13)
        Label1.TabIndex = 38
        Label1.Text = "4. Rutinas:"
        '
        'EstrategiaDataSet
        '
        Me.EstrategiaDataSet.DataSetName = "EstrategiaDataSet"
        Me.EstrategiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RutinasBindingSource
        '
        Me.RutinasBindingSource.DataMember = "Rutinas"
        Me.RutinasBindingSource.DataSource = Me.EstrategiaDataSet
        '
        'RutinasTableAdapter
        '
        Me.RutinasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Estrategia_de_MantenimientoTableAdapter = Nothing
        Me.TableAdapterManager.Modos_de_FallaTableAdapter = Nothing
        Me.TableAdapterManager.RutinasTableAdapter = Me.RutinasTableAdapter
        Me.TableAdapterManager.UpdateOrder = ASIMA.EstrategiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Código_GrupoTextBox
        '
        Me.Código_GrupoTextBox.BackColor = System.Drawing.Color.White
        Me.Código_GrupoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Código Grupo", True))
        Me.Código_GrupoTextBox.Location = New System.Drawing.Point(152, 178)
        Me.Código_GrupoTextBox.Name = "Código_GrupoTextBox"
        Me.Código_GrupoTextBox.ReadOnly = True
        Me.Código_GrupoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Código_GrupoTextBox.TabIndex = 4
        '
        'Descripción_de_la_RutinaTextBox
        '
        Me.Descripción_de_la_RutinaTextBox.BackColor = System.Drawing.Color.White
        Me.Descripción_de_la_RutinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Descripción de la Rutina", True))
        Me.Descripción_de_la_RutinaTextBox.Location = New System.Drawing.Point(411, 230)
        Me.Descripción_de_la_RutinaTextBox.Multiline = True
        Me.Descripción_de_la_RutinaTextBox.Name = "Descripción_de_la_RutinaTextBox"
        Me.Descripción_de_la_RutinaTextBox.ReadOnly = True
        Me.Descripción_de_la_RutinaTextBox.Size = New System.Drawing.Size(376, 203)
        Me.Descripción_de_la_RutinaTextBox.TabIndex = 12
        '
        'Tipo_de_TareaTextBox
        '
        Me.Tipo_de_TareaTextBox.BackColor = System.Drawing.Color.White
        Me.Tipo_de_TareaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Tipo de Tarea", True))
        Me.Tipo_de_TareaTextBox.Location = New System.Drawing.Point(411, 178)
        Me.Tipo_de_TareaTextBox.Name = "Tipo_de_TareaTextBox"
        Me.Tipo_de_TareaTextBox.ReadOnly = True
        Me.Tipo_de_TareaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tipo_de_TareaTextBox.TabIndex = 16
        '
        'Cantidad_de_TécnicosTextBox
        '
        Me.Cantidad_de_TécnicosTextBox.BackColor = System.Drawing.Color.White
        Me.Cantidad_de_TécnicosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Cantidad de Técnicos", True))
        Me.Cantidad_de_TécnicosTextBox.Location = New System.Drawing.Point(152, 204)
        Me.Cantidad_de_TécnicosTextBox.Name = "Cantidad_de_TécnicosTextBox"
        Me.Cantidad_de_TécnicosTextBox.ReadOnly = True
        Me.Cantidad_de_TécnicosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cantidad_de_TécnicosTextBox.TabIndex = 18
        '
        'Frecuencia_x_AñoTextBox
        '
        Me.Frecuencia_x_AñoTextBox.BackColor = System.Drawing.Color.White
        Me.Frecuencia_x_AñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Frecuencia x Año", True))
        Me.Frecuencia_x_AñoTextBox.Location = New System.Drawing.Point(676, 178)
        Me.Frecuencia_x_AñoTextBox.Name = "Frecuencia_x_AñoTextBox"
        Me.Frecuencia_x_AñoTextBox.ReadOnly = True
        Me.Frecuencia_x_AñoTextBox.Size = New System.Drawing.Size(111, 20)
        Me.Frecuencia_x_AñoTextBox.TabIndex = 20
        '
        'Modos_de_Falla_AsociadosTextBox
        '
        Me.Modos_de_Falla_AsociadosTextBox.BackColor = System.Drawing.Color.White
        Me.Modos_de_Falla_AsociadosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Modos de Falla Asociados", True))
        Me.Modos_de_Falla_AsociadosTextBox.Location = New System.Drawing.Point(411, 204)
        Me.Modos_de_Falla_AsociadosTextBox.Name = "Modos_de_Falla_AsociadosTextBox"
        Me.Modos_de_Falla_AsociadosTextBox.ReadOnly = True
        Me.Modos_de_Falla_AsociadosTextBox.Size = New System.Drawing.Size(376, 20)
        Me.Modos_de_Falla_AsociadosTextBox.TabIndex = 22
        '
        'Duración__Mins_TextBox
        '
        Me.Duración__Mins_TextBox.BackColor = System.Drawing.Color.White
        Me.Duración__Mins_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Duración (Mins)", True))
        Me.Duración__Mins_TextBox.Location = New System.Drawing.Point(152, 227)
        Me.Duración__Mins_TextBox.Name = "Duración__Mins_TextBox"
        Me.Duración__Mins_TextBox.ReadOnly = True
        Me.Duración__Mins_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Duración__Mins_TextBox.TabIndex = 24
        '
        'Htas_Especiales_1TextBox
        '
        Me.Htas_Especiales_1TextBox.BackColor = System.Drawing.Color.White
        Me.Htas_Especiales_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Htas Especiales 1", True))
        Me.Htas_Especiales_1TextBox.Location = New System.Drawing.Point(152, 253)
        Me.Htas_Especiales_1TextBox.Name = "Htas_Especiales_1TextBox"
        Me.Htas_Especiales_1TextBox.ReadOnly = True
        Me.Htas_Especiales_1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Htas_Especiales_1TextBox.TabIndex = 26
        '
        'Htas_Especiales_2TextBox
        '
        Me.Htas_Especiales_2TextBox.BackColor = System.Drawing.Color.White
        Me.Htas_Especiales_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Htas Especiales 2", True))
        Me.Htas_Especiales_2TextBox.Location = New System.Drawing.Point(152, 279)
        Me.Htas_Especiales_2TextBox.Name = "Htas_Especiales_2TextBox"
        Me.Htas_Especiales_2TextBox.ReadOnly = True
        Me.Htas_Especiales_2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Htas_Especiales_2TextBox.TabIndex = 28
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.BackColor = System.Drawing.Color.White
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Comentarios", True))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(152, 357)
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.ReadOnly = True
        Me.ComentariosTextBox.Size = New System.Drawing.Size(245, 76)
        Me.ComentariosTextBox.TabIndex = 30
        '
        'Htas_Especiales_3TextBox
        '
        Me.Htas_Especiales_3TextBox.BackColor = System.Drawing.Color.White
        Me.Htas_Especiales_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Htas Especiales 3", True))
        Me.Htas_Especiales_3TextBox.Location = New System.Drawing.Point(152, 305)
        Me.Htas_Especiales_3TextBox.Name = "Htas_Especiales_3TextBox"
        Me.Htas_Especiales_3TextBox.ReadOnly = True
        Me.Htas_Especiales_3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Htas_Especiales_3TextBox.TabIndex = 32
        '
        'Htas_Especiales_4TextBox
        '
        Me.Htas_Especiales_4TextBox.BackColor = System.Drawing.Color.White
        Me.Htas_Especiales_4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Htas Especiales 4", True))
        Me.Htas_Especiales_4TextBox.Location = New System.Drawing.Point(152, 331)
        Me.Htas_Especiales_4TextBox.Name = "Htas_Especiales_4TextBox"
        Me.Htas_Especiales_4TextBox.ReadOnly = True
        Me.Htas_Especiales_4TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Htas_Especiales_4TextBox.TabIndex = 34
        '
        'Familia__Nivel_6_ComboBox
        '
        Me.Familia__Nivel_6_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Familia (Nivel 6)", True))
        Me.Familia__Nivel_6_ComboBox.FormattingEnabled = True
        Me.Familia__Nivel_6_ComboBox.Location = New System.Drawing.Point(105, 20)
        Me.Familia__Nivel_6_ComboBox.Name = "Familia__Nivel_6_ComboBox"
        Me.Familia__Nivel_6_ComboBox.Size = New System.Drawing.Size(272, 21)
        Me.Familia__Nivel_6_ComboBox.TabIndex = 35
        '
        'Tipo_Equipo__Nivel_7_ComboBox
        '
        Me.Tipo_Equipo__Nivel_7_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Tipo Equipo (Nivel 7)", True))
        Me.Tipo_Equipo__Nivel_7_ComboBox.FormattingEnabled = True
        Me.Tipo_Equipo__Nivel_7_ComboBox.Location = New System.Drawing.Point(510, 20)
        Me.Tipo_Equipo__Nivel_7_ComboBox.Name = "Tipo_Equipo__Nivel_7_ComboBox"
        Me.Tipo_Equipo__Nivel_7_ComboBox.Size = New System.Drawing.Size(270, 21)
        Me.Tipo_Equipo__Nivel_7_ComboBox.TabIndex = 36
        '
        'DisciplinaComboBox
        '
        Me.DisciplinaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Disciplina", True))
        Me.DisciplinaComboBox.FormattingEnabled = True
        Me.DisciplinaComboBox.Location = New System.Drawing.Point(105, 46)
        Me.DisciplinaComboBox.Name = "DisciplinaComboBox"
        Me.DisciplinaComboBox.Size = New System.Drawing.Size(272, 21)
        Me.DisciplinaComboBox.TabIndex = 37
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "Disciplina", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(510, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(270, 21)
        Me.ComboBox1.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 25)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "RUTINAS"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(672, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(111, 63)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 50
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(114, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(DisciplinaLabel)
        Me.GroupBox1.Controls.Add(Me.DisciplinaComboBox)
        Me.GroupBox1.Controls.Add(Tipo_Equipo__Nivel_7_Label)
        Me.GroupBox1.Controls.Add(Me.Tipo_Equipo__Nivel_7_ComboBox)
        Me.GroupBox1.Controls.Add(Familia__Nivel_6_Label)
        Me.GroupBox1.Controls.Add(Me.Familia__Nivel_6_ComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(797, 83)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Búsqueda"
        '
        'Rutinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(809, 444)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Código_GrupoLabel)
        Me.Controls.Add(Me.Código_GrupoTextBox)
        Me.Controls.Add(Descripción_de_la_RutinaLabel)
        Me.Controls.Add(Me.Descripción_de_la_RutinaTextBox)
        Me.Controls.Add(Tipo_de_TareaLabel)
        Me.Controls.Add(Me.Tipo_de_TareaTextBox)
        Me.Controls.Add(Cantidad_de_TécnicosLabel)
        Me.Controls.Add(Me.Cantidad_de_TécnicosTextBox)
        Me.Controls.Add(Frecuencia_x_AñoLabel)
        Me.Controls.Add(Me.Frecuencia_x_AñoTextBox)
        Me.Controls.Add(Modos_de_Falla_AsociadosLabel)
        Me.Controls.Add(Me.Modos_de_Falla_AsociadosTextBox)
        Me.Controls.Add(Duración__Mins_Label)
        Me.Controls.Add(Me.Duración__Mins_TextBox)
        Me.Controls.Add(Htas_Especiales_1Label)
        Me.Controls.Add(Me.Htas_Especiales_1TextBox)
        Me.Controls.Add(Htas_Especiales_2Label)
        Me.Controls.Add(Me.Htas_Especiales_2TextBox)
        Me.Controls.Add(ComentariosLabel)
        Me.Controls.Add(Me.ComentariosTextBox)
        Me.Controls.Add(Htas_Especiales_3Label)
        Me.Controls.Add(Me.Htas_Especiales_3TextBox)
        Me.Controls.Add(Htas_Especiales_4Label)
        Me.Controls.Add(Me.Htas_Especiales_4TextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Rutinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rutinas"
        CType(Me.EstrategiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RutinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EstrategiaDataSet As EstrategiaDataSet
    Friend WithEvents RutinasBindingSource As BindingSource
    Friend WithEvents RutinasTableAdapter As EstrategiaDataSetTableAdapters.RutinasTableAdapter
    Friend WithEvents TableAdapterManager As EstrategiaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Código_GrupoTextBox As TextBox
    Friend WithEvents Descripción_de_la_RutinaTextBox As TextBox
    Friend WithEvents Tipo_de_TareaTextBox As TextBox
    Friend WithEvents Cantidad_de_TécnicosTextBox As TextBox
    Friend WithEvents Frecuencia_x_AñoTextBox As TextBox
    Friend WithEvents Modos_de_Falla_AsociadosTextBox As TextBox
    Friend WithEvents Duración__Mins_TextBox As TextBox
    Friend WithEvents Htas_Especiales_1TextBox As TextBox
    Friend WithEvents Htas_Especiales_2TextBox As TextBox
    Friend WithEvents ComentariosTextBox As TextBox
    Friend WithEvents Htas_Especiales_3TextBox As TextBox
    Friend WithEvents Htas_Especiales_4TextBox As TextBox
    Friend WithEvents Familia__Nivel_6_ComboBox As ComboBox
    Friend WithEvents Tipo_Equipo__Nivel_7_ComboBox As ComboBox
    Friend WithEvents DisciplinaComboBox As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
