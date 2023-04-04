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
    public partial class Inv_CSL : System.Web.UI.Page
    {
        List<LlenadoTarimasModel> list = new List<LlenadoTarimasModel>();
        private void Consultar()
        {
            list = getList();
            Load_Data();
        }
        private List<LlenadoTarimasModel> getList()
        {
            List<LlenadoTarimasModel> resLista = new List<LlenadoTarimasModel>();
            //grilla.DataSource = centro.Consultar();
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                var res = entities.Tarimas_CentroServicio.ToList();

                foreach (var item in res)
                {
                    resLista.Add(new LlenadoTarimasModel
                    {

                        Id = item.Id,
                        Num_maquila = Convert.ToInt32(item.Num_maquila),
                        Num_tarima = item.Num_tarima,
                        Num_piezas = Convert.ToInt32(item.Num_piezas),
                        Kg = Convert.ToDouble(item.Kg)


                    });
                }

            }
            return resLista;
        }
        private void Load_Data()
        {
            gdv.DataSource = list;
            gdv.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            Consultar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string numMaquila = txtSearch.Text;
            list = getList().FindAll(p => p.Num_maquila.ToString().StartsWith(numMaquila));

            Load_Data();
        }
    }
}