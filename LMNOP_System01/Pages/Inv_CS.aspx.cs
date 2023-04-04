using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMNOP_System01.Pages
{
    public partial class Inv_CS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void estatus_cs_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inv_CSE.aspx");
        }

        protected void llenado_tarimas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inv_CSL.aspx");
        }

        protected void segundas_cs_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inv_CSS.aspx");
        }

        protected void centro_servicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inv_CSC.aspx");
        }
    }
}