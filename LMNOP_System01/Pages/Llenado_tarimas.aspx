<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Llenado_tarimas.aspx.cs" Inherits="LMNOP_System01.Pages.Llenado_tarimas" %>
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
  <label class="label">
            Número de maquila</label>

  <div class="control">
    <asp:TextBox runat="server" id="num_maquila" class="input" type="text" placeholder="Ingrese el número de la maquila"></asp:TextBox>
  </div>
</div>
                                            <div class="field">
  <label class="label">
            Número de tarima</label>

  <div class="control">
    <asp:TextBox runat="server" id="num_tarima" class="input" type="text" placeholder="Ingrese el número de la tarima de ésta manera: #1"></asp:TextBox>
  </div>
</div>

                          <div class="field">
  <label class="label">
            Número de piezas</label>

  <div class="control">
    <asp:TextBox runat="server" id="num_piezas" class="input" type="text" placeholder="Ingrese el número de piezas de la tarima"></asp:TextBox>
  </div>
</div>
                                   <div class="field">
  <label class="label">
            Kilogramos</label>

  <div class="control">
    <asp:TextBox runat="server" id="kg" class="input" type="text" placeholder="Ingrese el número de KG de las tarimas"></asp:TextBox>
  </div>
</div>
                  <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="Enviar" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="Enviar_Click" Text="Enviar"/>
            </div>
    </div>

         <div class="table-container">
                   <asp:GridView ID="gdv" runat="server" Height="249px" CssClass="table is-selected">
            </asp:GridView>
           
             </div>

         <div>
             <asp:Button runat="server" ID="back" CssClass="button is-danger is-outlined is-rounded is-medium is-res" OnClick="back_Click" Text="Regresar"/>
         </div>
     </div>

</asp:Content>

