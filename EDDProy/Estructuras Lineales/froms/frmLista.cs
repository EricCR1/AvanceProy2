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

namespace EDDemo.Estructuras_Lineales.froms
{
    public partial class frmLista : Form
    {
        private Listas listas;
        public frmLista()
        {
            InitializeComponent();
            listas = new Listas(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listas.Imprimir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmLista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int valor;
            int lugar;

            // Validar que el texto ingresado sea un número
            if (int.TryParse(textBox1.Text, out valor) && int.TryParse(textBox2.Text, out lugar))
            {
                listas.Insertar(lugar, valor);  // Inserta en la lista (posición primero, luego el valor)
            }
            textBox1.Text = "";
            textBox2.Text = "";  // También limpiar el segundo campo
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int dato;
            // Validar que el texto ingresado sea un número
            if (int.TryParse(textBox3.Text, out dato))
            {
                listas.Buscar(dato);  // Añadir a la pila
            }
            textBox1.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int pos;

            // Validar que el texto ingresado sea un número
            if (int.TryParse(textBox4.Text, out pos))
            {
                listas.Eliminar(pos);  // Añadir a la pila
            }
            textBox1.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listas.Vaciar();
        }
    }
}
