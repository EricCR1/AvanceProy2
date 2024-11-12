using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
 
            
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado

            if (miArbol.Buscar(int.Parse(txtDato.Text), miArbol.RegresaRaiz()))
                MessageBox.Show("No se admiten datos duplicados");
            else
            {
                miArbol.InsertaNodo(int.Parse(txtDato.Text), ref miRaiz);
                //Leer arbol completo y mostrarlo en caja de texto
                miArbol.Muestra(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                txtDato.Text = "";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
        }

        private void frmArboles_Load(object sender, EventArgs e)
        {

        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                lblRecorridoInOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = "";
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";

            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                if (miArbol.Buscar(Dato, miArbol.RegresaRaiz()))
                    nNodos--;
                else
                    miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                int valor = int.Parse(textBox1.Text);
                

                if (miArbol.Buscar(valor, miArbol.RegresaRaiz()))
                    MessageBox.Show("El"+ valor + "se encontró en el árbol.");
                else
                    MessageBox.Show("El valor no se encontró en el árbol.");
            }
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString = b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);


            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            // Obtenemos el nodo raíz del árbol
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            // Llamamos al método para podar el árbol
            miArbol.PodarArbol(ref miRaiz);
            miRaiz = null;

            // Actualizamos la visualización del árbol usando la función de mostrar
            miArbol.strArbol = ""; // Limpiamos la cadena del árbol
            miArbol.MuestraArbolAcostado(1, miRaiz); // o usa Muestra(1, miRaiz) si prefieres esa función
            txtArbol.Text = miArbol.strArbol; // Muestra el árbol en la caja de texto

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNodos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            int valorAEliminar = int.Parse(txtDatoEliminar.Text);

            // Llama a EliminarPredecesor con el nodo raíz
            miArbol.EliminarPredecesor(valorAEliminar, ref miRaiz);

            // Reasigna la raíz en caso de que se haya eliminado
            miRaiz = miArbol.RegresaRaiz();

            // Actualiza la visualización del árbol
            miArbol.strArbol = "";
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            // Obtenemos el nodo raíz del árbol
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            // Calculamos la altura del árbol desde la raíz
            int altura = miArbol.Altura(miRaiz);
            MessageBox.Show("La altura del árbol es: " + altura);
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Obtenemos la raíz del árbol
            miRaiz = miArbol.RegresaRaiz();

            // Verifica si el árbol está vacío
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            // Llama al método para contar las hojas y muestra el resultado
            int numHojas = miArbol.ContarHojas(miRaiz);
            MessageBox.Show("El número de hojas en el árbol es: " + numHojas);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Obtenemos la raíz del árbol
            miRaiz = miArbol.RegresaRaiz();

            // Verifica si el árbol está vacío
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            // Llama al método para contar los nodos y muestra el resultado
            int numNodos = miArbol.ContarNodos(miRaiz);
            MessageBox.Show("El número de nodos en el árbol es: " + numNodos);
        }

        private void txtArbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLleno_Click(object sender, EventArgs e)
        {
            // Obtenemos el nodo raíz del árbol
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            // Verificamos si el árbol es lleno
            if (miArbol.EsLleno(miRaiz))
                MessageBox.Show("El árbol es lleno.");
            else
                MessageBox.Show("El árbol no es lleno.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valorAEliminar = int.Parse(textBox1.Text);

            // Llama a EliminarSucesor con el nodo raíz
            miArbol.EliminarSucesor(valorAEliminar, ref miRaiz);

            // Reasigna la raíz en caso de que se haya eliminado
            miRaiz = miArbol.RegresaRaiz();

            // Actualiza la visualización del árbol
            miArbol.strArbol = "";
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void txtDatoEliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (miRaiz == null)
                {
                    MessageBox.Show("El árbol está vacío.");
                    return;
                }

                // Llamamos al método de recorrido por niveles con la cola personalizada
                miArbol.RecorridoPorNivelesPersonalizado(miRaiz);

                // Mostramos el resultado
                MessageBox.Show("Recorrido por niveles: " + miArbol.strRecorrido);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            bool esCompleto = miArbol.EsArbolCompleto(miRaiz);

            if (esCompleto)
                MessageBox.Show("El árbol es completo.");
            else
                MessageBox.Show("El árbol no es completo.");
        }
    }
}
