using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public class Pilas
    {
        public Nodo top = new Nodo();
        private ListBox listBox;  // Referencia al ListBox
        private int posicion;

        public Pilas(ListBox listBox)
        {
            top = null;
            this.listBox = listBox;
        }
        public void AsignarValor(ListBox listBox)
        {
            this.listBox = listBox;
            //Mostrar();
        }
        public void Push(int Dato)
        {
            Nodo Nuevo = new Nodo();
            Nuevo.Dato = Dato;
            Nuevo.Sig = top;
            top = Nuevo;
            Mostrar();

        }


        public void Mostrar()
        {
            if (listBox != null)
            {

                Nodo Aux = new Nodo();
                listBox.Items.Clear();
                Aux = top;
                if (top != null)
                {
                    while (Aux != null)
                    {

                        listBox.Items.Add("[" + Aux.Dato + "]");  // Añadir cada valor al ListBox
                        Aux = Aux.Sig;

                    }

                }
            }
            else { MessageBox.Show("La pila está vacía"); }
        }

        public int? Pop()
        {
            if (top == null)
            {
                MessageBox.Show("Pila vacía");
                return null;
            }
            else
            {
                Nodo Aux = top;
                top = top.Sig;
                int Dato = Aux.Dato;
                MessageBox.Show("Dato eliminado " + Dato);
                Aux = null; // Eliminamos el nodo 
                Mostrar(); // Actualizamos la visualización en el ListBox
                return Dato; // Devolvemos el valor eliminado
            }
        }
        public void Recorrer(int posicion)
        {
            int pos = 0;
            Nodo Aux = top;

            while (Aux != null)
            {
                pos++;
                if (Aux.Dato == posicion)
                {

                    MessageBox.Show("El dato " + posicion + " está en la posición " + pos);
                    return;  // Termina la ejecución del método
                }
                Aux = Aux.Sig;
            }

            // Si llegamos hasta aquí, significa que no se encontró el dato
            MessageBox.Show("Dato no encontrado");
        }
        public void Imprimir()
        {
            if (top == null)
            {
                MessageBox.Show("La pila está vacía");
                return;
            }

            Nodo Aux = top;
            StringBuilder valores = new StringBuilder();  // se usa StringBuilder para concatenar los valores de la pila

            while (Aux != null)
            {
                valores.Append("[" + Aux.Dato + "] ");
                Aux = Aux.Sig;  // Avanzamos al siguiente nodo
            }


            MessageBox.Show("Valores en la pila: " + valores.ToString());
        }

        public void VaciarPila()
        {
            if (top == null)
            { return; }
            else
            {
                Nodo Aux;
                while (top != null)
                {
                    Aux = top;
                    top = top.Sig;  // Movemos el puntero de la pila al siguiente nodo
                }
                Aux = null;  // Eliminamos el nodo actual (top anterior)
            }
            Mostrar();
        }
    }
}
