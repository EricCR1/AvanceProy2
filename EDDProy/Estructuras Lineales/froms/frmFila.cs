using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Estructuras_No_Lineales;

namespace EDDemo.Estructuras_Lineales.froms
{
    public partial class frmFila : Form
    {
        private Cola cola;
        public frmFila()
        {
            InitializeComponent();
            cola = new Cola(listBox1);
        }

        private void frmFila_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cola.Imprimir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int posicion;
            // Validar que el texto ingresado sea un número
            if (int.TryParse(textBox2.Text, out posicion))
            {
                cola.Recorrer(posicion);  // Añadir a la pila
            }
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cola.DeQueue();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            int DATO;
            // Validar que el texto ingresado sea un número
            if (int.TryParse(textBox1.Text, out DATO))
            {
                NodoBinario nuevoNodo = new NodoBinario(DATO); // Crear nodo con el valor ingresado
                cola.Queue(nuevoNodo);  // Encolar el nodo
            }
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cola.VaciarCola();
        }
    }
}
