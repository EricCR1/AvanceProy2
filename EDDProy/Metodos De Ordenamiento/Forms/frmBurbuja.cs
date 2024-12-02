using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Metodos_De_Ordenamiento.Clases;

namespace EDDemo.Metodos_De_Ordenamiento.Forms
{
    public partial class frmBurbuja : Form
    {
        private int[] arreglo;
        private Burbuja burbuja = new Burbuja();
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Llamar al algoritmo de burbuja
            arreglo = burbuja.Ordenar(arreglo);

            // Mostrar los pasos acumulativamente
            label3.Text = "";
            foreach (var paso in burbuja.Pasos)
            {
                
                label3.Text += paso + "\n"; // Agregar cada paso como una nueva línea
            }
            // Mostrar el arreglo final en el label superior
            label4.Text = $"Arreglo ordenado: {string.Join(", ", arreglo)}";
        }

        private void frmBurbuja_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numericUpDown1.Value;
            Random random = new Random();
            arreglo = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = random.Next(1, 100); // Números entre 1 y 100
            }

            label2.Text = string.Join(", ", arreglo);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }
    }
}

