Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports WinFormsABMLPersona.WebServicePersona


Partial Public Class ModificarPersona
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub ModificarPersona_Load(sender As Object, e As EventArgs)
        groupBox.Visible = False
        Me.Height = 180

        comboBoxSexo.DisplayMember = "Text"
        comboBoxSexo.ValueMember = "Value"
        comboBoxSexo.DataSource = {
            New With {
                Key .Text = "",
                Key .Value = ""},
            New With {
                Key .Text = "Masculino",
                Key .Value = "M"},
            New With {
                Key .Text = "Femenino",
                Key .Value = "F"}
        }
        comboBoxSexo.SelectedIndex = 0
    End Sub


    Private Sub buttonBuscar_Click(sender As Object, e As EventArgs)
        Dim wcfPersona As New WebServicePersona.ServiceABMLPersonaClient()
        Dim personaModificar As Persona = wcfPersona.BuscarPersona(textBoxNombreBuscar.Text)

        If personaModificar Is Nothing Then
            MessageBox.Show("La persona que intenta modificar no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            textBoxNombreBuscar.[ReadOnly] = True
            textBoxNombreModificar.Text = personaModificar.NombreCompleto
            dateTimePickerFechaNacimiento.Value = personaModificar.FechaNacimiento
            textBoxEdad.Text = personaModificar.Edad.ToString()
            comboBoxSexo.SelectedValue = personaModificar.Sexo.ToString()
            groupBox.Visible = True
            Me.Height = 460

            errorProviderNombre.SetError(textBoxNombreModificar, "")
            errorProviderFechaNacimiento.SetError(dateTimePickerFechaNacimiento, "")
            errorProviderEdad.SetError(textBoxEdad, "")
            errorProviderSexo.SetError(comboBoxSexo, "")
        End If
    End Sub


    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs)
        textBoxNombreBuscar.[ReadOnly] = False
        textBoxNombreModificar.Text = ""
        dateTimePickerFechaNacimiento.Value = DateTime.Now
        textBoxEdad.Text = ""
        comboBoxSexo.SelectedValue = ""
        groupBox.Visible = False
        Me.Height = 180
    End Sub


    Private Sub buttonGrabar_Click(sender As Object, e As EventArgs)
        Try
            If errorProviderNombre.GetError(textBoxNombreModificar) = "" AndAlso errorProviderFechaNacimiento.GetError(dateTimePickerFechaNacimiento) = "" AndAlso errorProviderEdad.GetError(textBoxEdad) = "" AndAlso errorProviderSexo.GetError(comboBoxSexo) = "" Then
                Dim wcfPersona As New WebServicePersona.ServiceABMLPersonaClient()

                If wcfPersona.Existe(textBoxNombreModificar.Text) AndAlso Not (textBoxNombreBuscar.Text.Equals(textBoxNombreModificar.Text)) Then
                    MessageBox.Show("La persona que intenta modificar ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Else
                    Dim actualizo As Boolean = True
                    actualizo = wcfPersona.Actualizar(textBoxNombreBuscar.Text, textBoxNombreModificar.Text, dateTimePickerFechaNacimiento.Text, Integer.Parse(textBoxEdad.Text), comboBoxSexo.SelectedValue.ToString())

                    If actualizo Then
                        textBoxNombreBuscar.[ReadOnly] = False
                        textBoxNombreBuscar.Text = ""

                        groupBox.Visible = False
                        Me.Height = 180
                        MessageBox.Show("Los datos se actualizaron correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Hubo un error al intentar actualizar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    End If
                End If
            Else
                MessageBox.Show("Los datos ingresados son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If
        Catch exc As Exception
            MessageBox.Show("Los datos ingresados son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try

    End Sub


    Private Sub textBoxNombreModificar_Validating(sender As Object, e As CancelEventArgs)
        If textBoxNombreModificar.Text.Trim().Length = 0 Then
            errorProviderNombre.SetError(textBoxNombreModificar, "Debe ingresar el nombre.")
        Else
            errorProviderNombre.SetError(textBoxNombreModificar, "")
        End If
    End Sub


    Private Sub dateTimePickerFechaNacimiento_Validating(sender As Object, e As CancelEventArgs)
        If dateTimePickerFechaNacimiento.Value > DateTime.Now Then
            errorProviderFechaNacimiento.SetError(dateTimePickerFechaNacimiento, "La fecha ingresada es incorrecta.")
        Else
            errorProviderFechaNacimiento.SetError(dateTimePickerFechaNacimiento, "")
        End If
    End Sub


    Private Sub textBoxEdad_Validating(sender As Object, e As CancelEventArgs)
        Dim edad As String = textBoxEdad.Text.Trim()

        If edad.Length = 0 Then
            errorProviderEdad.SetError(textBoxEdad, "Debe ingresar la edad.")
        ElseIf Regex.IsMatch(edad, "\d") Then
            If Integer.Parse(edad) < 0 OrElse Integer.Parse(edad) > 150 Then
                errorProviderEdad.SetError(textBoxEdad, "La edad ingresada es incorrecta.")
            Else
                errorProviderEdad.SetError(textBoxEdad, "")
            End If
        Else
            errorProviderEdad.SetError(textBoxEdad, "La edad ingresada es incorrecta.")
        End If
    End Sub


    Private Sub comboBoxSexo_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(comboBoxSexo.SelectedValue, String) = "" Then
            errorProviderSexo.SetError(comboBoxSexo, "Debe ingresar el sexo.")
        Else
            errorProviderSexo.SetError(comboBoxSexo, "")
        End If
    End Sub
End Class
