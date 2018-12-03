using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_KarlaUrrea
{
    class Program
    {
        static void Main(string[] args)
        {
            BusquedaSecuencial  BS = new BusquedaSecuencial();
            
            BS.imprimirEjemplo1();//Ejemplo 1

            Console.Clear();

            BS.imprimirEjemplo2();//Ejemplo 2
            


            Console.ReadKey();
        }
    }
}
