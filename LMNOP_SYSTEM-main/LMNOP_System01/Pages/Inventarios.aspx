<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Inventarios.aspx.cs" Inherits="LMNOP_System01.Pages.Inventarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
        <divn class="container box">
        <div class="field is-grouped">
            <div class="control">
                <div>
                <asp:Button runat="server" ID="cs" CssClass="button is-info is-rounded is-medium is-res" OnClick="cs_Click" Text="Centro de Servicio"/>
                </div>
                <br />
                <div>
                    <asp:Button runat="server" ID="as" CssClass="button is-info is-rounded is-medium is-res" OnClick="as_Click" Text="Atención de Sucursales"/>
                </div>
                <br />
                <div>
                    <asp:Button runat="server" ID="cc" CssClass="button is-info is-rounded is-medium is-res" OnClick="cc_Click" Text="Control de Calidad"/>
                </div>
            </div>
        </div>
    </divn>
</asp:Content>
