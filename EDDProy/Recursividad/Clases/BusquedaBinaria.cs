using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace EDDemo.Recursividad.Clases
{
    class BusquedaBinaria
    {
            // Método recursivo para la búsqueda binaria
            public static int Buscar(int[] arreglo, int numero, int inicio, int fin, ref int cantidadCortes)
            {
                // Incrementar el contador de cortes
                cantidadCortes++;

                // Caso base: el rango de búsqueda es inválido
                if (inicio > fin)
                {
                    return -1; // No encontrado
                }

                // Calcular el punto medio
                int medio = (inicio + fin) / 2;

                // Si el número está en el medio
                if (arreglo[medio] == numero)
                {
                    return medio; // Retornar la posición
                }

                // Si el número buscado es menor, buscar en la mitad izquierda
                if (numero < arreglo[medio])
                {
                    return Buscar(arreglo, numero, inicio, medio - 1, ref cantidadCortes);
                }

                // Si el número buscado es mayor, buscar en la mitad derecha
                return Buscar(arreglo, numero, medio + 1, fin, ref cantidadCortes);
            }
        }
    }