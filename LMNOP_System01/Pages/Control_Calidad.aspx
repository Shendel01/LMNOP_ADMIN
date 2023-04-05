<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Control_Calidad.aspx.cs" Inherits="LMNOP_System01.Pages.Control_Calidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    
    <div class="container box">

        <div>
        <h1><label>¡Bienvenido al área de calidad!</label></h1> 
            </div>
        <div>
        <label>
            Por favor, seleccione una de las siguientes opciones.
        </label>
        </div>
                    <br />
    <%--    <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="liberada" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="liberada_Click" Text="Liberada"/>
            </div>
        </div>--%>


        <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="detenida" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="detenida_Click" Text="Maquilas"/>
            </div>
        </div>

    </div>

</asp:Content>
