using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    class Exponencial
    {
        public static int CalcularExponente(int baseNum, int exponente)
        {
            if (exponente == 0)
                return 1; // Caso base: cualquier número elevado a 0 es 1
            return baseNum * CalcularExponente(baseNum, exponente - 1);
        }
    }
}
