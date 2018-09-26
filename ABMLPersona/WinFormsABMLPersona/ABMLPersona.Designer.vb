Partial Class ABMLPersonas
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
		Me.label1 = New System.Windows.Forms.Label()
		Me.altaPersona = New System.Windows.Forms.Button()
		Me.eliminarPersona = New System.Windows.Forms.Button()
		Me.modificarPersona = New System.Windows.Forms.Button()
		Me.listadoPersonas = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label1.Location = New System.Drawing.Point(12, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(245, 24)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Administración de Personas"
		' 
		' altaPersona
		' 
		Me.altaPersona.Location = New System.Drawing.Point(47, 55)
		Me.altaPersona.Name = "altaPersona"
		Me.altaPersona.Size = New System.Drawing.Size(130, 29)
		Me.altaPersona.TabIndex = 1
		Me.altaPersona.Text = "Alta de Persona"
		Me.altaPersona.UseVisualStyleBackColor = True
		AddHandler Me.altaPersona.Click, New System.EventHandler(AddressOf Me.altaPersona_Click)
		' 
		' eliminarPersona
		' 
		Me.eliminarPersona.Location = New System.Drawing.Point(47, 107)
		Me.eliminarPersona.Name = "eliminarPersona"
		Me.eliminarPersona.Size = New System.Drawing.Size(130, 29)
		Me.eliminarPersona.TabIndex = 2
		Me.eliminarPersona.Text = "Eliminar Persona"
		Me.eliminarPersona.UseVisualStyleBackColor = True
		AddHandler Me.eliminarPersona.Click, New System.EventHandler(AddressOf Me.eliminarPersona_Click)
		' 
		' modificarPersona
		' 
		Me.modificarPersona.Location = New System.Drawing.Point(47, 157)
		Me.modificarPersona.Name = "modificarPersona"
		Me.modificarPersona.Size = New System.Drawing.Size(130, 29)
		Me.modificarPersona.TabIndex = 3
		Me.modificarPersona.Text = "Modificar Persona"
		Me.modificarPersona.UseVisualStyleBackColor = True
		AddHandler Me.modificarPersona.Click, New System.EventHandler(AddressOf Me.modificarPersona_Click)
		' 
		' listadoPersonas
		' 
		Me.listadoPersonas.Location = New System.Drawing.Point(47, 211)
		Me.listadoPersonas.Name = "listadoPersonas"
		Me.listadoPersonas.Size = New System.Drawing.Size(130, 29)
		Me.listadoPersonas.TabIndex = 4
		Me.listadoPersonas.Text = "Listado de Personas"
		Me.listadoPersonas.UseVisualStyleBackColor = True
		AddHandler Me.listadoPersonas.Click, New System.EventHandler(AddressOf Me.listadoPersonas_Click)
		' 
		' ABMLPersonas
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(352, 263)
		Me.Controls.Add(Me.listadoPersonas)
		Me.Controls.Add(Me.modificarPersona)
		Me.Controls.Add(Me.eliminarPersona)
		Me.Controls.Add(Me.altaPersona)
		Me.Controls.Add(Me.label1)
		Me.Name = "ABMLPersonas"
		Me.Text = "Administración de Personas"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private label1 As System.Windows.Forms.Label
	Private altaPersona As System.Windows.Forms.Button
	Private eliminarPersona As System.Windows.Forms.Button
	Private modificarPersona As System.Windows.Forms.Button
	Private listadoPersonas As System.Windows.Forms.Button
End Class

