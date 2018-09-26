Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports ModelABMLPersona

Public Partial Class BajaPersona
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs)

	End Sub


    Protected Sub borrar_Click(sender As Object, e As EventArgs)
        If ABMLPersona.Existe(nombre.Text) Then
            Dim borro As Boolean = True
            borro = ABMLPersona.Borrar(nombre.Text)

            If borro Then
                mensaje.Text = "La persona fue eliminada exitosamente."
                nombre.Text = ""
                mensaje.ForeColor = System.Drawing.Color.Green
            Else
                mensaje.Text = "Hubo un error al intentar eliminar la persona."
                mensaje.ForeColor = System.Drawing.Color.Red
            End If
        Else
            mensaje.Text = "La persona que intenta borrar no existe."
            mensaje.ForeColor = System.Drawing.Color.Red
        End If
    End Sub

End Class
