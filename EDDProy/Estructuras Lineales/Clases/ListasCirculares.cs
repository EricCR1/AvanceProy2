using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    class ListasCirculares
    {
        
        private Nodo Inicio;
        private Nodo Final;
        private ListBox listBox;

        public ListasCirculares(ListBox listBox)
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


            if (Inicio == null && Final == null)
            {
                Inicio = nuevo;
                Final = nuevo;
                Final.Sig = Inicio;   // La lista es circular, el siguiente de Final apunta a Inicio
                Mostrar();
                return;
            }


            if (posicion == 0 || posicion == 1)
            {
                nuevo.Sig = Inicio;
                Inicio = nuevo;
                Final.Sig = Inicio;
                Mostrar();
                return;
            }


            int pos = 1;
            Nodo aux = Inicio;


            while (pos < posicion - 1 && aux.Sig != Inicio)
            {
                aux = aux.Sig;
                pos++;
            }


            nuevo.Sig = aux.Sig;
            aux.Sig = nuevo;


            if (aux == Final)
            {
                Final = nuevo;
            }

            Mostrar();  // Actualizar el ListBox 
        }


        public void Mostrar()
        {
            listBox.Items.Clear();
            if (Inicio == null) return;

            Nodo aux = Inicio;
            do
            {
                listBox.Items.Add(aux.ToString()); // Se mostrará el valor del nodo gracias al método ToString()
                aux = aux.Sig; // Avanzar al siguiente nodo
            } while (aux != Inicio); // Continuar hasta regresar al nodo inicial
        }



        public void Eliminar(int posicion)
        {

            if (Inicio == null && Final == null)
            {
                MessageBox.Show("Lista vacía");
                return;
            }

            int pos = 1;
            Nodo aux = Inicio;
            Nodo previo = null;


            while (pos < posicion && aux.Sig != Inicio)
            {
                previo = aux;
                aux = aux.Sig;
                pos++;
            }


            if (aux != null)
            {

                if (aux == Inicio)  // Eliminar el primer nodo
                {

                    if (Inicio == Final)
                    {
                        Inicio = null;
                        Final = null;
                    }
                    else
                    {
                        Inicio = Inicio.Sig;
                        Final.Sig = Inicio;
                    }
                }
                else if (aux == Final)
                {
                    Final = previo;
                    Final.Sig = Inicio;
                }
                else
                {
                    previo.Sig = aux.Sig;
                }

                MessageBox.Show($"Dato eliminado: {aux.Dato}");
            }
            else
            {
                MessageBox.Show("Posición no encontrada en la lista");
            }

            Mostrar();  // Actualizar el ListBox con los elementos restantes de la lista
        }

        public void Buscar(int datoBuscado)
        {
            if (Inicio == null)
            {
                MessageBox.Show("La lista está vacía.");
                return;
            }

            int posicion = 1;
            Nodo Aux = Inicio;


            while (Aux != null)
            {
                if (Aux.Dato == datoBuscado)
                {

                    MessageBox.Show("El dato " + datoBuscado + " está en la posición " + posicion);
                    return;
                }

                Aux = Aux.Sig;
                posicion++;

                if (Aux == Inicio)
                {
                    break;
                }
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

            Nodo Aux = Inicio;
            StringBuilder valores = new StringBuilder();


            do
            {
                valores.Append("[" + Aux.Dato + "] ");
                Aux = Aux.Sig;
            } while (Aux != Inicio);


            MessageBox.Show("Valores en la lista: " + valores.ToString());
        }
        public void Vaciar()
        {

            if (Inicio == null)
            {
                MessageBox.Show("La lista ya está vacía.");
                return;
            }


            while (Inicio != Final)
            {
                Nodo aux = Inicio;
                Inicio = Inicio.Sig;
                aux.Sig = null;
            }

            // Eliminar el último nodo restante
            Inicio = null;
            Final = null;

            // Limpiar el ListBox
            listBox.Items.Clear();


            MessageBox.Show("La lista ha sido vaciada.");
        }





    }
}

