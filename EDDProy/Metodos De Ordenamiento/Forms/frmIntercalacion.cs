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
    public partial class frmIntercalacion : Form
    {
        private int[] arreglo1;
        private int[] arreglo2;
        public frmIntercalacion()
        {
            InitializeComponent();
        }

        private void frmIntercalacion_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Crear dos arreglos aleatorios
            int cantidad1 = (int)numericUpDown1.Value;
            int cantidad2 = (int)numericUpDown1.Value;

            Random random = new Random();
            arreglo1 = new int[cantidad1];
            arreglo2 = new int[cantidad2];

            for (int i = 0; i < cantidad1; i++)
            {
                arreglo1[i] = random.Next(1, 100); // Números entre 1 y 100
            }

            for (int j = 0; j < cantidad2; j++)
            {
                arreglo2[j] = random.Next(1, 100); // Números entre 1 y 100
            }

            // Ordenar ambos arreglos antes de intercalar
            Array.Sort(arreglo1);
            Array.Sort(arreglo2);

            // Mostrar los arreglos generados
            label2.Text = $"Arreglo 1: {string.Join(", ", arreglo1)}";
            label3.Text = $"Arreglo 2: {string.Join(", ", arreglo2)}";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (arreglo1 == null || arreglo2 == null || arreglo1.Length == 0 || arreglo2.Length == 0)
            {
                MessageBox.Show("Primero debes crear los arreglos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear instancia de Intercalacion y combinar
            Intercalacion intercalacion = new Intercalacion();
            int[] resultado = intercalacion.Intercalar(arreglo1, arreglo2);

            // Limpiar el Label de pasos previos
            label5.Text = "";

            // Mostrar los pasos intermedios en el Label
            label4.Text = "";
            foreach (var paso in intercalacion.Pasos)
            {
                label4.Text += paso + "\n";
            }

            // Mostrar el arreglo final en otro Label
            label5.Text = $"Arreglo combinado: {string.Join(", ", resultado)}";
        }
    }
}

