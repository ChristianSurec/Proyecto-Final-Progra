<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarMedicamento.aspx.cs" Inherits="Proyecto_Final_Progra.EditarMedicamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>&nbsp;</h1>
    <h1>Editar Medicamento</h1>
    <p>
        &nbsp;</p>
    <p>
        ID del Medicamento<asp:TextBox ID="TextBoxIDMedicamento" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonBuscarMedicamento" runat="server" Height="54px" OnClick="ButtonBuscarMedicamento_Click" Text="Buscar Medicamento" Width="143px" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Ingrediente del Medicamento<asp:TextBox ID="TextBoxIngredienteMedicamento" runat="server"></asp:TextBox>
    </p>
    <p>
        Marca Comercial<asp:TextBox ID="TextBoxMarcaComercial" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="ButtonGuardarCambios" runat="server" Height="61px" OnClick="ButtonGuardarCambios_Click" Text="Guardar Cambios" Width="152px" />
    </p>
</asp:Content>
