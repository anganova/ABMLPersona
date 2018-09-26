Imports ModelABMLPersona
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Public Partial Class ListadoPersonas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        GridViewPersonas.DataSource = ABMLPersona.ListadoPersonas()
        GridViewPersonas.DataBind()
    End Sub

End Class
