using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Diagonal
    {
        public static void obtenerDiferenciaAbsoluta()
        {
            Console.Write("Ingresa la longitud de la matriz cuadrada: ");
            int longitudMatriz = Convert.ToInt32(Console.ReadLine());

            List<int> listaColumnas = new List<int>();
            List<List<int>> listaFilas = new List<List<int>>();

            for (int indiceX = 0; indiceX <= longitudMatriz - 1; indiceX++){
                for(int indiceY = 0; indiceY <= longitudMatriz - 1; indiceY++)
                {
                    Console.Write("Ingresa un valor: ");
                    listaColumnas.Add(Convert.ToInt32(Console.ReadLine()));
                }
                listaFilas.Add(listaColumnas);
                listaColumnas = new List<int>();
            }

            Console.WriteLine("La resta de diagonales es: {0}", obtenerDiferenciaDiagonal(listaFilas));
        }

        private static int obtenerDiferenciaDiagonal(List<List<int>> matrizEnteros)
        {
            int sumatoriaDiagonal = 0, sumatoriaDiagonalInversa = 0, indiceDecrementado = matrizEnteros.Count - 1;

            for(int indice = 0; indice <= matrizEnteros.Count() - 1; indice++)
            {
                sumatoriaDiagonal += matrizEnteros[indice][indice];
                sumatoriaDiagonalInversa += matrizEnteros[indice][indiceDecrementado];
                indiceDecrementado--;
            }

            return Math.Abs(sumatoriaDiagonal - sumatoriaDiagonalInversa);
        }
    }
}
