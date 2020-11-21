using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_CONSOLA
{
    class Program
    {

        static void Main(string[] args)
        {
            Delegado del = new Delegado();
            Console.WriteLine("BIENVENIDOS A LA SUPER TIENDA INCREIBLE");
            Console.WriteLine("Digame,¿Cuanto es el total de la compra?");
            Double Total = Double.Parse(Console.ReadLine());
            Double Desc = 0.00;
            String Desc2 =""+0.00;
            if(Total>=10000 && Total <= 20000)
            {
                Desc2 = ""+0.10;
                Desc = Total * 0.10;  
            }
            else if (Total>=20001 && Total<=50000)
            {
                Desc2 =""+0.30;
                Desc = Total * 0.30;
            }
            else if(Total> 50000)
            {
                Desc2 =""+0.50;
                Desc = Total * 0.50;
            }
            else
            {
                Desc2 ="No posee descuento";
                Desc = Total * 0.00;
            }
            double Proceso = Total - Desc;
            var PagoFinal = Delegado.opero(Proceso,(x)=> { return x; });
            Console.WriteLine(" Su compra final es: "+PagoFinal+"\n Descuento: "+Desc2);
            Console.ReadKey();
        }
    }
}
