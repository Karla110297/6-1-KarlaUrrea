using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_KarlaUrrea
{
    class BusquedaSecuencial
    {
        public  BusquedaSecuencial() { }

        public void imprimirEjemplo1()
        {
            List<int> Lista = new List<int>();//Lista de elementos

            Lista.Add(78);
            Lista.Add(35);
            Lista.Add(243);
            Lista.Add(2);
            Lista.Add(65);
            Lista.Add(4);
            Lista.Add(243);
            Lista.Add(12);
            Lista.Add(1);
            
            int Elemento = 20;//elemento que se va a buscar
            string respuesta;//resultado del bool conforme a la función
            if (Ejemplo1(Elemento, Lista))//manda llamar a la funcion para dar una respuesta conforme al resultado 
            {
                respuesta = "Sí";//Si regresa true se respondera Sí
            }
            else
            {
                respuesta = "No";//Si regresa false se respondera No
            }

            Console.WriteLine("BUSQUEDA SECUENCIAL");
            Console.WriteLine();
            Console.WriteLine("El elemento " + Elemento);
            Console.WriteLine("¿se encuentra en la lista? " + respuesta);
            Console.ReadKey();
        }

        public void imprimirEjemplo2()
        {
            //Arreglo ordenado
            int[] arreglo = new int[10]
            {
                1, 2, 4, 11, 20, 28, 48, 84, 96, 106
            };

            int indice = Ejemplo2(arreglo, 20);//manda llamar a la funcion para que identifique en que indice se encuentra el elemento
            Console.WriteLine("El valor del indice del numero 20 en el arreglo es: " + indice.ToString());
            
        }

        public bool Ejemplo1(int Elemento, List<int> Lista)//pide elemento y lista a recorrer
        {
            int Tamaño = Lista.Count;//tamaño de la lista
            int Posicion = 0;//posicion de recorrido

            while (Posicion < Tamaño)
            {
                if (Lista[Posicion] == Elemento)//si lugar en donde se encuentra del recorrido tiene el mismo elemento que el que se mando regresa true
                {
                    return true;
                }
                else
                {
                    Posicion++;//de lo contrario continua su camino
                }
            }
            return false;//si acaba el while sin haber encontrado el elemento regresa un false
        }

        private int Ejemplo2(int[] arreglo, int buscarNumero)//se pide arreglo y numero que se va a buscat
        {
            arreglo[arreglo.Length - 1] = buscarNumero;

            int i;
            for (i = 0; arreglo[i] != buscarNumero; i++) ;
            return (i < arreglo.Length - 1) ? i : -1;// se regresa el numero que corresponde al indice del elemento que se busco
        }








    }
}
