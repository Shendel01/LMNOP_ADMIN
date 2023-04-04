using LMNOP_System01.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMNOP_System01.Pages
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AppendHeader("Cache-Control", "no-store");
        }

        const string CLAVE = "LMNOP";

        //void Limpiar()
        //{
        //    nombre.Text = string.Empty;
        //    edad.Text = string.Empty;
        //    usuario.Text = string.Empty;
        //    clave.Text = string.Empty;
        //}


        protected void Registrar_Click(object sender, EventArgs e)
        {
            try
            {

                using (var context = new LMNOP_SystemEntities())
                {

                    context.sp_registrar(nombre.Text, Int32.Parse(edad.Text), usuario.Text, CLAVE, 8, clave.Text);

                    Response.Redirect("Login.aspx");

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}