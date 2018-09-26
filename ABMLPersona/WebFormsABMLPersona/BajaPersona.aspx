<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="BajaPersona.aspx.vb" Inherits="WebFormsABMLPersona.BajaPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Baja de Persona</h1>
            <br />
            Nombre completo:
            <asp:TextBox ID="nombre" runat="server" Width="326px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="borrar" runat="server" Text="Borrar" OnClick="borrar_Click" />
            <br />
            <br />
            <asp:Label ID="mensaje" runat="server"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="volver" runat="server" NavigateUrl="~/Home.aspx">Volver</asp:HyperLink>
        </div>
    </form>
</body>
</html>
