Partial Class EliminarPersona
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
		Me.labelBajaPersona = New System.Windows.Forms.Label()
		Me.labelNombre = New System.Windows.Forms.Label()
		Me.textBoxNombre = New System.Windows.Forms.TextBox()
		Me.buttonBorrar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' labelBajaPersona
		' 
		Me.labelBajaPersona.AutoSize = True
		Me.labelBajaPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.labelBajaPersona.Location = New System.Drawing.Point(12, 9)
		Me.labelBajaPersona.Name = "labelBajaPersona"
		Me.labelBajaPersona.Size = New System.Drawing.Size(148, 24)
		Me.labelBajaPersona.TabIndex = 1
		Me.labelBajaPersona.Text = "Baja de Persona"
		' 
		' labelNombre
		' 
		Me.labelNombre.AutoSize = True
		Me.labelNombre.Location = New System.Drawing.Point(33, 63)
		Me.labelNombre.Name = "labelNombre"
		Me.labelNombre.Size = New System.Drawing.Size(94, 13)
		Me.labelNombre.TabIndex = 4
		Me.labelNombre.Text = "Nombre Completo:"
		' 
		' textBoxNombre
		' 
		Me.textBoxNombre.Location = New System.Drawing.Point(129, 60)
		Me.textBoxNombre.Name = "textBoxNombre"
		Me.textBoxNombre.Size = New System.Drawing.Size(261, 20)
		Me.textBoxNombre.TabIndex = 3
		' 
		' buttonBorrar
		' 
		Me.buttonBorrar.Location = New System.Drawing.Point(36, 105)
		Me.buttonBorrar.Name = "buttonBorrar"
		Me.buttonBorrar.Size = New System.Drawing.Size(75, 33)
		Me.buttonBorrar.TabIndex = 10
		Me.buttonBorrar.Text = "Borrar"
		Me.buttonBorrar.UseVisualStyleBackColor = True
		AddHandler Me.buttonBorrar.Click, New System.EventHandler(AddressOf Me.buttonBorrar_Click)
		' 
		' EliminarPersona
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(472, 155)
		Me.Controls.Add(Me.buttonBorrar)
		Me.Controls.Add(Me.labelNombre)
		Me.Controls.Add(Me.textBoxNombre)
		Me.Controls.Add(Me.labelBajaPersona)
		Me.Name = "EliminarPersona"
		Me.Text = "Eliminar Persona"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private labelBajaPersona As System.Windows.Forms.Label
	Private labelNombre As System.Windows.Forms.Label
	Private textBoxNombre As System.Windows.Forms.TextBox
	Private buttonBorrar As System.Windows.Forms.Button
End Class
