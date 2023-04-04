    <%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Centro_servicio.aspx.cs" Inherits="LMNOP_System01.Pages.Centro_servicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Centro de servicio
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

    <div class="container box">
              <div class="field">
            <div class="columns">
                <div class="column">
                    <div class="control has-icons-left">
                        <asp:TextBox runat="server" id="txtSearch" class="input" type="text" placeholder="Buscar por numero de OFE"></asp:TextBox>
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
            Número de OFE</label>

  <div class="control">
    <asp:TextBox runat="server" id="num_of" class="input" type="text" placeholder="Ingrese el número de OF"></asp:TextBox>
  </div>
</div>

               <div class="field">
  <label class="label">Código de primera</label>
  <div class="control">
    <asp:TextBox runat="server" id="codigo_primera" class="input" type="text" placeholder="Ingrese el código de primera"></asp:TextBox>
  </div>
</div>

               <div class="field">
  <label class="label">Descripción</label>
  <div class="control">
    <asp:TextBox runat="server" id="descripcion" class="input" type="text" placeholder="Ingrese descripción"></asp:TextBox>
  </div>
</div>

             
                       <div class="field">
  <label class="label">Operadores</label>
  <div class="control">
    <asp:TextBox runat="server" id="operadores" class="input" type="text" placeholder="Ingrese los Operadores"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Turno</label>
  <div class="control">
    <asp:TextBox runat="server" id="turno" class="input" type="text" placeholder="Ingrese el turno"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Pedacería</label>
  <div class="control">
    <asp:TextBox runat="server" id="pedaceria" class="input" type="text" placeholder="Ingrese la pedacería"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Faltante</label>
  <div class="control">
    <asp:TextBox runat="server" id="faltante" class="input" type="text" placeholder="Ingrese el faltante"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Sobrante</label>
  <div class="control">
    <asp:TextBox runat="server" id="sobrante" class="input" type="text" placeholder="Ingrese el sobrante"></asp:TextBox>
  </div>
</div>
                      <%-- <div class="field">
  <label class="label">Rechazo</label>
  <div class="control">
    <asp:TextBox runat="server" id="rechazo" class="input" type="text" placeholder="Ingrese el rechazo"></asp:TextBox>
  </div>
</div>--%>
                       <div class="field">
  <label class="label">Observaciones</label>
  <div class="control">
    <asp:TextBox runat="server" id="observaciones" class="input" type="text" placeholder="Ingrese las Observaciones"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Total</label>
  <div class="control">
    <asp:TextBox runat="server" id="total" class="input" type="text" placeholder="Total"></asp:TextBox>
  </div>
</div>
         <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="Enviar" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="Enviar_Click" Text="Enviar"/>
            </div>
    </div>
            <div class="table-container">
                   <asp:GridView ID="grilla" runat="server" Height="249px" CssClass="table is-selected">
            </asp:GridView>
             </div>

        <div>
                 <div>
            <%-- <asp:Button runat="server" ID="tarimas" CssClass="button is-info is-rounded is-medium is-res" OnClick="tarimas_Click" Text="Tarimas"/>
             <asp:Button runat="server" ID="segundas" CssClass="button is-info is-rounded is-medium is-res" OnClick="segundas_Click" Text="Segundas"/>--%>
             <asp:Button runat="server" ID="back" CssClass="button is-danger is-outlined is-rounded is-medium is-res" OnClick="back_Click" Text="Regresar"/>
                     </div>
            </div>
    </div>

</asp:Content>
