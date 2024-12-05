using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_De_Ordenamiento.Clases
{
    class MezclaNatural
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public int[] Ordenar(int[] arreglo)
        {
            Pasos.Clear(); // Limpiar los pasos previos
            int n = arreglo.Length;

            // Búfer auxiliar para intercalaciones
            int[] auxiliar = new int[n];

            while (true)
            {
                List<int> inicioSubarreglos = new List<int>();

                // Identificar los límites de las secuencias ordenadas naturales
                for (int i = 0; i < n - 1; i++)
                {
                    if (arreglo[i] > arreglo[i + 1])
                    {
                        inicioSubarreglos.Add(i + 1);
                    }
                }
                inicioSubarreglos.Add(n); // Final del último subarreglo

                // Si solo hay un subarreglo, el arreglo está completamente ordenado
                if (inicioSubarreglos.Count == 1)
                    break;

                // Mezclar pares de subarreglos naturales
                for (int i = 0; i < inicioSubarreglos.Count - 1; i += 2)
                {
                    int inicio1 = (i == 0) ? 0 : inicioSubarreglos[i - 1];
                    int final1 = inicioSubarreglos[i];
                    int final2 = inicioSubarreglos[i + 1];

                    Intercalar(arreglo, auxiliar, inicio1, final1, final2);
                }

                // Registrar el estado actual del arreglo
                Pasos.Add($"Después de una iteración: {string.Join(", ", arreglo)}");
            }

            return arreglo;
        }

        private void Intercalar(int[] arreglo, int[] auxiliar, int inicio, int medio, int fin)
        {
            int i = inicio, j = medio, k = inicio;

            // Intercalar los dos subarreglos
            while (i < medio && j < fin)
            {
                if (arreglo[i] <= arreglo[j])
                {
                    auxiliar[k++] = arreglo[i++];
                }
                else
                {
                    auxiliar[k++] = arreglo[j++];
                }
            }

            // Copiar elementos restantes del primer subarreglo
            while (i < medio)
            {
                auxiliar[k++] = arreglo[i++];
            }

            // Copiar elementos restantes del segundo subarreglo
            while (j < fin)
            {
                auxiliar[k++] = arreglo[j++];
            }

            // Copiar los elementos intercalados al arreglo original
            for (i = inicio; i < fin; i++)
            {
                arreglo[i] = auxiliar[i];
            }
        }
    }
}
