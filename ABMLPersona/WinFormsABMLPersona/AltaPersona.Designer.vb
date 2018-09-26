Partial Class AltaPersona
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
		Me.labelAltaPersona = New System.Windows.Forms.Label()
		Me.textBoxNombre = New System.Windows.Forms.TextBox()
		Me.labelNombre = New System.Windows.Forms.Label()
		Me.labelFechaNacimiento = New System.Windows.Forms.Label()
		Me.dateTimePickerFechaNacimiento = New System.Windows.Forms.DateTimePicker()
		Me.labelEdad = New System.Windows.Forms.Label()
		Me.textBoxEdad = New System.Windows.Forms.TextBox()
		Me.labelSexo = New System.Windows.Forms.Label()
		Me.comboBoxSexo = New System.Windows.Forms.ComboBox()
		Me.buttonGrabar = New System.Windows.Forms.Button()
		Me.errorProviderNombre = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.errorProviderEdad = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.errorProviderSexo = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.errorProviderFechaNacimiento = New System.Windows.Forms.ErrorProvider(Me.components)
		DirectCast(Me.errorProviderNombre, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.errorProviderEdad, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.errorProviderSexo, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.errorProviderFechaNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' labelAltaPersona
		' 
		Me.labelAltaPersona.AutoSize = True
		Me.labelAltaPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelAltaPersona.Location = New System.Drawing.Point(12, 9)
		Me.labelAltaPersona.Name = "labelAltaPersona"
		Me.labelAltaPersona.Size = New System.Drawing.Size(143, 24)
		Me.labelAltaPersona.TabIndex = 0
		Me.labelAltaPersona.Text = "Alta de Persona"
		' 
		' textBoxNombre
		' 
		Me.textBoxNombre.Location = New System.Drawing.Point(129, 59)
		Me.textBoxNombre.Name = "textBoxNombre"
		Me.textBoxNombre.Size = New System.Drawing.Size(261, 20)
		Me.textBoxNombre.TabIndex = 1
		AddHandler Me.textBoxNombre.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.textBoxNombre_Validating)
		' 
		' labelNombre
		' 
		Me.labelNombre.AutoSize = True
		Me.labelNombre.Location = New System.Drawing.Point(33, 62)
		Me.labelNombre.Name = "labelNombre"
		Me.labelNombre.Size = New System.Drawing.Size(94, 13)
		Me.labelNombre.TabIndex = 2
		Me.labelNombre.Text = "Nombre Completo:"
		' 
		' labelFechaNacimiento
		' 
		Me.labelFechaNacimiento.AutoSize = True
		Me.labelFechaNacimiento.Location = New System.Drawing.Point(33, 104)
		Me.labelFechaNacimiento.Name = "labelFechaNacimiento"
		Me.labelFechaNacimiento.Size = New System.Drawing.Size(111, 13)
		Me.labelFechaNacimiento.TabIndex = 3
		Me.labelFechaNacimiento.Text = "Fecha de Nacimiento:"
		' 
		' dateTimePickerFechaNacimiento
		' 
		Me.dateTimePickerFechaNacimiento.CustomFormat = "dd/MM/yyyy"
		Me.dateTimePickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Custom]
		Me.dateTimePickerFechaNacimiento.Location = New System.Drawing.Point(151, 98)
		Me.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento"
		Me.dateTimePickerFechaNacimiento.Size = New System.Drawing.Size(100, 20)
		Me.dateTimePickerFechaNacimiento.TabIndex = 4
		AddHandler Me.dateTimePickerFechaNacimiento.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.dateTimePickerFechaNacimiento_Validating)
		' 
		' labelEdad
		' 
		Me.labelEdad.AutoSize = True
		Me.labelEdad.Location = New System.Drawing.Point(33, 145)
		Me.labelEdad.Name = "labelEdad"
		Me.labelEdad.Size = New System.Drawing.Size(35, 13)
		Me.labelEdad.TabIndex = 5
		Me.labelEdad.Text = "Edad:"
		' 
		' textBoxEdad
		' 
		Me.textBoxEdad.Location = New System.Drawing.Point(69, 142)
		Me.textBoxEdad.Name = "textBoxEdad"
		Me.textBoxEdad.Size = New System.Drawing.Size(58, 20)
		Me.textBoxEdad.TabIndex = 6
		AddHandler Me.textBoxEdad.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.textBoxEdad_Validating)
		' 
		' labelSexo
		' 
		Me.labelSexo.AutoSize = True
		Me.labelSexo.Location = New System.Drawing.Point(33, 187)
		Me.labelSexo.Name = "labelSexo"
		Me.labelSexo.Size = New System.Drawing.Size(34, 13)
		Me.labelSexo.TabIndex = 7
		Me.labelSexo.Text = "Sexo:"
		' 
		' comboBoxSexo
		' 
		Me.comboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxSexo.FormattingEnabled = True
		Me.comboBoxSexo.Items.AddRange(New Object() {"", "Masculino", "Femenino"})
		Me.comboBoxSexo.Location = New System.Drawing.Point(69, 184)
		Me.comboBoxSexo.Name = "comboBoxSexo"
		Me.comboBoxSexo.Size = New System.Drawing.Size(102, 21)
		Me.comboBoxSexo.TabIndex = 8
		AddHandler Me.comboBoxSexo.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.comboBoxSexo_Validating)
		' 
		' buttonGrabar
		' 
		Me.buttonGrabar.Location = New System.Drawing.Point(36, 234)
		Me.buttonGrabar.Name = "buttonGrabar"
		Me.buttonGrabar.Size = New System.Drawing.Size(75, 33)
		Me.buttonGrabar.TabIndex = 9
		Me.buttonGrabar.Text = "Grabar"
		Me.buttonGrabar.UseVisualStyleBackColor = True
		AddHandler Me.buttonGrabar.Click, New System.EventHandler(AddressOf Me.buttonGrabar_Click)
		' 
		' errorProviderNombre
		' 
		Me.errorProviderNombre.ContainerControl = Me
		' 
		' errorProviderEdad
		' 
		Me.errorProviderEdad.ContainerControl = Me
		' 
		' errorProviderSexo
		' 
		Me.errorProviderSexo.ContainerControl = Me
		' 
		' errorProviderFechaNacimiento
		' 
		Me.errorProviderFechaNacimiento.ContainerControl = Me
		' 
		' AltaPersona
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(460, 285)
		Me.Controls.Add(Me.buttonGrabar)
		Me.Controls.Add(Me.comboBoxSexo)
		Me.Controls.Add(Me.labelSexo)
		Me.Controls.Add(Me.textBoxEdad)
		Me.Controls.Add(Me.labelEdad)
		Me.Controls.Add(Me.dateTimePickerFechaNacimiento)
		Me.Controls.Add(Me.labelFechaNacimiento)
		Me.Controls.Add(Me.labelNombre)
		Me.Controls.Add(Me.textBoxNombre)
		Me.Controls.Add(Me.labelAltaPersona)
		Me.Name = "AltaPersona"
		Me.Text = "Alta de Persona"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.AltaPersona_Load)
		DirectCast(Me.errorProviderNombre, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.errorProviderEdad, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.errorProviderSexo, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.errorProviderFechaNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private labelAltaPersona As System.Windows.Forms.Label
	Private textBoxNombre As System.Windows.Forms.TextBox
	Private labelNombre As System.Windows.Forms.Label
	Private labelFechaNacimiento As System.Windows.Forms.Label
	Private dateTimePickerFechaNacimiento As System.Windows.Forms.DateTimePicker
	Private labelEdad As System.Windows.Forms.Label
	Private textBoxEdad As System.Windows.Forms.TextBox
	Private labelSexo As System.Windows.Forms.Label
	Private comboBoxSexo As System.Windows.Forms.ComboBox
	Private buttonGrabar As System.Windows.Forms.Button
	Private errorProviderNombre As System.Windows.Forms.ErrorProvider
	Private errorProviderEdad As System.Windows.Forms.ErrorProvider
	Private errorProviderSexo As System.Windows.Forms.ErrorProvider
	Private errorProviderFechaNacimiento As System.Windows.Forms.ErrorProvider
End Class
