Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.Text
Imports ModelABMLPersona

Public Class ServiceABMLPersona
    Implements IServiceABMLPersona

    Public Function ListadoPersonas() As List(Of Persona) Implements IServiceABMLPersona.ListadoPersonas
        Return ABMLPersona.ListadoPersonas()
    End Function


    Public Function Existe(nombreCompleto As String) As Boolean Implements IServiceABMLPersona.Existe
        Return ABMLPersona.Existe(nombreCompleto)
    End Function


    Public Function Grabar(nombreCompleto As String, fechaNacimiento As String, edad As Integer, sexo As String) As Boolean Implements IServiceABMLPersona.Grabar
        Return ABMLPersona.Grabar(nombreCompleto, fechaNacimiento, edad, sexo)
    End Function


    Public Function Borrar(nombreCompleto As String) As Boolean Implements IServiceABMLPersona.Borrar
        Return ABMLPersona.Borrar(nombreCompleto)
    End Function


    Public Function BuscarPersona(nombreCompleto As String) As Persona Implements IServiceABMLPersona.BuscarPersona
        Return ABMLPersona.BuscarPersona(nombreCompleto)
    End Function


    Public Function Actualizar(nombreAModificar As String, nuevoNombre As String, fechaNacimiento As String, edad As Integer, sexo As String) As Boolean Implements IServiceABMLPersona.Actualizar
        Return ABMLPersona.Actualizar(nombreAModificar, nuevoNombre, fechaNacimiento, edad, sexo)
    End Function

End Class
