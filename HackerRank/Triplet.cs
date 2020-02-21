using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Triplet
    {   
        private static List<int> puntajeTriplet(List<int> valoresAlice, List<int> valoresBob)
        {
            int puntajeAlice = 0;
            int puntajeBob = 0;

            for(int indice = 0; indice < valoresAlice.Count(); indice++)
            {
                if (valoresAlice[indice] > valoresBob[indice])
                    puntajeAlice++;
                else if(valoresBob[indice] > valoresAlice[indice])
                    puntajeBob++;
            }

            int[] puntajes = new int[2]{ puntajeAlice, puntajeBob };

            return puntajes.ToList();
        }

        public static void obtenerValores()
        {
            Console.Write("Ingresa tres valores para Alice (separado por \",\"): ");
            List<int> valoresAlice = Console.ReadLine().Split(',').Select(Int32.Parse).ToList();

            Console.Write("Ingrese tres valores para Bob (separado por \",\"): ");
            List<int> valoresBob = Console.ReadLine().Split(',').Select(Int32.Parse).ToList();

            if(valoresAlice.Count() != valoresBob.Count())
            {
                Console.WriteLine("Alice y Bob deben tener la misma cantidad de valores");
                return;
            }

            List<int> resultado = puntajeTriplet(valoresAlice, valoresBob);
            
            Console.WriteLine("Puntaje de Alice: {0}", resultado[0]);
            Console.WriteLine("Puntaje de Bob: {0}", resultado[1]);
        }
    }
}
