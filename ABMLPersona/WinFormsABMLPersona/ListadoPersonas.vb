Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Partial Class ListadoPersonas
    Inherits Form

    Public Sub New()
        InitializeComponent()
        Dim wcfPersona As New WebServicePersona.ServiceABMLPersonaClient()
        dataGridPersonas.DataSource = wcfPersona.ListadoPersonas()
    End Sub

End Class
