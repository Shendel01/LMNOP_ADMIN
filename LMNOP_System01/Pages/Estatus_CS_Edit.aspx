<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Estatus_CS_Edit.aspx.cs" Inherits="LMNOP_System01.Pages.Estatus_CS_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
   <div class="container box">

        <div class="field">
            <label class="label">Número de maquila</label>
            <div class="control">
                <asp:TextBox runat="server" id="txtmaquila" class="input" type="text" placeholder="Ingrese el número de maquila"></asp:TextBox>
            </div>
        </div>

        <div class="field">
             <label class="label">Estatus de maquila</label>
            <div class="control">
                <asp:TextBox runat="server" id="txtestatus" class="input" type="text" placeholder="Ingrese el estatus de la maquila"></asp:TextBox>
            </div>
        </div>

        <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="btnguardar" CssClass="button is-success is-outlined is-rounded is-medium is-res" Text="Guardar" OnClick="btnguardar_Click"/>
            </div>
        </div>

        <div class="field is-grouped">
            <asp:Label runat="server" ID="lblAlert" Text="."></asp:Label>
        </div>
    </div>
</asp:Content>
