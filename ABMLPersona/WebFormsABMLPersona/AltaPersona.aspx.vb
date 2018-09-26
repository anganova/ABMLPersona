Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports ModelABMLPersona

Public Partial Class AltaPersona
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs)
		fechaNacimiento.Attributes.Add("type", "date")
		mensaje.Visible = False
		CompareValidatorFechaNacimiento.ValueToCompare = DateTime.Today.ToShortDateString()
	End Sub


    Protected Sub grabar_Click(sender As Object, e As EventArgs)
        If IsValid Then
            If ABMLPersona.Existe(nombre.Text) Then
                mensaje.Visible = True
                mensaje.Text = "La persona que intenta ingresar ya existe."
                mensaje.ForeColor = System.Drawing.Color.Red
            Else
                Dim grabo As Boolean = True
                grabo = ABMLPersona.Grabar(nombre.Text, Request.Form("fechaNacimiento"), Integer.Parse(edad.Text), sexo.Text)

                If grabo Then
                    mensaje.Visible = True
                    mensaje.Text = "Los datos se guardaron correctamente."
                    mensaje.ForeColor = System.Drawing.Color.Green
                    nombre.Text = ""
                    fechaNacimiento.Value = ""
                    edad.Text = ""
                    sexo.SelectedIndex = 0
                Else
                    mensaje.Visible = True
                    mensaje.Text = "Hubo un error al intentar guardar los datos."
                    mensaje.ForeColor = System.Drawing.Color.Red
                End If
            End If
        End If
    End Sub

End Class
