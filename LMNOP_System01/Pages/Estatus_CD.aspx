<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Estatus_CD.aspx.cs" Inherits="LMNOP_System01.Pages.Estatus_CD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
 <div class="container box">
     
            <div class="field">
            <div class="columns">
                <div class="column">
                    <div class="control has-icons-left">
                        <asp:TextBox runat="server" id="txtSearch" class="input" type="text" placeholder="Buscar por numero de maquila"></asp:TextBox>
                        <span class="icon is-small is-left"><i class="fa-solid fa-magnifying-glass"></i></span>
                    </div>
                </div>
                <div class="column is-one-fifth">
                    <div class="control">
                        <asp:Button runat="server" ID="btnBuscar" CssClass="button is-success is-outlined is-rounded is-res" OnClick="btnBuscar_Click" Text="Buscar"/>
                    </div>
                </div>
            </div>
        </div>
     
     <div class="field">

                      <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="estatus" CssClass="button is-success is-rounded is-medium is-res" title="No puedes editar este campo" disabled OnClick="estatus_Click" Text="Maquila"/>
            </div>
        </div>
        </div>

     <div class="table-container">
                   <asp:GridView ID="gridview" runat="server" Height="249px" CssClass="table is-selected">
            </asp:GridView>
           
             </div>

         <div>
                
            </div>

     </div>


         

</asp:Content>
