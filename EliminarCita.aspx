<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarCita.aspx.cs" Inherits="Proyecto_Final_Progra.EliminarCita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Eliminar Cita</h1>
    <p>
        &nbsp;</p>
    <p>
        DPI Paciente<asp:TextBox ID="TextBoxEnocntrarDPI" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonEncontrar" runat="server" Height="47px" OnClick="ButtonEncontrar_Click" Text="Encontrar Cita" Width="166px" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Fecha de Cita<asp:TextBox ID="TextBoxFechaCita" runat="server" Width="76px"></asp:TextBox>
    </p>
    <p>
        Hora Inicio de Cita<asp:TextBox ID="TextBoxHoraInicio" runat="server"></asp:TextBox>
    </p>
    <p>
        Hora Fin de Cita<asp:TextBox ID="TextBoxHoraFin" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonBorrarCita" runat="server" Height="61px" OnClick="ButtonBorrarCita_Click" Text="Borrar Cita" Width="159px" />
    </p>
</asp:Content>
