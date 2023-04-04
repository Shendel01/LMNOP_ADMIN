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
    public partial class Estatus_CL : System.Web.UI.Page
    {
        private void Consultar()
        {

            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                var res = entities.Calidad_Liberacion.ToList();
                List<Estatus_CLModel> list = new List<Estatus_CLModel>();

                foreach (var item in res)
                {
                    list.Add(new Estatus_CLModel
                    {
                        Id = Convert.ToInt32(item.Id),
                        Estatus = item.Estatus,
                        Nombre_libera = item.Nombre_libera,
                        Num_maquila = Convert.ToInt32(item.Num_maquila),
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
        protected void estatus_Click(object sender, EventArgs e)
        {

        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Control_Calidad.aspx");
        }
    }
}