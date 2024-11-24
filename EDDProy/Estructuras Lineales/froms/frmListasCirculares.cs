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
    public partial class frmListasCirculares : Form
    {
        private ListasCirculares circular;
        public frmListasCirculares()
        {
            InitializeComponent();
            circular = new ListasCirculares(listBox1);
        }

        private void frmListasCirculares_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int valorBuscado = int.Parse(textBox1.Text);  // Obtener el valor desde el TextBox
            circular.Buscar(valorBuscado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            int dato = int.Parse(textBox2.Text);  // Convertir el valor del primer TextBox en entero
            int posicion = int.Parse(textBox3.Text);  // Convertir el valor del segundo TextBox en entero

            // Llamar al método Insertar de la lista circular
            circular.Insertar(posicion, dato);

            // Mostrar un mensaje confirmando la inserción
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int posicion = int.Parse(textBox4.Text);  // Convertir el valor del TextBox en entero

            // Llamar al método Eliminar de la lista circular
            circular.Eliminar(posicion);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            circular.Vaciar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            circular.Imprimir();
        }
    }
}
