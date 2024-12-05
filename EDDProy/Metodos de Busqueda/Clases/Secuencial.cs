using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Busqueda.Clases
{
    class Secuencial
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public int Buscar(int[] arreglo, int valorBuscado)
        {
            Pasos.Clear(); // Limpiar los pasos previos

            for (int i = 0; i < arreglo.Length; i++)
            {
                Pasos.Add($"Paso {i + 1}: Comparando {arreglo[i]} con {valorBuscado}");

                if (arreglo[i] == valorBuscado)
                {
                    Pasos.Add($"Valor encontrado en la posición {i}");
                    return i; // Regresa la posición donde se encuentra el valor
                }
            }

            Pasos.Add("Valor no encontrado");
            return -1; // Regresa -1 si el valor no está en el arreglo
        }
    }
}
