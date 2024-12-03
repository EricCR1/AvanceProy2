using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_De_Ordenamiento.Clases
{
     class Intercalacion
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public int[] Intercalar(int[] arreglo1, int[] arreglo2)
        {
            Pasos.Clear(); // Limpiar pasos previos

            int n1 = arreglo1.Length, n2 = arreglo2.Length;
            int[] resultado = new int[n1 + n2];

            int i = 0, j = 0, k = 0;

            // Intercalar comparando elementos de los dos arreglos
            while (i < n1 && j < n2)
            {
                if (arreglo1[i] <= arreglo2[j])
                {
                    resultado[k++] = arreglo1[i++];
                }
                else
                {
                    resultado[k++] = arreglo2[j++];
                }

                // Registrar el estado actual
                Pasos.Add($"Intercalando: {string.Join(", ", arreglo1)} y {string.Join(", ", arreglo2)} -> {string.Join(", ", resultado)}");
            }

            // Copiar los elementos restantes del arreglo1, si los hay
            while (i < n1)
            {
                resultado[k++] = arreglo1[i++];
                Pasos.Add($"Agregando restante de arreglo1: {string.Join(", ", resultado)}");
            }

            // Copiar los elementos restantes del arreglo2, si los hay
            while (j < n2)
            {
                resultado[k++] = arreglo2[j++];
                Pasos.Add($"Agregando restante de arreglo2: {string.Join(", ", resultado)}");
            }

            return resultado;
        }
    }
}
