<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Inv_CS.aspx.cs" Inherits="LMNOP_System01.Pages.Inv_CS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
       <divn class="container box">
        <div class="field is-grouped">
            <div class="control">
                <div>
                <asp:Button runat="server" ID="estatus_cs" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="estatus_cs_Click" Text="Estatus"/>
                </div>
                <br />
                <div>
                    <asp:Button runat="server" ID="llenado_tarimas" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="llenado_tarimas_Click" Text="Llenado de tarimas"/>
                </div>
                <br />
                <div>
                    <asp:Button runat="server" ID="segundas_cs" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="segundas_cs_Click" Text="Segundas"/>
                </div>
                 <br />
                <div>
                    <asp:Button runat="server" ID="centro_servicio" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="centro_servicio_Click" Text="Centro de servicio"/>
                </div>
            </div>
        </div>
    </divn>
</asp:Content>
