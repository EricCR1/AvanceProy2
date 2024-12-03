using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_De_Ordenamiento.Clases
{
    class Radix
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public void Ordenar(int[] arreglo)
        {
            Pasos.Clear(); // Limpiar pasos previos

            int max = ObtenerMaximo(arreglo); // Obtener el valor máximo
            int exp = 1; // Empezar con el dígito menos significativo

            while (max / exp > 0)
            {
                // Ordenar por el dígito actual
                arreglo = ContarPorDigitos(arreglo, exp);

                // Registrar el estado del arreglo en este paso
                Pasos.Add($"Dígito {exp}: {string.Join(", ", arreglo)}");

                exp *= 10; // Mover a la siguiente posición (décenas, centenas, etc.)
            }
        }

        private int ObtenerMaximo(int[] arreglo)
        {
            int max = arreglo[0];
            foreach (int num in arreglo)
            {
                if (num > max) max = num;
            }
            return max;
        }

        private int[] ContarPorDigitos(int[] arreglo, int exp)
        {
            int n = arreglo.Length;
            int[] salida = new int[n];
            int[] conteo = new int[10]; // Dígitos de 0 a 9

            // Contar las ocurrencias de los dígitos en la posición actual
            for (int i = 0; i < n; i++)
            {
                int digito = (arreglo[i] / exp) % 10;
                conteo[digito]++;
            }

            // Ajustar las posiciones de los conteos
            for (int i = 1; i < 10; i++)
            {
                conteo[i] += conteo[i - 1];
            }

            // Construir el arreglo ordenado basado en los dígitos actuales
            for (int i = n - 1; i >= 0; i--)
            {
                int digito = (arreglo[i] / exp) % 10;
                salida[conteo[digito] - 1] = arreglo[i];
                conteo[digito]--;
            }

            return salida;
        }
    }
}
