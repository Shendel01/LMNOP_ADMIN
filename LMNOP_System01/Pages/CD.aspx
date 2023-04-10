<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="CD.aspx.cs" Inherits="LMNOP_System01.Pages.CD" %>
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

                      <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="estatus" CssClass="button is-success is-rounded is-medium is-res" title="No puedes editar este campo" disabled OnClick="estatus_Click" Text="Maquilas"/>
            </div>
        </div>

             <label class="label">
            Número de la maquila</label>
  <div class="control">
    <asp:TextBox runat="server" id="num_maquila" class="input" type="text" placeholder="Maquila"></asp:TextBox>
  </div>
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
                <asp:Button runat="server" ID="Enviar" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="Enviar_Click" Text="Enviar"/>
            </div>
        </div>

 <div class="table-container">
                  <asp:GridView ID="gridview" runat="server" Height="249px" CssClass="table is-selected">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <a href="CD_Edit.aspx?ID=<%# DataBinder.Eval(Container.DataItem, "id") %>">
                                     EDITAR
                                </a>
                         <%--   <span class="icon is-small is-left">
                                <a href="CD_Edit.aspx?ID=<%# DataBinder.Eval(Container.DataItem, "id") %>">
                                    <i class="fa-solid fa-pen-to-square"></i> EDITAR
                                </a>
                            </span>--%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                      </asp:GridView>
             </div>

        <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="regresar" CssClass="button is-danger is-outlined is-rounded is-medium is-res" OnClick="regresar_Click" Text="Regresar"/>
            </div>
        </div>
    </div>
</asp:Content>
