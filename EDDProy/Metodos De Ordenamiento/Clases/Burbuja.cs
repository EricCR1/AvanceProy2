using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_De_Ordenamiento.Clases
{
    class Burbuja
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public int[] Ordenar(int[] arreglo)
        {
            Pasos.Clear(); // Limpiamos los pasos antes de cada ejecución
            int n = arreglo.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        // Intercambiamos
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;

                        // Agregar el estado actual del arreglo a los pasos
                        Pasos.Add($"Paso {Pasos.Count + 1}: {string.Join(", ", arreglo)}");
                    }
                }
            }

            return arreglo;
        }
    }
}
