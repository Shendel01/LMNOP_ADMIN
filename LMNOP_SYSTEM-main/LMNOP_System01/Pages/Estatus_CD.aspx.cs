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
    public partial class Estatus_CD : System.Web.UI.Page
    {
        private void Consultar()
        {
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                var res = entities.Calidad_Detenido.ToList();
                List<Estatus_CDModel> list = new List<Estatus_CDModel>();

                foreach (var item in res)
                {
                    list.Add(new Estatus_CDModel
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
                        Hora = item.Hora /*(TimeSpan)item.Hora*/
                    });

                }
                gridview.DataSource = list;
                gridview.DataBind();

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Consultar();
        }
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Control_Calidad.aspx");
        }

        protected void estatus_Click(object sender, EventArgs e)
        {

        }
    }
}
