Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.Text
Imports ModelABMLPersona


<ServiceContract>
Public Interface IServiceABMLPersona

    <OperationContract>
    Function ListadoPersonas() As List(Of Persona)

    <OperationContract>
    Function Existe(nombreCompleto As String) As Boolean

    <OperationContract>
    Function Grabar(nombreCompleto As String, fechaNacimiento As String, edad As Integer, sexo As String) As Boolean

    <OperationContract>
    Function Borrar(nombreCompleto As String) As Boolean

    <OperationContract>
    Function BuscarPersona(nombreCompleto As String) As Persona

    <OperationContract>
    Function Actualizar(nombreAModificar As String, nuevoNombre As String, fechaNacimiento As String, edad As Integer, sexo As String) As Boolean

End Interface
