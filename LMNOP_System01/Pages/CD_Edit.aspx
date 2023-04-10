<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="CD_Edit.aspx.cs" Inherits="LMNOP_System01.Pages.CD_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

    <div class="container box">
              <label class="label">
            Número de la maquila</label>
  <div class="control">
    <asp:TextBox runat="server" id="num_maquila" class="input" type="text" placeholder="Maquila"></asp:TextBox>
  </div>
        <div class="field">
  <label class="label">
            Tipo de defecto</label>

  <div class="control">
    <asp:TextBox runat="server" id="tipo_defecto" class="input" type="text" placeholder="Apariencia, dimensión, identificación o embalaje"></asp:TextBox>
  </div>
</div>


              <div class="field">
  <label class="label">
            Descripción del defecto</label>

  <div class="control">
    <asp:TextBox runat="server" id="defecto" class="input" type="text" placeholder="Ingrese una breve eplciación del defecto"></asp:TextBox>
  </div>
</div>

               <div class="field">
  <label class="label">
            Seguimiento</label>

  <div class="control">
    <asp:TextBox runat="server" id="seguimiento" class="input" type="text" placeholder="Ingrese el seguimiento"></asp:TextBox>
  </div>
</div>

                       <div class="field">
  <label class="label">
            Código de segundas</label>

  <div class="control">
    <asp:TextBox runat="server" id="codigo_segundas" class="input" type="text" placeholder="Ingrese el seguimiento"></asp:TextBox>
  </div>
</div>


               <div class="field">
  <label class="label">
            Comentario</label>

  <div class="control">
    <asp:TextBox runat="server" id="comentario" class="input" type="text" placeholder="Ingrese el comentario"></asp:TextBox>
  </div>
</div>

               <div class="field">
  <label class="label">
            Nombre de la persona que detiene</label>

  <div class="control">
    <asp:TextBox runat="server" id="nombre_detenido" class="input" type="text" placeholder="Ingrese su nombre"></asp:TextBox>
  </div>
</div>

                       <div class="field">
  <label class="label">
            ¿Requiere reproceso?</label>

  <div class="control">
    <asp:TextBox runat="server" id="reproceso" class="input" type="text" placeholder="Sí, No"></asp:TextBox>
  </div>
</div>

                             <div class="field">
  <label class="label">
            Estatus</label>

  <div class="control">
    <asp:TextBox runat="server" id="estatusmaquila" class="input" type="text" placeholder="Estatus"></asp:TextBox>
  </div>
         
</div>
          <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="btnguardar" CssClass="button is-success is-outlined is-rounded is-medium is-res" Text="Guardar" OnClick="btnguardar_Click"/>
            </div>
        </div>
          <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="Cancelar" CssClass="button is-danger is-outlined is-rounded is-medium is-res" OnClick="Cancelar_Click" Text="Cancelar"/>
            </div>
        </div>

                            <div class="field is-grouped">
            <asp:Label runat="server" ID="lblAlert" Text="."></asp:Label>
        </div>
        </div>
          
</asp:Content>
