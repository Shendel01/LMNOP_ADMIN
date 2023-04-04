<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="C_Liberada.aspx.cs" Inherits="LMNOP_System01.Pages.C_Liberada" %>
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
        
        <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="estatus" CssClass="button is-success is-rounded is-medium is-res" title="No puedes editar este campo" disabled OnClick="estatus_Click" Text="Maquila liberada"/>
            </div>
        </div>
        
              <div class="field">
             <label class="label">
            Número de la maquila</label>
  <div class="control">
    <asp:TextBox runat="server" id="num_maquila" class="input" type="text" placeholder="Maquila"></asp:TextBox>
  </div>
        </div>

              <div class="field">
             <label class="label">
            Nombre de la persona que libera</label>
  <div class="control">
    <asp:TextBox runat="server" id="libera" class="input" type="text" placeholder="Ingrese el nombre de la persona que libera la maquila"></asp:TextBox>
  </div>
        </div>

        <div class="field">
             <label class="label">
            Comentario</label>
  <div class="control">
    <asp:TextBox runat="server" id="maquila" class="input" type="text" placeholder="Ingrese algún comentario o descripción de la maquila"></asp:TextBox>
  </div>
        </div>

      

         <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="Enviar" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="Enviar_Click" Text="Enviar"/>
            </div>
        </div>




         
         <div class="table-container">
                   <asp:GridView ID="gridview" runat="server" Height="249px" CssClass="table is-selected">
            </asp:GridView>
           
             </div>


           <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="regresar" CssClass="button is-danger is-outlined is-rounded is-medium is-res" OnClick="regresar_Click" Text="Regresar"/>
            </div>
        </div>

    </div>

</asp:Content>
