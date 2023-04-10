using LMNOP_System01.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMNOP_System01.Pages
{
    public partial class CD_Edit : System.Web.UI.Page
    {
        private int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            int.TryParse(Request["ID"], out id);
            lblAlert.Text = "";
            if (!Page.IsPostBack)
            {

                getCaldiadStatus();
            }
        }

        private void getCaldiadStatus()
        {
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                var res = entities.Calidad_Detenido.FirstOrDefault(e => e.Id.Equals(this.id));
                if (res != null)
                {
                    num_maquila.Text = res.Num_maquila.ToString();
                    tipo_defecto.Text = res.Tipo_defecto;
                    defecto.Text = res.Defecto;
                    seguimiento.Text = res.Seguimiento;
                    codigo_segundas.Text = ((int?)res.Codigo_segundas).ToString();
                    comentario.Text = res.Comentario;
                    nombre_detenido.Text = res.Nombre_detenido;
                    reproceso.Text = res.Reproceso;
                    estatusmaquila.Text = res.Estatus;

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
                    var res = entities.Calidad_Detenido.FirstOrDefault(p => p.Id.Equals(this.id));
                    if (res != null)
                    {
                        res.Num_maquila = int.Parse(num_maquila.Text);
                        res.Tipo_defecto = tipo_defecto.Text;
                        res.Defecto = defecto.Text;
                        res.Seguimiento = seguimiento.Text;
                        res.Codigo_segundas = int.Parse(codigo_segundas.Text);
                        res.Comentario = comentario.Text;
                        res.Nombre_detenido = nombre_detenido.Text;
                        res.Reproceso = reproceso.Text;
                        res.Estatus = estatusmaquila.Text;
                    }
                    entities.SaveChanges();
                }
                Response.Redirect("CD.aspx");
            }
            catch
            {
                lblAlert.Text = "Error al intentar guardar el registro. Contacte con un administrador.";
            }
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CD.aspx");
        }
    }
}