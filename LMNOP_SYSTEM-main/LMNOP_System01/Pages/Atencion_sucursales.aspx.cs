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
    public partial class Atencion_sucursales : System.Web.UI.Page
    {

        private void Consultar()
        {
           using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                var res = entities.Atencion_Sucursales.ToList();
                List<AtencionSucursalesModel> list = new List<AtencionSucursalesModel>();

                foreach (var item in res)
                {
                    list.Add(new AtencionSucursalesModel
                    {
                        Id_AtencionSucursales = Convert.ToInt32(item.Id_AtencionSucursales),
                        Num_maquila = Convert.ToInt32(item.Num_maquila),
                        Documento = item.Documento,
                        Division = Convert.ToInt32(item.Division),
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

        protected void Enviar_Click(object sender, EventArgs e)
        {
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                entities.Atencion_Sucursales.Add(new LMNOP_System01.Context.Atencion_Sucursales
                {

                    Num_maquila = int.Parse(num_maquila.Text),
                    Documento = documento.Text,
                    Division = int.Parse(division.Text),
                    Fecha = DateTime.Now,
                    Hora = DateTime.Now.ToString("HH:mm:ss")
                });
                entities.SaveChanges();
            };
            Consultar();
        }

        protected void estatus_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estatus_AS.aspx");
        }

        protected void maquila_liberada_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estatus_CL.aspx");
        }

        protected void maquila_detenida_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estatus_CD.aspx");
        }
    }
}