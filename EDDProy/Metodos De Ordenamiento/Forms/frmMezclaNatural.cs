using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Metodos_De_Ordenamiento.Clases;

namespace EDDemo.Metodos_De_Ordenamiento.Forms
{
    public partial class frmMezclaNatural : Form
    {
        private int[] arreglo;
        public frmMezclaNatural()
        {
            InitializeComponent();
        }

        private void frmMezclaNatural_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Crear un arreglo aleatorio
            int cantidad = (int)numericUpDown1.Value;
            Random random = new Random();
            arreglo = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = random.Next(1, 100); // Números entre 1 y 100
            }

            // Mostrar el arreglo original
            label2.Text = $"Arreglo original: {string.Join(", ", arreglo)}";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (arreglo == null || arreglo.Length == 0)
            {
                MessageBox.Show("Primero debes crear un arreglo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear instancia de MezclaNatural y ordenar
            MezclaNatural mezclaNatural = new MezclaNatural();
            mezclaNatural.Ordenar(arreglo);

            // Limpiar el Label de pasos previos
            label4.Text = "";

            // Mostrar los pasos intermedios en el Label
            foreach (var paso in mezclaNatural.Pasos)
            {
                label4.Text += paso + "\n";
            }

            // Mostrar el arreglo final ordenado
            label5.Text = $"Arreglo ordenado: {string.Join(", ", arreglo)}";
        }
    }
}

