<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordenes_Hts
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
        Dim Cod_OTLabel As System.Windows.Forms.Label
        Dim Fecha_ProgramadoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ordenes_Hts))
        Me.EstrategiaDataSet = New ASIMA.EstrategiaDataSet()
        Me.OMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMTableAdapter = New ASIMA.EstrategiaDataSetTableAdapters.OMTableAdapter()
        Me.TableAdapterManager = New ASIMA.EstrategiaDataSetTableAdapters.TableAdapterManager()
        Me.OMBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.Cod_OTComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Fecha_ProgramadoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Cod_OTLabel = New System.Windows.Forms.Label()
        Fecha_ProgramadoLabel = New System.Windows.Forms.Label()
        CType(Me.EstrategiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OMBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_OTLabel
        '
        Cod_OTLabel.AutoSize = True
        Cod_OTLabel.Location = New System.Drawing.Point(58, 26)
        Cod_OTLabel.Name = "Cod_OTLabel"
        Cod_OTLabel.Size = New System.Drawing.Size(47, 13)
        Cod_OTLabel.TabIndex = 1
        Cod_OTLabel.Text = "Cod OT:"
        '
        'Fecha_ProgramadoLabel
        '
        Fecha_ProgramadoLabel.AutoSize = True
        Fecha_ProgramadoLabel.Location = New System.Drawing.Point(5, 68)
        Fecha_ProgramadoLabel.Name = "Fecha_ProgramadoLabel"
        Fecha_ProgramadoLabel.Size = New System.Drawing.Size(100, 13)
        Fecha_ProgramadoLabel.TabIndex = 5
        Fecha_ProgramadoLabel.Text = "Fecha Programado:"
        '
        'EstrategiaDataSet
        '
        Me.EstrategiaDataSet.DataSetName = "EstrategiaDataSet"
        Me.EstrategiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OMBindingSource
        '
        Me.OMBindingSource.DataMember = "OM"
        Me.OMBindingSource.DataSource = Me.EstrategiaDataSet
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
        Me.OMBindingNavigator.Size = New System.Drawing.Size(332, 25)
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
        'Cod_OTComboBox
        '
        Me.Cod_OTComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMBindingSource, "Cod_OT", True))
        Me.Cod_OTComboBox.FormattingEnabled = True
        Me.Cod_OTComboBox.Location = New System.Drawing.Point(111, 23)
        Me.Cod_OTComboBox.Name = "Cod_OTComboBox"
        Me.Cod_OTComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cod_OTComboBox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(111, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Reprogramar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Fecha_ProgramadoDateTimePicker
        '
        Me.Fecha_ProgramadoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OMBindingSource, "Fecha_Programado", True))
        Me.Fecha_ProgramadoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_ProgramadoDateTimePicker.Location = New System.Drawing.Point(111, 64)
        Me.Fecha_ProgramadoDateTimePicker.Name = "Fecha_ProgramadoDateTimePicker"
        Me.Fecha_ProgramadoDateTimePicker.Size = New System.Drawing.Size(121, 20)
        Me.Fecha_ProgramadoDateTimePicker.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(239, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(288, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 23)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Ordenes_Hts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 141)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Fecha_ProgramadoLabel)
        Me.Controls.Add(Me.Fecha_ProgramadoDateTimePicker)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Cod_OTLabel)
        Me.Controls.Add(Me.Cod_OTComboBox)
        Me.Controls.Add(Me.OMBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ordenes_Hts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenes_Hts"
        CType(Me.EstrategiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OMBindingNavigator.ResumeLayout(False)
        Me.OMBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Cod_OTComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Fecha_ProgramadoDateTimePicker As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
End Class
