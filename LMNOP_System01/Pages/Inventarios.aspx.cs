using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMNOP_System01.Pages
{
    public partial class Inventarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cs_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inv_CS.aspx");
        }

        protected void as_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inv_AS.aspx");
        }

        protected void cc_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inv_CC.aspx");
        }
    }
}