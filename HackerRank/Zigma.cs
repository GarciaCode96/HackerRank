using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Zigma
    {
        public static long sumatoriaValoresGrandes(long[] valores)
        {
            long resultadoSumatoria = 0;
            foreach(long valorActual in valores)
            {
                resultadoSumatoria = resultadoSumatoria + valorActual;
            }

            return resultadoSumatoria;
        }
    }
}
