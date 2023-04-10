using LMNOP_System01.Context;
using LMNOP_System01.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMNOP_System01.Pages
{
    public partial class CD : System.Web.UI.Page
    {
        List<CalidadDetenidoModel> list = new List<CalidadDetenidoModel>();

        private void Consultar()
        {
            list = getList();
            Load_Data();
        }
        private List<CalidadDetenidoModel> getList()
        {
            List<CalidadDetenidoModel> resLista = new List<CalidadDetenidoModel>();

            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                var res = entities.Calidad_Detenido.ToList();


                foreach (var item in res)
                {
                    resLista.Add(new CalidadDetenidoModel
                    {
                        Id = Convert.ToInt32(item.Id),
                        Comentario = item.Comentario,
                        Defecto = item.Defecto,
                        Nombre_detenido = item.Nombre_detenido,
                        Seguimiento = item.Seguimiento,
                        Num_maquila = Convert.ToInt32(item.Num_maquila),
                        Tipo_defecto = item.Tipo_defecto,
                        Codigo_segundas = Convert.ToDouble(item.Codigo_segundas),
                        Reproceso = item.Reproceso,
                        Fecha = Convert.ToDateTime(item.Fecha).ToLongDateString(),
                        Hora = item.Hora, /*(TimeSpan)item.Hora*/
                        Estatus = item.Estatus
                    });

                }

            }

            return resLista;
        }

        private void Load_Data()
        {
            gridview.DataSource = list;
            gridview.RowCreated += new GridViewRowEventHandler(gridView_RowCreated);
            gridview.DataBind();
        }
        void gridView_RowCreated(object sender, GridViewRowEventArgs e)
        {
            GridViewRow row = e.Row;
            TableCell actionsCell = row.Cells[0];
            row.Cells.Remove(actionsCell);
            row.Cells.Add(actionsCell);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                entities.Calidad_Detenido.Add(new LMNOP_System01.Context.Calidad_Detenido
                {
                    Comentario = comentario.Text,
                    Defecto = defecto.Text,
                    Nombre_detenido = nombre_detenido.Text,
                    Seguimiento = seguimiento.Text,
                    Num_maquila = int.Parse(num_maquila.Text),
                    Tipo_defecto = tipo_defecto.Text,
                    Codigo_segundas = Convert.ToDecimal(codigo_segundas.Text),
                    Reproceso = reproceso.Text,
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.ToString("HH:mm:ss"),
                    Estatus = estatusmaquila.Text
                });
                entities.SaveChanges();
            };
            Consultar();

        }

        protected void estatus_Click(object sender, EventArgs e)
        {

        }

        protected void regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Control_Calidad.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string numMaquila = txtSearch.Text;
            list = getList().FindAll(p => p.Num_maquila.ToString().StartsWith(numMaquila));

            Load_Data();
        }


    }
}