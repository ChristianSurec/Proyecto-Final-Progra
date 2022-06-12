<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearNuevaCita.aspx.cs" Inherits="Proyecto_Final_Progra.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h2>Agendar Nueva Cita</h2>
    <h3>&nbsp;</h3>
    <address>
        DPI Paciente<asp:TextBox ID="TextBoxBuscarDPI" runat="server"></asp:TextBox>
</address>
<address>
        <asp:Button ID="ButtonBuscarPaciente" runat="server" Height="47px" OnClick="ButtonBuscarPaciente_Click" Text="Buscar Paciente" Width="157px" />
</address>
<address>
        Nombre<asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
</address>
<address>
        Apellido<asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
</address>
<address>
        Teléfono<asp:TextBox ID="TextBoxTelefono" runat="server"></asp:TextBox>
</address>
<address>
        Fecha de Cita</address>
<address>
        <asp:Calendar ID="CalendarFechaCita" runat="server"></asp:Calendar>
</address>
<address>
        Hora inical de cita<asp:DropDownList ID="DropDownHoraInicio" runat="server" Height="44px" Width="198px">
            <asp:ListItem>Seleccione la Hora de Inicio</asp:ListItem>
            <asp:ListItem>9:00 AM</asp:ListItem>
            <asp:ListItem>9:30 AM</asp:ListItem>
            <asp:ListItem>10:00 AM</asp:ListItem>
            <asp:ListItem>10:30 AM</asp:ListItem>
            <asp:ListItem>11:00 AM</asp:ListItem>
            <asp:ListItem>11:30 AM</asp:ListItem>
            <asp:ListItem>12:00 PM</asp:ListItem>
            <asp:ListItem>1:00 PM</asp:ListItem>
            <asp:ListItem>1:30 PM</asp:ListItem>
            <asp:ListItem>2:00 PM</asp:ListItem>
            <asp:ListItem>2:30 PM</asp:ListItem>
            <asp:ListItem>3:00 PM</asp:ListItem>
            <asp:ListItem>3:30 PM</asp:ListItem>
            <asp:ListItem>4:00 PM</asp:ListItem>
            <asp:ListItem>4:30 PM</asp:ListItem>
            <asp:ListItem>5:00 PM</asp:ListItem>
            <asp:ListItem>5:30 PM</asp:ListItem>
            <asp:ListItem>6:00 PM</asp:ListItem>
        </asp:DropDownList>
</address>
<address>
        Hora final de cita<asp:DropDownList ID="DropDownHoraFin" runat="server" Height="45px" Width="199px">
            <asp:ListItem>Seleccione la Hora Final</asp:ListItem>
            <asp:ListItem>9:00 AM</asp:ListItem>
            <asp:ListItem>9:30 AM</asp:ListItem>
            <asp:ListItem>10:00 AM</asp:ListItem>
            <asp:ListItem>10:30 AM</asp:ListItem>
            <asp:ListItem>11:00 AM</asp:ListItem>
            <asp:ListItem>11:30 AM</asp:ListItem>
            <asp:ListItem>12:00 PM</asp:ListItem>
            <asp:ListItem>1:00 PM</asp:ListItem>
            <asp:ListItem>1:30PM</asp:ListItem>
            <asp:ListItem>2:00 PM</asp:ListItem>
            <asp:ListItem>2:30 PM</asp:ListItem>
            <asp:ListItem>3:00 PM</asp:ListItem>
            <asp:ListItem>3:30 PM</asp:ListItem>
            <asp:ListItem>4:00 PM</asp:ListItem>
            <asp:ListItem>4:30 PM</asp:ListItem>
            <asp:ListItem>5:00 PM</asp:ListItem>
            <asp:ListItem>5:30 PM</asp:ListItem>
            <asp:ListItem>6:00 PM</asp:ListItem>
        </asp:DropDownList>
</address>
<address>
        <asp:Button ID="ButtonGuardarCita" runat="server" Height="68px" OnClick="ButtonGuardarCita_Click" Text="Guardar Cita" Width="191px" />
</address>

    <address>
        &nbsp;</address>
</asp:Content>
