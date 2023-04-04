<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Inv_CSS.aspx.cs" Inherits="LMNOP_System01.Pages.Inv_CSS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="container box">
        
   <div class="table-container">
                   <asp:GridView ID="tabla" runat="server" Height="249px" CssClass="table is-selected">
            </asp:GridView>
           
             </div>
    </div>
</asp:Content>
