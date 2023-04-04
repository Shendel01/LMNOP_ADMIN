<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Estatus_AS.aspx.cs" Inherits="LMNOP_System01.Pages.prueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

     <div class="container box">

     




         <div class="table-container">
                   <asp:GridView ID="gridview" runat="server" Height="249px" CssClass="table is-selected">
            </asp:GridView>
           
             </div>

         <div>
                 <div>
            
             <asp:Button runat="server" ID="back" CssClass="button is-danger is-outlined is-rounded is-medium is-res" OnClick="back_Click" Text="Regresar"/> <%--Index--%>
                     </div>
            </div>
    </div>

</asp:Content>
