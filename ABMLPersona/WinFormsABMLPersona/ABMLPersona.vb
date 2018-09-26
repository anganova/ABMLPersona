Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Partial Class ABMLPersonas
	Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub altaPersona_Click(sender As Object, e As EventArgs)
		Dim altaPersona As New AltaPersona()
		altaPersona.ShowDialog()
	End Sub


    Private Sub listadoPersonas_Click(sender As Object, e As EventArgs)
		Dim listadoPersonas As New ListadoPersonas()
		listadoPersonas.ShowDialog()
	End Sub


    Private Sub eliminarPersona_Click(sender As Object, e As EventArgs)
		Dim eliminarPersona As New EliminarPersona()
		eliminarPersona.ShowDialog()
	End Sub


    Private Sub modificarPersona_Click(sender As Object, e As EventArgs)
        Dim modificarPersona As New ModificarPersona()
        modificarPersona.ShowDialog()
    End Sub

End Class
