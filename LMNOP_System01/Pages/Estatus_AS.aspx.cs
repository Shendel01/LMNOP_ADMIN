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
    public partial class prueba : System.Web.UI.Page
    {
        List<EstatusModel> list = new List<EstatusModel>();
        private void Consultar()
        {
            list = getList();
            Load_Data();
        }
        private List<EstatusModel> getList()
        {
            List<EstatusModel> resLista = new List<EstatusModel>();

            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                var res = entities.Estatus01_CentroServicio.ToList();
                

                foreach (var item in res)
                {
                    resLista.Add(new EstatusModel
                    {
                        Id = Convert.ToInt32(item.Id),
                        Maquila = Convert.ToInt32(item.Maquila),
                        Estatus = item.Estatus
                    });
                }
                
            }
            return resLista;
        }

        private void Load_Data()
        {
            gridview.DataSource = list;
            gridview.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Consultar();
        }


        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Atencion_sucursales.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            string maquila = txtSearch.Text;
            list = getList().FindAll(p => p.Maquila.ToString().StartsWith(maquila));

            Load_Data();
        }
    }
}