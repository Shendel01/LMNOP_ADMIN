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
    public partial class Inv_CSC : System.Web.UI.Page
    {
        private void Consultar()
        {

            //grilla.DataSource = centro.Consultar();
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {

                var res = entities.Centro_servicio.ToList();

                List<CentroServicioModel> list = new List<CentroServicioModel>();

                foreach (var item in res)
                {
                    list.Add(new CentroServicioModel
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

                grilla.DataSource = list;
                grilla.DataBind();
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}