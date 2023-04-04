using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMNOP_System01.Modelo
{
    public class Estatus_CLModel
    {
        public int Id { get; set; }
        public string Estatus { get; set; }
        public string Nombre_libera { get; set; }
        public int Num_maquila { get; set; }
        public String Fecha { get; set; }
        public String Hora { get; set; }
    }
}