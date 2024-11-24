using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    class Listas
    {
        
        private Nodo Inicio;
        private Nodo Final;
        private ListBox listbox;

        public Listas(ListBox listbox)
        {
            Inicio = null;
            Final = null;
            this.listbox = listbox;
        }

        public void Insertar(int posicion, int dato)
        {
            Nodo Nuevo = new Nodo();
            Nuevo.Dato = dato;
            Nuevo.Sig = null;


            if (Inicio == null && Final == null)
            {
                Inicio = Nuevo;
                Final = Nuevo;
                Mostrar(); // Mostrar la lista
                return;
            }


            if (posicion == 0 || posicion == 1)
            {
                Nuevo.Sig = Inicio;
                Inicio = Nuevo;
                Mostrar();
                return;
            }

            int pos = 0;
            Nodo Aux = Inicio;
            Nodo Previo = null;


            while (pos < posicion && Aux != null)
            {
                Previo = Aux; // Guardar el nodo anterior
                Aux = Aux.Sig; // Avanzar al siguiente nodo
                pos++;
            }


            if (Previo != null)
            {
                Nuevo.Sig = Aux;
                Previo.Sig = Nuevo;
            }
            else
            {
                // Si estamos insertando al final
                Final.Sig = Nuevo;
                Final = Nuevo;
            }

            Mostrar(); // Mostrar la lista
        }

        public void Mostrar()
        {
            if (listbox != null)
            {
                listbox.Items.Clear();  // Limpiar antes de agregar
                Nodo Aux = Inicio;
                while (Aux != null)
                {
                    listbox.Items.Add("[" + Aux.Dato + "]");
                    Aux = Aux.Sig;
                }
            }
        }

        public int Eliminar(int posicion)
        {
            // Verificar si la lista está vacía
            if (Inicio == null && Final == null)
            {
                MessageBox.Show("La lista está vacía.");
                return 0;
            }

            int pos = 1;
            Nodo Aux = Inicio;
            Nodo Previo = null;

            // Buscar el nodo por su posición
            while (pos < posicion && Aux != null)
            {
                if (Aux.Sig != null)
                {
                    Previo = Aux; // Guardar el nodo previo
                    Aux = Aux.Sig; // Avanzar al siguiente nodo
                }
                else
                {
                    Aux = null;
                }
                pos++;
            }


            if (Aux != null)
            {
                // Si Aux es el último nodo
                if (Aux == Final)
                {
                    Final = Previo;
                }


                if (Previo != null)
                {
                    Previo.Sig = Aux.Sig;
                }
                else
                {

                    Inicio = Inicio.Sig;
                    if (Inicio == null)
                    {
                        Final = null; // Actualizar Final
                    }
                }

                int dato = Aux.Dato; // Guardar el dato del nodo eliminado
                Mostrar(); // Mostrar la lista después de la eliminación
                return dato;
            }
            else
            {
                MessageBox.Show("No lo encontramos");
                return 0;
            }
        }

        public void Buscar(int datoBuscado)
        {
            int posicion = 1;
            Nodo Aux = Inicio;

            // Recorremos la lista hasta que no haya más nodos
            while (Aux != null)
            {
                if (Aux.Dato == datoBuscado)
                {
                    // Si encontramos el dato, mostramos la posición y salimos
                    MessageBox.Show("El dato " + datoBuscado + " está en la posición " + posicion);
                    return; // Terminamos el método para evitar recorrer más
                }

                Aux = Aux.Sig; // Avanzamos al siguiente nodo
                posicion++; // Incrementamos la posición
            }

            // Si no se encontró el dato, mostramos un mensaje indicándolo
            MessageBox.Show("Dato " + datoBuscado + " no encontrado en la lista.");
        }
        public void Imprimir()
        {
            if (Inicio == null) // Comprobamos si la lista está vacía
            {
                MessageBox.Show("La lista está vacía.");
                return;
            }

            Nodo Aux = Inicio; // Nodo auxiliar para recorrer la lista
            StringBuilder valores = new StringBuilder(); // Usamos StringBuilder para concatenar los valores

            // Recorremos la lista y concatenamos los valores
            while (Aux != null)
            {
                valores.Append("[" + Aux.Dato + "] "); // Concatenamos el valor de cada nodo
                Aux = Aux.Sig; // Avanzamos al siguiente nodo
            }

            // Mostramos todos los valores concatenados en un solo MessageBox
            MessageBox.Show("Valores en la lista: " + valores.ToString());
        }
        public void Vaciar()
        {
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
                    Inicio = Inicio.Sig;  // Movemos el inicio al siguiente nodo
                }

                // Actualizar el final de la lista
                Final = null;

                // Limpiar el ListBox
                listbox.Items.Clear();

                // Mostrar un mensaje confirmando que la lista ha sido vaciada
                MessageBox.Show("La lista ha sido vaciada.");
            }

        }


    }

}

    

