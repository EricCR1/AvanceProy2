using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Busqueda
{
    class Hash
    {
        private const int TAMANIO = 100; // Tamaño fijo de la tabla hash
        private int[] claves;
        private string[] valores;

        public Hash()
        {
            claves = new int[TAMANIO];
            valores = new string[TAMANIO];
            for (int i = 0; i < TAMANIO; i++)
            {
                claves[i] = -1; // Indicador de espacio vacío
            }
        }

        private int FuncionHash(int clave, int tamanioTabla)
        {
            return clave % tamanioTabla;
        }

        public void Insertar(int clave, string valor)
        {
            int indice = FuncionHash(clave, TAMANIO);
            while (claves[indice] != -1) // Resolver colisiones mediante linealidad
            {
                indice = (indice + 1) % TAMANIO;
            }
            claves[indice] = clave;
            valores[indice] = valor;
        }

        public string Buscar(int clave)
        {
            int indice = FuncionHash(clave, TAMANIO);
            int inicio = indice;

            while (claves[indice] != -1)
            {
                if (claves[indice] == clave)
                {
                    return valores[indice];
                }
                indice = (indice + 1) % TAMANIO;

                if (indice == inicio)
                {
                    break;
                }
            }
            return null; // No encontrado
        }
    }
}
