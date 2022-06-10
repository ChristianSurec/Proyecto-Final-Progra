<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto_Final_Progra._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Agregar Paciente</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;</h2>
            <p>Nombre<asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
            </p>
            <p>Apellido
                <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
            </p>
            <p>DPI<asp:TextBox ID="TextBoxDPI" runat="server"></asp:TextBox>
            </p>
            <p>Dirección<asp:TextBox ID="TextBoxDireccion" runat="server"></asp:TextBox>
            </p>
            <p>Fecha Nacimiento
                <asp:Calendar ID="CalendarFechaNaci" runat="server"></asp:Calendar>
            </p>
            <p>Teléfono<asp:TextBox ID="TextBoxTelefono" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="ButtonAgregarPaciente" runat="server" Height="52px" OnClick="ButtonAgregarPaciente_Click" Text="Agregar Paciente" Width="129px" />
            </p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
        </div>
    </div>

</asp:Content>
