Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms


Public Partial Class EliminarPersona
    Inherits Form

    Public Sub New()
		InitializeComponent()
	End Sub


    Private Sub buttonBorrar_Click(sender As Object, e As EventArgs)
        Dim wcfPersona As New WebServicePersona.ServiceABMLPersonaClient()

        If wcfPersona.Existe(textBoxNombre.Text) Then
            Dim borro As Boolean = True
            borro = wcfPersona.Borrar(textBoxNombre.Text)

            If borro Then
                MessageBox.Show("La persona fue eliminada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                textBoxNombre.Text = ""
            Else
                MessageBox.Show("Hubo un error al intentar eliminar la persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If
        Else
            MessageBox.Show("La persona que intenta borrar no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

End Class
