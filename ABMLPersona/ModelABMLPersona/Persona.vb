Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class Persona

    Private nombreCompletoVar As String
    Private fechaNacimientoVar As DateTime
    Private edadVar As Integer
    Private SexoVar As Char


    Public Sub New()
    End Sub


    Public Property NombreCompleto() As String
        Get
            Return nombreCompletoVar
        End Get
        Set
            nombreCompletoVar = Value
        End Set
    End Property


    Public Property FechaNacimiento() As DateTime
        Get
            Return fechaNacimientoVar
        End Get
        Set
            fechaNacimientoVar = Value
        End Set
    End Property


    Public Property Edad() As Integer
        Get
            Return edadVar
        End Get
        Set
            edadVar = Value
        End Set
    End Property


    Public Property Sexo() As Char
        Get
            Return SexoVar
        End Get
        Set
            SexoVar = Value
        End Set
    End Property


    Public Sub New(nombreCompleto As String, fechaNacimiento As DateTime, edad As Integer, sexo As Char)
        Me.NombreCompleto = nombreCompleto
        Me.FechaNacimiento = fechaNacimiento
        Me.Edad = edad
        Me.Sexo = sexo
    End Sub

End Class
