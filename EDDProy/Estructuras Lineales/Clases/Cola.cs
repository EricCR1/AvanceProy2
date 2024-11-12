using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales;

namespace EDDemo.Estructuras_Lineales.Clases
{
    class Cola
    {
        private Nodo Primero;
        private Nodo Ultimo;
       
        private ListBox listbox;

        public Cola(ListBox listbox)
        {
            Primero = null;
            Ultimo = null;
            this.listbox = listbox;  // Asignamos el ListBox que nos pasen
        }

        public void Queue(int DATO)
        {

            Nodo Nuevo = new Nodo();
            Nuevo.Dato = DATO;
            Nuevo.Sig = null;

            if (Ultimo == null)
            {
                Ultimo = Nuevo;
                Primero = Nuevo;
            }
            else
            {
                Ultimo.Sig = Nuevo;
                Ultimo = Nuevo;
            }
            Mostrar();

        }

        public void Mostrar()
        {
            if (listbox != null)
            {
                listbox.Items.Clear();  // Limpiamos el ListBox antes de agregar los elementos
                Nodo Aux = Primero;
                while (Aux != null)
                {
                    listbox.Items.Add("[" + Aux.Dato + "]");  // Añadir cada valor al ListBox
                    Aux = Aux.Sig;
                }
            }
        }

        public int? DeQueue()
        {
            if (Primero == null)
            {
                MessageBox.Show("Cola vacía");
                return null;
            }
            else
            {
                Nodo Aux = Primero;
                Primero = Primero.Sig;
                int DATO = Aux.Dato;


                if (Primero == null)
                {
                    Ultimo = null;  // Si no quedan más nodos, también vaciamos 'Ultimo'
                }

                Aux = null;
                Mostrar();   // Actualizamos el ListBox
                return DATO;

            }
        }
        public void Recorrer(int datoBuscado)
        {
            int posicion = 0;
            Nodo Aux = Primero;

            // Recorremos la cola hasta que no haya más nodos
            while (Aux != null)
            {
                posicion++;

                if (Aux.Dato == datoBuscado)
                {

                    MessageBox.Show("El dato " + datoBuscado + " está en la posición " + posicion);
                    return;  // Terminamos el método para evitar recorrer más
                }

                Aux = Aux.Sig;  // Avanzamos al siguiente nodo
            }


            MessageBox.Show("Dato " + datoBuscado + " no encontrado en la cola.");
        }

        public void Imprimir()
        {
            if (Primero == null)
            {
                MessageBox.Show("La cola está vacía");
                return;
            }

            Nodo Aux = Primero;
            StringBuilder valores = new StringBuilder();

            while (Aux != null)
            {
                valores.Append("[" + Aux.Dato + "] ");
                Aux = Aux.Sig;  // Avanzamos al siguiente nodo
            }

            // Mostramos todos los valores concatenados en un solo MessageBox
            MessageBox.Show("Valores en la cola: " + valores.ToString());
        }

        public void VaciarCola()
        {
            if (Primero == null)
            { return; }
            else
            {
                Nodo Aux;
                while (Primero != null)
                {
                    Aux = Primero;  // Guardamos el nodo en la parte superior
                    Primero = Primero.Sig;  // Movemos el puntero de la pila al siguiente nodo
                    Aux = null;  // Eliminamos el nodo actual (top anterior)
                }
                Primero = null;
                Ultimo = null;

            }
            Mostrar();
        }
    }
}
