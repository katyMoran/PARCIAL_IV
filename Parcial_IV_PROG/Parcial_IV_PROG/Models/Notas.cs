using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial_IV_PROG.Models
{
    public class Notas
    {
        public int Codigo { get; set; }
        public String Nombre { get; set; }
        public String Nombre_Materia  { get; set; }
        public Double N1 { get; set; }
        public Double N2 { get; set; }
        public Double N3 { get; set; }
        public Double promedio { get; set;}
        public String Msj { get; set; }
    }
}