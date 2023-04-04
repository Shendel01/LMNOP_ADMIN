using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LMNOP_System01.Conexion
{
    //Abrir y cerrar conexión
    public class Conexion
    {
        protected SqlConnection cnn;

        protected void Conectar()
        {
            try
            {
                cnn = new SqlConnection("LAPTOP-SA0COJFD\\SQLEXPRESS;initial catalog=LMNOP_System;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;");
                cnn.Open();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }
        }

        protected void Desconectar()
        {
            try
            {
                cnn.Dispose(); //Para limpieza de memora de objeto de conexión
                cnn.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}