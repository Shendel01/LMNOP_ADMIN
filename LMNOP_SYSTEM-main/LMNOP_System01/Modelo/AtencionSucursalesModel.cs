using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMNOP_System01.Modelo
{
    public class AtencionSucursalesModel
    {
        public int Id_AtencionSucursales { get; set; }
        public int Num_maquila { get; set; }
        public string Documento { get; set; }
        public int Division { get; set; }
        public String Fecha { get; set; }
        public String Hora { get; set; }
    }
}