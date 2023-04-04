using LMNOP_System01.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMNOP_System01.Pages
{
    public partial class Estatus_CS_Edit : System.Web.UI.Page
    {
        private int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            int.TryParse(Request["ID"], out id);
            lblAlert.Text = "";
            if (!Page.IsPostBack)
            {
                getCentroServicoStatus();
            }
        }

        private void getCentroServicoStatus()
        {
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                var res = entities.Estatus01_CentroServicio.FirstOrDefault(e => e.Id.Equals(this.id));
                if (res != null)
                {
                    txtmaquila.Text = res.Maquila.ToString();
                    txtestatus.Text = res.Estatus;
                }
            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            lblAlert.Text = "";
            try
            {
                using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
                {
                    var res = entities.Estatus01_CentroServicio.FirstOrDefault(p => p.Id.Equals(this.id));
                    if (res != null)
                    {
                        res.Maquila = int.Parse(txtmaquila.Text);
                        res.Estatus = txtestatus.Text;
                    }
                    entities.SaveChanges();
                }
                Response.Redirect("Estatus_CS.aspx");
            }
            catch
            {
                lblAlert.Text = "Error al intentar guardar el registro. Contacte con un administrador.";
            }
        }
    }
}