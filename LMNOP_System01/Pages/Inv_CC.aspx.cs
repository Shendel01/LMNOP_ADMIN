using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMNOP_System01.Pages
{
    public partial class Inv_CC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void liberada_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estatus_CL.aspx");
        }

        protected void detenida_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estatus_CD.aspx");
        }
    }
}