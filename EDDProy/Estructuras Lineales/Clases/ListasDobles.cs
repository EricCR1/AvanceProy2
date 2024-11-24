using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    class ListasDobles
    {
        private Nodo Inicio;
        private Nodo Final;
        private ListBox listBox;


        public ListasDobles(ListBox listBox)
        {
            this.listBox = listBox;
            Inicio = null;
            Final = null;
        }

        public void Insertar(int posicion, int dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = dato;
            nuevo.Sig = null;
            nuevo.Ant = null;

            if (Inicio == null && Final == null)  // Lista vacía
            {
                Inicio = nuevo;
                Final = nuevo;
                Mostrar();
                return;
            }

            if (posicion == 0 || posicion == 1)  // Insertar al inicio
            {
                nuevo.Sig = Inicio;
                if (Inicio != null) Inicio.Ant = nuevo;  // Actualizar el anterior del nodo inicial
                Inicio = nuevo;
                if (Final == null) Final = nuevo;  // Caso donde había un solo nodo
                Mostrar();
                return;
            }

            int pos = 1;
            Nodo aux = Inicio;

            // Recorrer hasta la posición deseada
            while (pos < posicion && aux != null)
            {
                if (aux.Sig != null)
                {
                    aux = aux.Sig;
                }
                else
                {
                    aux = null;
                }
                pos++;
            }

            if (aux != null)  // Insertar en una posición intermedia
            {
                nuevo.Sig = aux;
                nuevo.Ant = aux.Ant;

                if (aux.Ant != null)
                {
                    aux.Ant.Sig = nuevo;
                }
                aux.Ant = nuevo;
            }
            else  // Insertar al final
            {
                Final.Sig = nuevo;
                nuevo.Ant = Final;
                Final = nuevo;
            }

            Mostrar();
        }
        public void Mostrar()
        {
            listBox.Items.Clear();
            Nodo aux = Inicio;
            while (aux != null)
            {
                listBox.Items.Add(aux.ToString());
                aux = aux.Sig;
            }
        }

        public bool Eliminar(int posicion)
        {
            if (Inicio == null && Final == null)
            {
                MessageBox.Show("Lista vacía");
                return false;
            }

            int pos = 1;
            Nodo aux = Inicio;

            // Buscar la posición a eliminar
            while (pos < posicion && aux != null)
            {
                aux = aux.Sig;
                pos++;
            }

            if (aux != null)  // Nodo encontrado
            {
                // Si es el único nodo
                if (Inicio == Final && Inicio == aux)
                {
                    Inicio = null;
                    Final = null;
                }
                else if (aux == Inicio)  // Eliminar el primer nodo
                {
                    Inicio = Inicio.Sig;
                    if (Inicio != null)
                        Inicio.Ant = null;
                }
                else if (aux == Final)  // Eliminar el último nodo
                {
                    Final = Final.Ant;
                    if (Final != null)
                        Final.Sig = null;
                }
                else  // Eliminar un nodo intermedio
                {
                    aux.Ant.Sig = aux.Sig;
                    aux.Sig.Ant = aux.Ant;
                }

                // Actualizar la visualización del ListBox
                Mostrar();
                return true;
            }

            MessageBox.Show("No se encontró la posición especificada");
            return false;
        }
        public void Buscar(int datoBuscado)
        {
            int posicion = 1;  // Posición en la lista, empieza en 1
            Nodo Aux = Inicio;

            while (Aux != null)
            {
                if (Aux.Dato == datoBuscado)
                {

                    MessageBox.Show("El dato " + datoBuscado + " está en la posición " + posicion);
                    return; // Terminamos el método para evitar recorrer más
                }

                Aux = Aux.Sig;
                posicion++;
            }

            MessageBox.Show("Dato " + datoBuscado + " no encontrado en la lista.");
        }

        public void Imprimir()
        {
            if (Inicio == null)
            {
                MessageBox.Show("La lista está vacía.");
                return;
            }

            Nodo Aux = Inicio; // Nodo auxiliar para recorrer la lista
            StringBuilder valores = new StringBuilder();


            while (Aux != null)
            {
                valores.Append("[" + Aux.Dato + "] "); // Concatenamos el valor de cada nodo
                Aux = Aux.Sig; // Avanzamos al siguiente nodo
            }


            MessageBox.Show("Valores en la lista: " + valores.ToString());
        }

        public void Vaciar()
        {
            // Comprobar si la lista está vacía
            if (Inicio == null)
            {
                MessageBox.Show("La lista ya está vacía.");
                return;
            }

            // Borrar todos los nodos de la lista
            while (Inicio != null) // Mientras haya nodos en la lista
            {
                Nodo aux = Inicio;
                Inicio = Inicio.Sig;


                if (Inicio != null)
                {
                    Inicio.Ant = null;  // Eliminar la referencia hacia atrás del nuevo inicio
                }

                aux.Sig = null;
                aux.Ant = null;
            }


            Final = null;

            // Limpiar el ListBox
            listBox.Items.Clear();


            MessageBox.Show("La lista ha sido vaciada.");
        }




    }
}

