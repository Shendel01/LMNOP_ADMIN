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
    public partial class Estatus_CS : System.Web.UI.Page
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
            gridview.RowCreated += new GridViewRowEventHandler(gridView_RowCreated);
            gridview.DataBind();
        }
        void gridView_RowCreated(object sender, GridViewRowEventArgs e)
        {
            GridViewRow row = e.Row;
            TableCell actionsCell = row.Cells[0];
            row.Cells.Remove(actionsCell);
            row.Cells.Add(actionsCell);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                entities.Estatus01_CentroServicio.Add(new LMNOP_System01.Context.Estatus01_CentroServicio
                {
                    Maquila = int.Parse(maquila.Text),
                    Estatus = estatus.Text
                });
                entities.SaveChanges();
            };
            Consultar();
        }

        protected void tarimas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Llenado_tarimas.aspx");
        }

        protected void segundas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Segundas_CS.aspx");
        }

        protected void ofe_Click(object sender, EventArgs e)
        {
            Response.Redirect("Centro_servicio.aspx");
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void maquila_liberada_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estatus_CL.aspx");
        }

        protected void maquila_detenida_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estatus_CD.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string maquila = txtSearch.Text;
            list = getList().FindAll(p => p.Maquila.ToString().StartsWith(maquila));

            Load_Data();
        }
    }
}