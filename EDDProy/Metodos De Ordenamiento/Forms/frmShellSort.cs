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
    public partial class frmShellSort : Form
    {
        private int[] arreglo;
        public frmShellSort()
        {
            InitializeComponent();
        }

        private void frmShellSort_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Crear arreglo aleatorio
            int cantidad = (int)numericUpDown1.Value;
            Random random = new Random();
            arreglo = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = random.Next(1, 100); // Números entre 1 y 100
            }

            label2.Text = $"Arreglo inicial: {string.Join(", ", arreglo)}"; // Mostrar en el Label
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (arreglo == null || arreglo.Length == 0)
            {
                MessageBox.Show("Primero debes crear un arreglo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear instancia de ShellSort y ordenar
            ShellSort shellSort = new ShellSort();
            shellSort.Ordenar(arreglo);

            // Limpiar el Label de pasos previos
            label3.Text = "";

            // Mostrar los pasos intermedios en el Label
            foreach (var paso in shellSort.Pasos)
            {
                label3.Text += paso + "\n";
            }

            // Mostrar el arreglo final en otro Label
            label4.Text = $"Arreglo ordenado: {string.Join(", ", arreglo)}";
        }
    }
}
