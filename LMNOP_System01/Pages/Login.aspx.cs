using LMNOP_System01.Context;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMNOP_System01.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            Response.AppendHeader("Cache-Control", "no-store");
        }

        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMNOP_SystemEntities"].ToString());

        const string CLAVE = "LMNOP";

        protected void ingresar_Click(object sender, EventArgs e)
        {

            try
            {
                sp_login_Result result = null;
                using (var context = new LMNOP_SystemEntities()/*LMNOP_SystemEntities2()*/)
                {
                    result = context.sp_login(usuario.Text, CLAVE, clave.Text).ToList().First();


                    if (result != null)
                    {
                        //Response.Redirect("Index.aspx");
                        if (result.Id_rol == 1)
                        {
                            Response.Redirect("Atencion_sucursales.aspx");
                        }

                        if (result.Id_rol == 7)
                        {
                            Response.Redirect("Centro_servicio.aspx");
                        }

                        if (result.Id_rol == 8)
                        {
                            Response.Redirect("Control_calidad.aspx");
                        }

                        if (result.Id_rol == 9)
                        {
                            Response.Redirect("Inventarios.aspx");
                        }
                    }
                    else
                    {
                        //Agregar alerta
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert",
                            "swal('¡Oh no!', 'Usuario o contraseña incorrectos', 'warning')", true);
                        //ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", 
                        //    "swal('¡Oh no!', 'Contraseña o usuario no válido', 'warning')",true);
                    }
                }
            }
            catch (Exception ex)
            {

                 throw ex;
            }
            
        }
    }
}