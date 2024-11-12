using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_No_Lineales.Clases
{
    class ColaPersonalizada
    {
        private NodoBinario Primero;
        private NodoBinario Ultimo;

        public ColaPersonalizada()
        {
            Primero = null;
            Ultimo = null;
        }

        // Encolar un nodo binario
        public void Enqueue(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            if (Ultimo == null)
            {
                Primero = nodo;
                Ultimo = nodo;
            }
            else
            {
                Ultimo.Sig = nodo; // Usamos el campo 'Sig' para conectar los nodos
                Ultimo = nodo;
            }
        }

        // Desencolar un nodo binario
        public NodoBinario Dequeue()
        {
            if (Primero == null)
                return null;

            NodoBinario temp = Primero;
            Primero = Primero.Sig;

            if (Primero == null) 
                Ultimo = null;

            temp.Sig = null; 
            return temp;
        }

        // Verificar si la cola está vacía
        public bool IsEmpty()
        {
            return Primero == null;
        }
    }
}
