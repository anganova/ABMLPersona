Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms


Partial Public Class AltaPersona
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub AltaPersona_Load(sender As Object, e As EventArgs)
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


    Private Sub buttonGrabar_Click(sender As Object, e As EventArgs)
        Try
            If errorProviderNombre.GetError(textBoxNombre) = "" AndAlso errorProviderFechaNacimiento.GetError(dateTimePickerFechaNacimiento) = "" AndAlso errorProviderEdad.GetError(textBoxEdad) = "" AndAlso errorProviderSexo.GetError(comboBoxSexo) = "" Then
                Dim wcfPersona As New WebServicePersona.ServiceABMLPersonaClient()

                If wcfPersona.Existe(textBoxNombre.Text) Then
                    MessageBox.Show("La persona que intenta ingresar ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Else
                    Dim grabo As Boolean = True
                    grabo = wcfPersona.Grabar(textBoxNombre.Text, dateTimePickerFechaNacimiento.Text, Integer.Parse(textBoxEdad.Text), comboBoxSexo.SelectedValue.ToString())

                    If grabo Then
                        MessageBox.Show("Los datos se guardaron correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        textBoxNombre.Text = ""
                        dateTimePickerFechaNacimiento.Value = DateTime.Now
                        textBoxEdad.Text = ""
                        comboBoxSexo.SelectedValue = ""
                    Else
                        MessageBox.Show("Hubo un error al intentar guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    End If
                End If
            Else
                MessageBox.Show("Los datos ingresados son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If
        Catch exc As Exception
            MessageBox.Show("Los datos ingresados son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub


    Private Sub textBoxNombre_Validating(sender As Object, e As CancelEventArgs)
        If textBoxNombre.Text.Trim().Length = 0 Then
            errorProviderNombre.SetError(textBoxNombre, "Debe ingresar el nombre.")
        Else
            errorProviderNombre.SetError(textBoxNombre, "")
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
