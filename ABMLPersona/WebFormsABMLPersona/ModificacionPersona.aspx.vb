Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports ModelABMLPersona

Public Partial Class ModificacionPersona
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs)
		fechaNacimiento.Attributes.Add("type", "date")
		CompareValidatorFechaNacimiento.ValueToCompare = DateTime.Today.ToShortDateString()
		If Not IsPostBack Then
			modificarDatos.Visible = False
		End If
	End Sub


    Protected Sub buscar_Click(sender As Object, e As EventArgs)
		Dim personaModificar As Persona = ABMLPersona.BuscarPersona(nombreBuscar.Text)

		If personaModificar Is Nothing Then
			mensajeBuscar.Text = "La persona que intenta modificar no existe."
			mensajeBuscar.ForeColor = System.Drawing.Color.Red
		Else
			nombreBuscar.[ReadOnly] = True
			mensajeBuscar.Text = ""
			nombre.Text = personaModificar.NombreCompleto
			fechaNacimiento.Value = personaModificar.FechaNacimiento.ToString("yyyy-MM-dd")
			edad.Text = personaModificar.Edad.ToString()
			sexo.SelectedValue = personaModificar.Sexo.ToString()
			modificarDatos.Visible = True
		End If
	End Sub


    Protected Sub grabar_Click(sender As Object, e As EventArgs)
		If IsValid Then
			If ABMLPersona.Existe(nombre.Text) AndAlso Not (nombreBuscar.Text.Equals(nombre.Text)) Then
				mensajeGrabar.Text = "La persona que intenta modificar ya existe."
				mensajeGrabar.ForeColor = System.Drawing.Color.Red
			Else
				Dim actualizo As Boolean = True
				actualizo = ABMLPersona.Actualizar(nombreBuscar.Text, nombre.Text, Request.Form("fechaNacimiento"), Integer.Parse(edad.Text), sexo.Text)

				If actualizo Then
					nombreBuscar.[ReadOnly] = False
					nombreBuscar.Text = ""
					modificarDatos.Visible = False
					mensajeBuscar.Text = "Los datos se actualizaron correctamente."
					mensajeBuscar.ForeColor = System.Drawing.Color.Green
				Else
					mensajeGrabar.Text = "Hubo un error al intentar actualizar los datos."
					mensajeGrabar.ForeColor = System.Drawing.Color.Red
				End If
			End If
		End If
	End Sub


    Protected Sub ButtonCancelar_Click(sender As Object, e As EventArgs)
        nombreBuscar.[ReadOnly] = False
        nombre.Text = ""
        fechaNacimiento.Value = DateTime.Now.ToString("yyyy-MM-dd")
        edad.Text = ""
        sexo.SelectedValue = ""
        modificarDatos.Visible = False
    End Sub

End Class
