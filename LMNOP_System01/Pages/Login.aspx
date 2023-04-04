<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LMNOP_System01.Pages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Iniciando
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

    <div class="container box">
        <h1 class="title">
            Iniciar sesión
        </h1>

        <div class="field"> 
             <label class="label">Usuario</label>
            <div class="control">
                <asp:TextBox runat="server" id="usuario" class="input" type="text" placeholder="ej. Shendel"></asp:TextBox>
            </div>
            <p class="help is-danger">Agrega tu usuario</p>
        </div>

        <div class="field"> 
             <label class="label">Password</label>
            <div class="control">
                <asp:TextBox runat="server" id="clave" class="input"  TextMode="Password" EnableViewState="True" placeholder="*****"></asp:TextBox>
            </div>
        </div>

        <%--Validaciones comienzo--%>

      <%--  <asp:RequiredFieldValidator ID="valclave" runat="server"
            ControlToValidate="clave" EnableClientScript="true" Display="None"
            ErrorMessage="no"></asp:RequiredFieldValidator>--%>

         <%--Validaciones final--%>

        <asp:Button runat="server" id="ingresar" class="button is-success is-outlined is-rounded is-responsive" text="Ingresar" OnClick="ingresar_Click"/>
        <br />
        <div class="control">
            <br />
                <a class="button is-primary is-light is-rounded is-responsive" href="Index.aspx">Cancelar</a>
            </div>
    </div>
</asp:Content>