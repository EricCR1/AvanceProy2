using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Busqueda.Clases
{
     class Binaria
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public int Buscar(int[] arreglo, int valorBuscado)
        {
            Pasos.Clear(); // Limpiar los pasos previos

            int inicio = 0;
            int fin = arreglo.Length - 1;
            

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                Pasos.Add($"Busquedas en [Derecha pos: {inicio}, Centro pos:{medio}, Izquiera pos:{fin}]");

                if (arreglo[medio] == valorBuscado)
                {
                    Pasos.Add($"Valor encontrado en la posición {medio}");
                    return medio;
                }
                else if (arreglo[medio] < valorBuscado)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            Pasos.Add("Valor no encontrado");
            return -1; // Retorna -1 si el valor no está en el arreglo

        }
    }
}

