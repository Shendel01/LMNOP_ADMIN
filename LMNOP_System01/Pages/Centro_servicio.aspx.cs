using LMNOP_System01.Conexion;
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
    public partial class Centro_servicio : System.Web.UI.Page
    {
        List<CentroServicioModel> list = new List<CentroServicioModel>();
        private void Consultar()
        {
            list = getList();
            Load_Data();
        }
        private List<CentroServicioModel> getList()
        {
            List<CentroServicioModel> resLista = new List<CentroServicioModel>();
            //grilla.DataSource = centro.Consultar();
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities()) {

                var res = entities.Centro_servicio.ToList();

                foreach(var item in res)
                {
                    resLista.Add(new CentroServicioModel
                    {
                        Num_OFE = item.Num_OFE,
                        Codigo_primera = item.Codigo_primera,
                        Descripcion = item.Descripcion,
                        Operadores = item.Operadores,
                        Turno = item.Turno,
                        Pedaceria = item.Pedaceria,
                        Faltante = item.Faltante,
                        Sobrante = item.Sobrante,
                        //Rechazo = item.Rechazo,
                        Observaciones = item.Observaciones,
                        Total = Convert.ToDouble(item.Total)
                    });
                }

               
            }
            return resLista;
        }
        private void Load_Data()
        {
            grilla.DataSource = list;
            grilla.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                entities.Centro_servicio.Add(new LMNOP_System01.Context.Centro_servicio //En donde dice ADD puedes agregar los métodos como PUT 
                {
                    Num_OFE = int.Parse(num_of.Text),
                    Codigo_primera = codigo_primera.Text,
                    Descripcion = descripcion.Text,
                    Operadores = operadores.Text,
                    Turno = turno.Text,
                    Pedaceria = pedaceria.Text,
                    Faltante = faltante.Text,
                    Sobrante = sobrante.Text,
                    //Rechazo = rechazo.Text,
                    Observaciones = observaciones.Text,
                    Total = Convert.ToDecimal(total.Text)
                });
                entities.SaveChanges();
            };
            Consultar();

        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estatus_CS.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string numOFE = txtSearch.Text;
            list = getList().FindAll(p => p.Num_OFE.ToString().StartsWith(numOFE));

            Load_Data();
        }
    }
}