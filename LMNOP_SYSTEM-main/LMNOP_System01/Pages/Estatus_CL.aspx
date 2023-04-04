<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Estatus_CL.aspx.cs" Inherits="LMNOP_System01.Pages.Estatus_CL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

     <div class="container box">

     
     <div class="field">

                      <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="estatus" CssClass="button is-success is-rounded is-medium is-res" title="No puedes editar este campo" disabled OnClick="estatus_Click" Text="Maquila detenida"/>
            </div>
        </div>
        </div>

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
