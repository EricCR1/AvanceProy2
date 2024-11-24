using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    using System;

    namespace EDDemo.Recursividad.Clases
    {
        public static class SumarArreglos
        {
            private static Random random = new Random();

            // Generar un arreglo de números aleatorios usando recursividad
            public static int[] GenerarArreglo(int tamaño, int min = 0, int max = 100, int[] arreglo = null, int index = 0)
            {
                if (arreglo == null)
                {
                    arreglo = new int[tamaño]; // Crear el arreglo inicialmente
                }

                if (index >= tamaño)
                {
                    return arreglo; // Caso base: se completó el arreglo
                }

                arreglo[index] = random.Next(min, max); // Generar número aleatorio
                return GenerarArreglo(tamaño, min, max, arreglo, index + 1); // Llamada recursiva
            }

            // Calcular la suma de un arreglo usando recursividad
            public static int CalcularSuma(int[] arreglo, int index = 0)
            {
                if (index >= arreglo.Length)
                {
                    return 0; // Caso base: alcanzamos el final del arreglo
                }

                return arreglo[index] + CalcularSuma(arreglo, index + 1); // Sumar elemento actual y avanzar
            }
        }
    }

}
