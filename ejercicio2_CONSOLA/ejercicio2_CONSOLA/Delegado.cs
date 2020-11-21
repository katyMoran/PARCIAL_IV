using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_CONSOLA
{
    delegate double operacion(double X);
    class Delegado
    {
        public static double opero(double x, operacion delg)
        {
            return x;
        }

    }
}
