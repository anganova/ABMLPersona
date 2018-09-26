<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Home.aspx.vb" Inherits="WebFormsABMLPersona.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Administración de Personas</h1>
            <br />
            <asp:HyperLink ID="altaPersona" runat="server" NavigateUrl="~/AltaPersona.aspx">Alta de Persona</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="bajaPersona" runat="server" NavigateUrl="~/BajaPersona.aspx">Eliminar Persona</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="modificarPersona" runat="server" NavigateUrl="~/ModificacionPersona.aspx">Modificar Persona</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="listadoPersona" runat="server" NavigateUrl="~/ListadoPersonas.aspx">Listado Personas</asp:HyperLink>
        </div>
    </form>
</body>
</html>
