<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarDatosPacientes.aspx.cs" Inherits="Proyecto_Final_Progra.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Editar Datos de Paciente</h2>
    &nbsp;DPI del Paciente<asp:TextBox ID="TextBoxEditarDPI" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="ButtonBuscarPaciente" runat="server" Height="48px" OnClick="ButtonBuscarPaciente_Click" Text="Buscar Paciente" Width="141px" />
    <br />
    <br />
    Nombre<asp:TextBox ID="TextBoxEditarNombre" runat="server"></asp:TextBox>
    <br />
    Apellido<asp:TextBox ID="TextBoxEditarApellido" runat="server"></asp:TextBox>
    <br />
    Dirección<asp:TextBox ID="TextBoxEditarDireccion" runat="server"></asp:TextBox>
    <br />
    Fecha Nacimiento<asp:TextBox ID="TextBoxEditarFechaNaci" runat="server" Width="165px"></asp:TextBox>
    <br />
    <asp:Calendar ID="CalendarFechaNaci" runat="server"></asp:Calendar>
    <br />
    Teléfono<asp:TextBox ID="TextBoxEditarTelefono" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="ButtonGuardar" runat="server" Height="50px" OnClick="ButtonGuardar_Click" Text="Guardar Cambios" Width="165px" />
    <br />
</asp:Content>
