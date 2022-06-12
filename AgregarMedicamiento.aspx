<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarMedicamiento.aspx.cs" Inherits="Proyecto_Final_Progra.AgregarMedicamiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>&nbsp;</h1>
    <h1>Agregar Nuevo Medicamento</h1>
    <p>
        &nbsp;</p>
    <p>
        Agregar ID medicamento<asp:TextBox ID="TextBoxIDMedicamento" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </p>
    <p>
        Ingredientes del Medicamento<asp:TextBox ID="TextBoxIngredienteMedicamento" runat="server"></asp:TextBox>
    </p>
    <p>
        Marca Comercial<asp:TextBox ID="TextBoxMarcaComercial" runat="server"></asp:TextBox>
    </p>
    <p>
        Listado de enfermedades a las que se puede aplicar<asp:TextBox ID="TextBoxListadoEnfermedadTemp" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonAgregarTemp" runat="server" Height="41px" Text="Agregar" Width="121px" OnClick="ButtonAgregarTemp_Click" />
    </p>
    <p>
        <asp:GridView ID="GridViewListadoEnfermedades" runat="server">
        </asp:GridView>
        <asp:Button ID="ButtonGuardarMedicamento" runat="server" Height="52px" OnClick="Button2_Click" Text="Guardar Medicamento" Width="170px" />
    </p>
</asp:Content>
