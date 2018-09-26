Partial Class ModificarPersona
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
		Me.labelModificarPersona = New System.Windows.Forms.Label()
		Me.labelNombreBuscar = New System.Windows.Forms.Label()
		Me.textBoxNombreBuscar = New System.Windows.Forms.TextBox()
		Me.buttonBuscar = New System.Windows.Forms.Button()
		Me.groupBox = New System.Windows.Forms.GroupBox()
		Me.buttonCancelar = New System.Windows.Forms.Button()
		Me.buttonGrabar = New System.Windows.Forms.Button()
		Me.comboBoxSexo = New System.Windows.Forms.ComboBox()
		Me.labelSexo = New System.Windows.Forms.Label()
		Me.textBoxEdad = New System.Windows.Forms.TextBox()
		Me.labelEdad = New System.Windows.Forms.Label()
		Me.dateTimePickerFechaNacimiento = New System.Windows.Forms.DateTimePicker()
		Me.labelFechaNacimiento = New System.Windows.Forms.Label()
		Me.labelNombreModificar = New System.Windows.Forms.Label()
		Me.textBoxNombreModificar = New System.Windows.Forms.TextBox()
		Me.errorProviderNombre = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.errorProviderFechaNacimiento = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.errorProviderEdad = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.errorProviderSexo = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.groupBox.SuspendLayout()
		DirectCast(Me.errorProviderNombre, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.errorProviderFechaNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.errorProviderEdad, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.errorProviderSexo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' labelModificarPersona
		' 
		Me.labelModificarPersona.AutoSize = True
		Me.labelModificarPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelModificarPersona.Location = New System.Drawing.Point(12, 9)
		Me.labelModificarPersona.Name = "labelModificarPersona"
		Me.labelModificarPersona.Size = New System.Drawing.Size(213, 24)
		Me.labelModificarPersona.TabIndex = 1
		Me.labelModificarPersona.Text = "Modificar Datos Persona"
		' 
		' labelNombreBuscar
		' 
		Me.labelNombreBuscar.AutoSize = True
		Me.labelNombreBuscar.Location = New System.Drawing.Point(38, 58)
		Me.labelNombreBuscar.Name = "labelNombreBuscar"
		Me.labelNombreBuscar.Size = New System.Drawing.Size(94, 13)
		Me.labelNombreBuscar.TabIndex = 4
		Me.labelNombreBuscar.Text = "Nombre Completo:"
		' 
		' textBoxNombreBuscar
		' 
		Me.textBoxNombreBuscar.Location = New System.Drawing.Point(134, 55)
		Me.textBoxNombreBuscar.Name = "textBoxNombreBuscar"
		Me.textBoxNombreBuscar.Size = New System.Drawing.Size(261, 20)
		Me.textBoxNombreBuscar.TabIndex = 3
		' 
		' buttonBuscar
		' 
		Me.buttonBuscar.Location = New System.Drawing.Point(41, 91)
		Me.buttonBuscar.Name = "buttonBuscar"
		Me.buttonBuscar.Size = New System.Drawing.Size(75, 33)
		Me.buttonBuscar.TabIndex = 10
		Me.buttonBuscar.Text = "Buscar"
		Me.buttonBuscar.UseVisualStyleBackColor = True
		AddHandler Me.buttonBuscar.Click, New System.EventHandler(AddressOf Me.buttonBuscar_Click)
		' 
		' groupBox
		' 
		Me.groupBox.Controls.Add(Me.buttonCancelar)
		Me.groupBox.Controls.Add(Me.buttonGrabar)
		Me.groupBox.Controls.Add(Me.comboBoxSexo)
		Me.groupBox.Controls.Add(Me.labelSexo)
		Me.groupBox.Controls.Add(Me.textBoxEdad)
		Me.groupBox.Controls.Add(Me.labelEdad)
		Me.groupBox.Controls.Add(Me.dateTimePickerFechaNacimiento)
		Me.groupBox.Controls.Add(Me.labelFechaNacimiento)
		Me.groupBox.Controls.Add(Me.labelNombreModificar)
		Me.groupBox.Controls.Add(Me.textBoxNombreModificar)
		Me.groupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.groupBox.Location = New System.Drawing.Point(41, 147)
		Me.groupBox.Name = "groupBox"
		Me.groupBox.Size = New System.Drawing.Size(456, 254)
		Me.groupBox.TabIndex = 12
		Me.groupBox.TabStop = False
		Me.groupBox.Text = "Datos a modificar"
		' 
		' buttonCancelar
		' 
		Me.buttonCancelar.Location = New System.Drawing.Point(116, 209)
		Me.buttonCancelar.Name = "buttonCancelar"
		Me.buttonCancelar.Size = New System.Drawing.Size(75, 33)
		Me.buttonCancelar.TabIndex = 22
		Me.buttonCancelar.Text = "Cancelar"
		Me.buttonCancelar.UseVisualStyleBackColor = True
		AddHandler Me.buttonCancelar.Click, New System.EventHandler(AddressOf Me.buttonCancelar_Click)
		' 
		' buttonGrabar
		' 
		Me.buttonGrabar.Location = New System.Drawing.Point(24, 209)
		Me.buttonGrabar.Name = "buttonGrabar"
		Me.buttonGrabar.Size = New System.Drawing.Size(75, 33)
		Me.buttonGrabar.TabIndex = 21
		Me.buttonGrabar.Text = "Grabar"
		Me.buttonGrabar.UseVisualStyleBackColor = True
		AddHandler Me.buttonGrabar.Click, New System.EventHandler(AddressOf Me.buttonGrabar_Click)
		' 
		' comboBoxSexo
		' 
		Me.comboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxSexo.FormattingEnabled = True
		Me.comboBoxSexo.Items.AddRange(New Object() {"", "Masculino", "Femenino"})
		Me.comboBoxSexo.Location = New System.Drawing.Point(57, 161)
		Me.comboBoxSexo.Name = "comboBoxSexo"
		Me.comboBoxSexo.Size = New System.Drawing.Size(102, 24)
		Me.comboBoxSexo.TabIndex = 20
		AddHandler Me.comboBoxSexo.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.comboBoxSexo_Validating)
		' 
		' labelSexo
		' 
		Me.labelSexo.AutoSize = True
		Me.labelSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelSexo.Location = New System.Drawing.Point(21, 164)
		Me.labelSexo.Name = "labelSexo"
		Me.labelSexo.Size = New System.Drawing.Size(34, 13)
		Me.labelSexo.TabIndex = 19
		Me.labelSexo.Text = "Sexo:"
		' 
		' textBoxEdad
		' 
		Me.textBoxEdad.Location = New System.Drawing.Point(57, 119)
		Me.textBoxEdad.Name = "textBoxEdad"
		Me.textBoxEdad.Size = New System.Drawing.Size(58, 22)
		Me.textBoxEdad.TabIndex = 18
		AddHandler Me.textBoxEdad.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.textBoxEdad_Validating)
		' 
		' labelEdad
		' 
		Me.labelEdad.AutoSize = True
		Me.labelEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelEdad.Location = New System.Drawing.Point(21, 122)
		Me.labelEdad.Name = "labelEdad"
		Me.labelEdad.Size = New System.Drawing.Size(35, 13)
		Me.labelEdad.TabIndex = 17
		Me.labelEdad.Text = "Edad:"
		' 
		' dateTimePickerFechaNacimiento
		' 
		Me.dateTimePickerFechaNacimiento.CustomFormat = "dd/MM/yyyy"
		Me.dateTimePickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Custom]
		Me.dateTimePickerFechaNacimiento.Location = New System.Drawing.Point(133, 75)
		Me.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento"
		Me.dateTimePickerFechaNacimiento.Size = New System.Drawing.Size(100, 22)
		Me.dateTimePickerFechaNacimiento.TabIndex = 16
		AddHandler Me.dateTimePickerFechaNacimiento.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.dateTimePickerFechaNacimiento_Validating)
		' 
		' labelFechaNacimiento
		' 
		Me.labelFechaNacimiento.AutoSize = True
		Me.labelFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelFechaNacimiento.Location = New System.Drawing.Point(21, 81)
		Me.labelFechaNacimiento.Name = "labelFechaNacimiento"
		Me.labelFechaNacimiento.Size = New System.Drawing.Size(111, 13)
		Me.labelFechaNacimiento.TabIndex = 15
		Me.labelFechaNacimiento.Text = "Fecha de Nacimiento:"
		' 
		' labelNombreModificar
		' 
		Me.labelNombreModificar.AutoSize = True
		Me.labelNombreModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelNombreModificar.Location = New System.Drawing.Point(21, 38)
		Me.labelNombreModificar.Name = "labelNombreModificar"
		Me.labelNombreModificar.Size = New System.Drawing.Size(94, 13)
		Me.labelNombreModificar.TabIndex = 14
		Me.labelNombreModificar.Text = "Nombre Completo:"
		' 
		' textBoxNombreModificar
		' 
		Me.textBoxNombreModificar.Location = New System.Drawing.Point(116, 34)
		Me.textBoxNombreModificar.Name = "textBoxNombreModificar"
		Me.textBoxNombreModificar.Size = New System.Drawing.Size(261, 22)
		Me.textBoxNombreModificar.TabIndex = 13
		AddHandler Me.textBoxNombreModificar.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.textBoxNombreModificar_Validating)
		' 
		' errorProviderNombre
		' 
		Me.errorProviderNombre.ContainerControl = Me
		' 
		' errorProviderFechaNacimiento
		' 
		Me.errorProviderFechaNacimiento.ContainerControl = Me
		' 
		' errorProviderEdad
		' 
		Me.errorProviderEdad.ContainerControl = Me
		' 
		' errorProviderSexo
		' 
		Me.errorProviderSexo.ContainerControl = Me
		' 
		' ModificarPersona
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(522, 421)
		Me.Controls.Add(Me.groupBox)
		Me.Controls.Add(Me.buttonBuscar)
		Me.Controls.Add(Me.labelNombreBuscar)
		Me.Controls.Add(Me.textBoxNombreBuscar)
		Me.Controls.Add(Me.labelModificarPersona)
		Me.Name = "ModificarPersona"
		Me.Text = "Modificar Datos Persona"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModificarPersona_Load)
		Me.groupBox.ResumeLayout(False)
		Me.groupBox.PerformLayout()
		DirectCast(Me.errorProviderNombre, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.errorProviderFechaNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.errorProviderEdad, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.errorProviderSexo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private labelModificarPersona As System.Windows.Forms.Label
	Private labelNombreBuscar As System.Windows.Forms.Label
	Private textBoxNombreBuscar As System.Windows.Forms.TextBox
	Private buttonBuscar As System.Windows.Forms.Button
	Private groupBox As System.Windows.Forms.GroupBox
	Private labelNombreModificar As System.Windows.Forms.Label
	Private textBoxNombreModificar As System.Windows.Forms.TextBox
	Private comboBoxSexo As System.Windows.Forms.ComboBox
	Private labelSexo As System.Windows.Forms.Label
	Private textBoxEdad As System.Windows.Forms.TextBox
	Private labelEdad As System.Windows.Forms.Label
	Private dateTimePickerFechaNacimiento As System.Windows.Forms.DateTimePicker
	Private labelFechaNacimiento As System.Windows.Forms.Label
	Private buttonGrabar As System.Windows.Forms.Button
	Private buttonCancelar As System.Windows.Forms.Button
	Private errorProviderNombre As System.Windows.Forms.ErrorProvider
	Private errorProviderFechaNacimiento As System.Windows.Forms.ErrorProvider
	Private errorProviderEdad As System.Windows.Forms.ErrorProvider
	Private errorProviderSexo As System.Windows.Forms.ErrorProvider
End Class
