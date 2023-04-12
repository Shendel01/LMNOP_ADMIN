<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Atencion_sucursales.aspx.cs" Inherits="LMNOP_System01.Pages.Atencion_sucursales" %>
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
        
        <hr />

        <div class="field">
          <label class="label">Número de maquila</label>

          <div class="control">
            <asp:TextBox runat="server" id="num_maquila" class="input" type="text" placeholder="Ingrese el número de maquila"></asp:TextBox>
          </div>
        </div>

        <div class="field">
          <label class="label">Documento</label>

          <div class="control">
            <asp:TextBox runat="server" id="documento" class="input" type="text" placeholder="Ingrese el número de documento"></asp:TextBox>
          </div>
        </div>

        <div class="field">
          <label class="label">División</label>

          <div class="control">
            <asp:TextBox runat="server" id="division" class="input" type="text" placeholder="Ingrese la división"></asp:TextBox>
          </div>
        </div>

        <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="Enviar" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="Enviar_Click" Text="Enviar"/>
            </div>
        </div>


        <div class="table-container">
            <asp:GridView ID="gridview" runat="server" Height="249px" CssClass="table is-selected"></asp:GridView>
        </div>

        <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="maquila_detenida" CssClass="button is-info is-rounded is-medium is-res" OnClick="maquila_detenida_Click" Text="Maquila"/>
                <asp:Button runat="server" ID="estatus" CssClass="button is-info is-rounded is-medium is-res" OnClick="estatus_Click" Text="Estatus"/>
            </div>
        </div>

    </div>
</asp:Content>