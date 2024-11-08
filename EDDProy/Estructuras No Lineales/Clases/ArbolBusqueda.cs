using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {            
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                //AQUI CAMBIO (SE SIMPLIFICO EL NODO)

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);          
        }

        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void Muestra(int nivel, NodoBinario nodo )
        {
            if (nodo == null)
                return;
            Muestra(nivel + 1, nodo.Der);
            for(int i=0; i<nivel; i++)
            {
                strArbol = strArbol + "     ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            Muestra(nivel + 1, nodo.Izq); 
        }

        //ALGORITMO DEL METODO PREORDEN
        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + "-";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        //ALGORITMO DEL METODO INORDEN
        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + "-";
            InOrden(nodo.Der);

            return;
        }
        //ALGORITMO DEL METODO POSTORDEN
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + "-";

            return;
        }

        public bool Buscar(int valor, NodoBinario nodo)
        {
            if (nodo == null)
                return false;

            if (nodo.Dato == valor)
                return true;

            if (valor < nodo.Dato)
                return Buscar(valor, nodo.Izq);

            else 
                return Buscar(valor, nodo.Der);
        
        }

        public void PodarArbol(ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            // Llamada recursiva para podar el subárbol izquierdo
            PodarArbol(ref nodo.Izq);

            // Llamada recursiva para podar el subárbol derecho
            PodarArbol(ref nodo.Der);

            // Eliminamos el nodo actual
            nodo = null;

            Raiz = null;

        }

        public NodoBinario BuscaMenor(NodoBinario nodo)
        {
            if (nodo == null)
                return null;
            else if (nodo.Izq == null)
                return nodo;
            else
                return BuscaMenor(nodo.Izq);
        }

        public NodoBinario BuscaMayor(NodoBinario nodo)
        {
            if (nodo == null)
                return null;
            else if (nodo.Der == null)
                return nodo;
            else
                return BuscaMayor(nodo.Der);
        }

        public void EliminarPredecesor(int x, ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            if (x < nodo.Dato)
                EliminarPredecesor(x, ref nodo.Izq);
            else if (x > nodo.Dato)
                EliminarPredecesor(x, ref nodo.Der);
            else // Encontró el nodo a eliminar
            {
                // Caso 1: El nodo tiene dos hijos
                if (nodo.Izq != null && nodo.Der != null)
                {
                    NodoBinario mayor = BuscaMayor(nodo.Izq);
                    nodo.Dato = mayor.Dato;
                    EliminarPredecesor(mayor.Dato, ref nodo.Izq);
                }
                // Caso 2: El nodo tiene un solo hijo o ninguno
                else
                {
                    // Detecta si el nodo a eliminar es la raíz
                    if (nodo == Raiz)
                    {
                        if (nodo.Izq != null)
                            Raiz = nodo.Izq;
                        else if (nodo.Der != null)
                            Raiz = nodo.Der;
                        else
                            Raiz = null;
                    }

                    // Elimina el nodo y actualiza la referencia
                    NodoBinario temp = nodo;
                    if (nodo.Izq == null)
                        nodo = nodo.Der;
                    else if (nodo.Der == null)
                        nodo = nodo.Izq;

                    temp = null;
                }
            }
        }

        public int Altura(NodoBinario nodo)
        {
            // Caso base: si el nodo es null, la altura es 0
            if (nodo == null)
                return 0;

            // Recursivamente calcula la altura de los subárboles izquierdo y derecho
            int alturaIzquierda = Altura(nodo.Izq);
            int alturaDerecha = Altura(nodo.Der);

            // Devuelve la altura mayor entre los dos subárboles, más uno por el nodo actual
            return 1 + Math.Max(alturaIzquierda, alturaDerecha);
        }

        public int ContarHojas(NodoBinario nodo)
        {
            // Si el nodo es null, no hay hojas en esta rama
            if (nodo == null)
                return 0;

            // Si el nodo es una hoja (no tiene hijos izquierdo y derecho)
            if (nodo.Izq == null && nodo.Der == null)
                return 1;

            // Sumar las hojas en los subárboles izquierdo y derecho
            return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }

        public int ContarNodos(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;

            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);
        }


    }
}
