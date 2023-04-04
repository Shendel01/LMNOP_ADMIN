<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="LMNOP_System01.Pages.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
Inicio
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="container box">

        <div class="tile is-parent">
        <article class="tile is-child notification is-warning">
          <p class="title has-text-white">¡BIENVENIDO A LMNOP!</p>
          <p class="subtitle has-text-white">Por favor, si eres alguien ajeno al sistema, aún puedes dar marcha atrás.
              Si eres alguien de la oficina, ¡no olvides tus contraseñas! 

              ¡Disfruta tu navegación por el sistema y suerte en el trabajo!
          </p>
          <figure class="image is-4by3">
            <%--<img src="../Images/lmnop_logo.png" />--%>
   
          </figure>
        </article>
      </div>

 </div>

</asp:Content>
