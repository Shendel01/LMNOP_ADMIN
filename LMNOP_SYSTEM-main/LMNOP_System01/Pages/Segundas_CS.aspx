<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Segundas_CS.aspx.cs" Inherits="LMNOP_System01.Pages.Segundas_CS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

    <div class="container box">

        <div class="field">

            <label>
                Número de segundas
            </label>
            <div>
                <asp:TextBox runat="server" id="num_segundas" class="input" type="text" placeholder="Ingrese el código de segundas"></asp:TextBox>
            </div>
        </div>

        <div class="field">
            <label>
                Número de piezas
            </label>
            <div>
                <asp:TextBox runat="server" id="num_piezas" class="input" type="text" placeholder="Ingrese el número de piezas"></asp:TextBox>
            </div>
        </div>
        <div class="field">
            <label>
                Kilogramos
            </label>
            <div>
                <asp:TextBox runat="server" id="kg" class="input" type="text" placeholder="Ingresa los kilogramos"></asp:TextBox>
            </div>
        </div>

      <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="Enviar" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="Enviar_Click" Text="Enviar"/>
            </div>
    </div>

   <div class="table-container">
                   <asp:GridView ID="tabla" runat="server" Height="249px" CssClass="table is-selected">
            </asp:GridView>
           
             </div>

        
         <div>
             <asp:Button runat="server" ID="back" CssClass="button is-danger is-outlined is-rounded is-medium is-res" OnClick="back_Click" Text="Regresar"/>
         </div>
    </div>
</asp:Content>
