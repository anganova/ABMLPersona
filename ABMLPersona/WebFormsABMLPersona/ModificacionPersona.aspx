<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="ModificacionPersona.aspx.vb" Inherits="WebFormsABMLPersona.ModificacionPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Modificar datos Persona</h1>
            <br />
            Nombre completo:
            <asp:TextBox ID="nombreBuscar" runat="server" Width="326px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="buscar" runat="server" Text="Buscar" OnClick="buscar_Click" />
            <br />
            <br />
            <asp:Label ID="mensajeBuscar" runat="server"></asp:Label>
            <br />
            <div id="modificarDatos" runat="server">
                <h3>Datos a modificar</h3>
                <br />
                Nombre completo:
                <asp:TextBox ID="nombre" runat="server" Width="326px"></asp:TextBox>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombre" runat="server" ControlToValidate="nombre" ErrorMessage="Debe ingresar el nombre."></asp:RequiredFieldValidator>
                <br />
                <br />
                Fecha de nacimiento:
                <input id="fechaNacimiento" type="text" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorFechaNacimiento" runat="server" ControlToValidate="fechaNacimiento" ErrorMessage="Debe seleccionar la fecha de nacimiento."></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorFechaNacimiento" runat="server" ControlToValidate="fechaNacimiento" ErrorMessage="La fecha ingresada es incorrecta." Operator="LessThanEqual" Type="Date"></asp:CompareValidator>
                <br />
                <br />
                Edad:
                <asp:TextBox ID="edad" runat="server" Width="60px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidatorEdad" runat="server" ControlToValidate="edad" ErrorMessage="Debe ingresar la edad."></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidatorEdad" runat="server" ControlToValidate="edad" ErrorMessage="La edad ingresada es incorrecta." MaximumValue="150" MinimumValue="0" Type="Integer"></asp:RangeValidator>
                <br />
                <br />
                Sexo:
                <asp:DropDownList ID="sexo" runat="server" Height="16px" Width="88px">
                    <asp:ListItem Selected="True"></asp:ListItem>
                    <asp:ListItem Value="M">Masculino</asp:ListItem>
                    <asp:ListItem Value="F">Femenino</asp:ListItem>
                </asp:DropDownList>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidatorSexo" runat="server" ControlToValidate="sexo" ErrorMessage="Debe ingresar el sexo."></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Button ID="grabar" runat="server" Text="Grabar" Height="27px" Width="66px" OnClick="grabar_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonCancelar" runat="server" CausesValidation="False" Height="27px" OnClick="ButtonCancelar_Click" style="margin-top: 5px" Text="Cancelar" />
                <br />
                <br />
                <asp:Label ID="mensajeGrabar" runat="server"></asp:Label>
                <br />
                <br />
            </div>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Volver</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;<br />
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
