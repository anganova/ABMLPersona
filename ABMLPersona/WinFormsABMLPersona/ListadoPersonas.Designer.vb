Partial Class ListadoPersonas
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.labelListadoPersonas = New System.Windows.Forms.Label()
		Me.dataGridPersonas = New System.Windows.Forms.DataGridView()
		Me.nombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.edadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.fechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.sexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.personaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		DirectCast(Me.dataGridPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.personaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' labelListadoPersonas
		' 
		Me.labelListadoPersonas.AutoSize = True
		Me.labelListadoPersonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelListadoPersonas.Location = New System.Drawing.Point(12, 9)
		Me.labelListadoPersonas.Name = "labelListadoPersonas"
		Me.labelListadoPersonas.Size = New System.Drawing.Size(180, 24)
		Me.labelListadoPersonas.TabIndex = 0
		Me.labelListadoPersonas.Text = "Listado de Personas"
		' 
		' dataGridPersonas
		' 
		Me.dataGridPersonas.AllowUserToAddRows = False
		Me.dataGridPersonas.AllowUserToDeleteRows = False
		Me.dataGridPersonas.AutoGenerateColumns = False
		Me.dataGridPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridPersonas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreCompletoDataGridViewTextBoxColumn, Me.edadDataGridViewTextBoxColumn, Me.fechaNacimientoDataGridViewTextBoxColumn, Me.sexoDataGridViewTextBoxColumn})
		Me.dataGridPersonas.DataSource = Me.personaBindingSource
		Me.dataGridPersonas.Location = New System.Drawing.Point(26, 47)
		Me.dataGridPersonas.Name = "dataGridPersonas"
		Me.dataGridPersonas.[ReadOnly] = True
		Me.dataGridPersonas.Size = New System.Drawing.Size(556, 192)
		Me.dataGridPersonas.TabIndex = 1
		' 
		' nombreCompletoDataGridViewTextBoxColumn
		' 
		Me.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto"
		Me.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo"
		Me.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn"
		Me.nombreCompletoDataGridViewTextBoxColumn.[ReadOnly] = True
		Me.nombreCompletoDataGridViewTextBoxColumn.Width = 200
		' 
		' edadDataGridViewTextBoxColumn
		' 
		Me.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad"
		Me.edadDataGridViewTextBoxColumn.HeaderText = "Edad"
		Me.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn"
		Me.edadDataGridViewTextBoxColumn.[ReadOnly] = True
		Me.edadDataGridViewTextBoxColumn.Width = 80
		' 
		' fechaNacimientoDataGridViewTextBoxColumn
		' 
		Me.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento"
		Me.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento"
		Me.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn"
		Me.fechaNacimientoDataGridViewTextBoxColumn.[ReadOnly] = True
		Me.fechaNacimientoDataGridViewTextBoxColumn.Width = 150
		' 
		' sexoDataGridViewTextBoxColumn
		' 
		Me.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
		Me.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
		Me.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn"
		Me.sexoDataGridViewTextBoxColumn.[ReadOnly] = True
		Me.sexoDataGridViewTextBoxColumn.Width = 80
		' 
		' personaBindingSource
		' 
		Me.personaBindingSource.DataSource = GetType(WinFormsABMLPersona.WebServicePersona.Persona)
		' 
		' ListadoPersonas
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(607, 262)
		Me.Controls.Add(Me.dataGridPersonas)
		Me.Controls.Add(Me.labelListadoPersonas)
		Me.Name = "ListadoPersonas"
		Me.Text = "Listado de Personas"
		DirectCast(Me.dataGridPersonas, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.personaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private labelListadoPersonas As System.Windows.Forms.Label
	Private dataGridPersonas As System.Windows.Forms.DataGridView
	Private personaBindingSource As System.Windows.Forms.BindingSource
	Private nombreCompletoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Private edadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Private fechaNacimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Private sexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
