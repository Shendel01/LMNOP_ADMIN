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
    public partial class Inv_CSS : System.Web.UI.Page
    {
        private void Consultar()
        {
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                var res = entities.Segundas_CentroServicio.ToList();
                List<Segundas_CSModel> list = new List<Segundas_CSModel>();

                foreach (var item in res)
                {
                    list.Add(new Segundas_CSModel
                    {
                        Id = item.Id,
                        Num_segundas = Convert.ToInt32(item.Num_segundas),
                        Num_piezas = Convert.ToInt32(item.Num_piezas),
                        Kg = Convert.ToDouble(item.Kg)
                    });
                }
                tabla.DataSource = list;
                tabla.DataBind();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Consultar();
        }

    }
}