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
    public partial class frmListasDobles : Form
    {
        private ListasDobles listasdobles;
        public frmListasDobles()
        {
            InitializeComponent();
            listasdobles = new ListasDobles(listBox1);
        }

        private void frmListasDobles_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor;
            int posicion;

            // Validar que se ingresen números en ambos campos
            if (int.TryParse(textBox2.Text, out valor) && int.TryParse(textBox3.Text, out posicion))
            {
                listasdobles.Insertar(posicion, valor);  // Insertar el valor en la posición deseada
            }

            // Limpiar los campos de texto después de insertar
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listasdobles.Imprimir();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int datoBuscado;
            if (int.TryParse(textBox1.Text, out datoBuscado))  // Validar si el dato ingresado es un número
            {
                listasdobles.Buscar(datoBuscado);  // Llamar al método Buscar en la lista doble
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listasdobles.Vaciar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int posicion;
            if (int.TryParse(textBox1.Text, out posicion))  // Asegurarse de que sea un número válido
            {
                listasdobles.Eliminar(posicion);  // Llamar al método Eliminar con la posición indicada
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una posición válida");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
