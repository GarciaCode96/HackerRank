using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Promedio
    {
        /*
         *  Se debe hacer el primer ejercicio de hacker rank que consiste en obtener una longitud
         *  de un arreglo y se debe hacer la sumatoria y retornalo para mostrarlo en consola.
         */
        public static void mostrarResultado() 
        {
            Console.Write("Ingrese la longitud del arreglo: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La suma del arreglo es: {0}", sumatoriaArreglo(longitud));
        }
        
        private static int sumatoriaArreglo(int longitud)
        {
            int sumatoria = 0;
            int[] valores = new int[longitud];

            for(int indice = 0; indice < longitud; indice++)
            {
                Console.Write("Ingresa un valor: ");
                valores[indice] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int valor in valores){
                sumatoria += valor;
            }

            return sumatoria;
        }
    }
}
