using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMNOP_System01.Modelo
{
    public class CalidadDetenidoModel
    {
        public int Id { get; set; }
        public string Defecto { get; set; }
        public string Seguimiento { get; set; }
        public string Comentario { get; set; }
        public string Nombre_detenido { get; set; }
        public int Num_maquila { get; set; }
        public double Codigo_segundas { get; set; }
        public string Tipo_defecto { get; set; }
        public string Reproceso { get; set; }
        public String Fecha { get; set; }
        public String Hora { get; set; }
        public string Estatus { get; set; }

    }
}