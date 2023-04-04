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
    public partial class C_Detenida : System.Web.UI.Page
    {
        private void Consultar()
        {
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                var res = entities.Calidad_Detenido.ToList();
                List<CalidadDetenidoModel> list = new List<CalidadDetenidoModel>();

                foreach (var item in res)
                {
                    list.Add(new CalidadDetenidoModel
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
                    Hora = DateTime.Now.ToString("HH:mm:ss")
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
    }
}