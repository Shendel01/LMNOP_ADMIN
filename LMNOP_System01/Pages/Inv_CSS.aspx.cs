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
        List<Segundas_CSModel> list = new List<Segundas_CSModel>();
        private void Consultar()
        {
            list = getList();
            Load_Data();
        }
        private List<Segundas_CSModel> getList()
        {
            List<Segundas_CSModel> resLista = new List<Segundas_CSModel>();

            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                var res = entities.Segundas_CentroServicio.ToList();
               

                foreach (var item in res)
                {
                    resLista.Add(new Segundas_CSModel
                    {
                        Id = item.Id,
                        Num_segundas = Convert.ToInt32(item.Num_segundas),
                        Num_piezas = Convert.ToInt32(item.Num_piezas),
                        Kg = Convert.ToDouble(item.Kg)
                    });
                }

            }
            return resLista;
        }
        private void Load_Data()
        {
            tabla.DataSource = list;
            tabla.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string numsegundas = txtSearch.Text;
            list = getList().FindAll(p => p.Num_segundas.ToString().StartsWith(numsegundas));

            Load_Data();
        }
    }
}