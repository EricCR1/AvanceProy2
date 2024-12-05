using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_De_Ordenamiento.Clases
{
    class MezclaDirecta
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public int[] Ordenar(int[] arreglo)
        {
            Pasos.Clear(); // Limpiar pasos previos

            int n = arreglo.Length;
            int[] auxiliar = new int[n];

            for (int tamaño = 1; tamaño < n; tamaño *= 2)
            {
                for (int izquierda = 0; izquierda < n; izquierda += 2 * tamaño)
                {
                    int medio = Math.Min(izquierda + tamaño, n);
                    int derecha = Math.Min(izquierda + 2 * tamaño, n);

                    Intercalar(arreglo, auxiliar, izquierda, medio, derecha);
                }

                // Registrar el estado del arreglo en cada iteración
                Pasos.Add($"Con grupos de: {tamaño}: {string.Join(", ", arreglo)}");
            }

            return arreglo;
        }

        private void Intercalar(int[] arreglo, int[] auxiliar, int izquierda, int medio, int derecha)
        {
            int i = izquierda, j = medio, k = izquierda;

            // Intercalar los dos subarreglos
            while (i < medio && j < derecha)
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

            // Copiar los elementos restantes del primer subarreglo
            while (i < medio)
            {
                auxiliar[k++] = arreglo[i++];
            }

            // Copiar los elementos restantes del segundo subarreglo
            while (j < derecha)
            {
                auxiliar[k++] = arreglo[j++];
            }

            // Copiar el auxiliar de vuelta al arreglo original
            for (i = izquierda; i < derecha; i++)
            {
                arreglo[i] = auxiliar[i];
            }
        }
    }
}
