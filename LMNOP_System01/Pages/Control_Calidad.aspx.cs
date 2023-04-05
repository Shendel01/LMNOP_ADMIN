using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMNOP_System01.Pages
{
    public partial class Control_Calidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void liberada_Click(object sender, EventArgs e)
        {
            Response.Redirect("C_Liberada.aspx");
        }

        protected void detenida_Click(object sender, EventArgs e)
        {
            Response.Redirect("CD.aspx");
        }
    }
}