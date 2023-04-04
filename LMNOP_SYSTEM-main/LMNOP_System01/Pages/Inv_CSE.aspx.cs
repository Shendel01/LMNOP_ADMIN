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
    public partial class Inv_CSE : System.Web.UI.Page
    {
        private void Consultar()
        {
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                var res = entities.Estatus01_CentroServicio.ToList();
                List<EstatusModel> list = new List<EstatusModel>();

                foreach (var item in res)
                {
                    list.Add(new EstatusModel
                    {
                        Id = Convert.ToInt32(item.Id),
                        Maquila = Convert.ToInt32(item.Maquila),
                        Estatus = item.Estatus
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
    }
}