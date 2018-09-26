Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text

Public NotInheritable Class ABMLPersona

    Private Const CADENA_CONEXION As String = "Data Source=DESKTOP-4PM737V;Initial Catalog=Persona;Integrated Security=true;"

    Private Sub New()
    End Sub


    Public Shared Function ListadoPersonas() As List(Of Persona)
        ListadoPersonas = Nothing

        Try
            ListadoPersonas = New List(Of Persona)()

            Dim conexion As New SqlConnection(CADENA_CONEXION)
            conexion.Open()
            Dim comando As New SqlCommand("select nombreCompleto, fechaNacimiento, edad, sexo from Persona where borrado = 0 order by nombreCompleto", conexion)
            Dim registro As SqlDataReader = comando.ExecuteReader()

            While registro.Read()
                ListadoPersonas.Add(New Persona(registro("nombreCompleto").ToString(), DateTime.Parse(registro("fechaNacimiento").ToString()), Integer.Parse(registro("edad").ToString()), Char.Parse(registro("sexo").ToString())))
            End While

            conexion.Close()
            Return ListadoPersonas
        Catch e As Exception
            Return ListadoPersonas
        End Try
	End Function


    Public Shared Function Existe(nombreCompleto As String) As Boolean
        Existe = False

        Try
            Dim conexion As New SqlConnection(CADENA_CONEXION)
            conexion.Open()
            Dim comando As New SqlCommand("select * from Persona where nombreCompleto = @nombreCompleto and borrado = 0 order by nombreCompleto", conexion)
            comando.Parameters.Add(New SqlParameter("@nombreCompleto", nombreCompleto))

            Dim registro As SqlDataReader = comando.ExecuteReader()
            If registro.Read() Then
                Existe = True
            End If

            conexion.Close()
            Return Existe
        Catch e As Exception
            Return False
		End Try

	End Function


    Public Shared Function Grabar(nombreCompleto As String, fechaNacimiento As String, edad As Integer, sexo As String) As Boolean
        Grabar = True

        Try
            Dim conexion As New SqlConnection(CADENA_CONEXION)
            conexion.Open()
            Dim comando As New SqlCommand("insert into Persona(nombreCompleto,fechaNacimiento,edad,sexo,ultimaActualizacion,borrado) " & "values(@nombreCompleto,@fechaNacimiento,@edad,@sexo,@ultimaActualizacion,@borrado)", conexion)
            comando.Parameters.Add(New SqlParameter("@nombreCompleto", nombreCompleto))
            comando.Parameters.Add(New SqlParameter("@fechaNacimiento", DateTime.Parse(fechaNacimiento).ToString("yyyyMMdd")))
            comando.Parameters.Add(New SqlParameter("@edad", edad))
            comando.Parameters.Add(New SqlParameter("@sexo", sexo))
            comando.Parameters.Add(New SqlParameter("@ultimaActualizacion", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")))
            comando.Parameters.Add(New SqlParameter("@borrado", False))

            If comando.ExecuteNonQuery() = 0 Then
                Grabar = False
            End If

            conexion.Close()
            Return Grabar
        Catch e As Exception
            Return False
		End Try

	End Function


    Public Shared Function Borrar(nombreCompleto As String) As Boolean
        Borrar = True

        Try
            Dim conexion As New SqlConnection(CADENA_CONEXION)
            conexion.Open()
            Dim comando As New SqlCommand("update Persona set ultimaActualizacion = @ultimaActualizacion, borrado = @borrado where nombreCompleto = @nombreCompleto", conexion)
            comando.Parameters.Add(New SqlParameter("@nombreCompleto", nombreCompleto))
            comando.Parameters.Add(New SqlParameter("@ultimaActualizacion", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")))
            comando.Parameters.Add(New SqlParameter("@borrado", True))

            If comando.ExecuteNonQuery() = 0 Then
                Borrar = False
            End If

            conexion.Close()
            Return Borrar
        Catch e As Exception
            Return False
		End Try

	End Function


    Public Shared Function BuscarPersona(nombreCompleto As String) As Persona
        BuscarPersona = Nothing

        Try
            Dim conexion As New SqlConnection(CADENA_CONEXION)
            conexion.Open()
            Dim comando As New SqlCommand("select nombreCompleto, fechaNacimiento, edad, sexo from Persona where nombreCompleto = @nombreCompleto and borrado = 0", conexion)
            comando.Parameters.Add(New SqlParameter("@nombreCompleto", nombreCompleto))

            Dim registro As SqlDataReader = comando.ExecuteReader()
            If registro.Read() Then
                BuscarPersona = New Persona(registro("nombreCompleto").ToString(), DateTime.Parse(registro("fechaNacimiento").ToString()), Integer.Parse(registro("edad").ToString()), Char.Parse(registro("sexo").ToString()))
            End If

            conexion.Close()
            Return BuscarPersona
        Catch e As Exception
            Return BuscarPersona
        End Try
	End Function


    Public Shared Function Actualizar(nombreAModificar As String, nuevoNombre As String, fechaNacimiento As String, edad As Integer, sexo As String) As Boolean
        Actualizar = True

        Try
            Dim conexion As New SqlConnection(CADENA_CONEXION)
            conexion.Open()
            Dim comando As New SqlCommand("update Persona set nombreCompleto = @nuevoNombre, fechaNacimiento = @fechaNacimiento, edad = @edad, sexo = @sexo, ultimaActualizacion = @ultimaActualizacion where nombreCompleto = @nombreAModificar and borrado = @borrado", conexion)
            comando.Parameters.Add(New SqlParameter("@nuevoNombre", nuevoNombre))
            comando.Parameters.Add(New SqlParameter("@fechaNacimiento", DateTime.Parse(fechaNacimiento).ToString("yyyyMMdd")))
            comando.Parameters.Add(New SqlParameter("@edad", edad))
            comando.Parameters.Add(New SqlParameter("@sexo", sexo))
            comando.Parameters.Add(New SqlParameter("@ultimaActualizacion", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")))
            comando.Parameters.Add(New SqlParameter("@nombreAModificar", nombreAModificar))
            comando.Parameters.Add(New SqlParameter("@borrado", False))

            If comando.ExecuteNonQuery() = 0 Then
                Actualizar = False
            End If

            conexion.Close()
            Return Actualizar
        Catch e As Exception
            Return False
		End Try
	End Function
End Class
