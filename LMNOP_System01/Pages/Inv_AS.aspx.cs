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
    public partial class Inv_AS : System.Web.UI.Page
    {
        List<AtencionSucursalesModel> list = new List<AtencionSucursalesModel>();
        private void Consultar()
        {
            list = getList();
            Load_Data();
        }
        private List<AtencionSucursalesModel> getList()
        {
            List<AtencionSucursalesModel> resLista = new List<AtencionSucursalesModel>();

            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                var res = entities.Atencion_Sucursales.ToList();
                

                foreach (var item in res)
                {
                    resLista.Add(new AtencionSucursalesModel
                    {
                        Id_AtencionSucursales = Convert.ToInt32(item.Id_AtencionSucursales),
                        Num_maquila = Convert.ToInt32(item.Num_maquila),
                        Documento = item.Documento,
                        Division = Convert.ToInt32(item.Division),
                        Fecha = Convert.ToDateTime(item.Fecha).ToLongDateString(),
                        Hora = item.Hora /*(TimeSpan)item.Hora*/
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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string numMaquila = txtSearch.Text;
            list = getList().FindAll(p => p.Num_maquila.ToString().StartsWith(numMaquila));

            Load_Data();
        }
    }
}