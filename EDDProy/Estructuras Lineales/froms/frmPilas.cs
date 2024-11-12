using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EDDemo.Clases;

namespace EDDemo
{
    public partial class frmPilas : Form
    {

        private Pilas pila;

        public frmPilas()
        {
            InitializeComponent();
            pila = new Pilas(listBox1);

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            int valor;

            // Validar que el texto ingresado sea un número
            if (int.TryParse(textBox1.Text, out valor))
            {
                pila.Push(valor);  // Añadir a la pila
            }
            textBox1.Text = "";
        }

        private void frmPilas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int posicion;
            // Validar que el texto ingresado sea un número
            if (int.TryParse(textBox2.Text, out posicion))
            {
                pila.Recorrer(posicion);  // Añadir a la pila
            }
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pila.Imprimir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pila.VaciarPila();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pila.Pop();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
