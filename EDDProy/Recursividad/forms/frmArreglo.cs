using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Recursividad.Clases.EDDemo.Recursividad.Clases;
using System.Diagnostics;

namespace EDDemo.Recursividad.forms
{
    public partial class frmArreglo : Form
    {
        public frmArreglo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el tamaño del arreglo desde el NumericUpDown
                int tamaño = (int)numericUpDown1.Value;

                if (tamaño <= 0)
                {
                    MessageBox.Show("El tamaño del arreglo debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Generar el arreglo de números aleatorios usando recursividad
                int[] arreglo = SumarArreglos.GenerarArreglo(tamaño);

                // Iniciar el cronómetro
                Stopwatch stopwatch = Stopwatch.StartNew();

                // Calcular la suma del arreglo usando recursividad
                int suma = SumarArreglos.CalcularSuma(arreglo);

                // Detener el cronómetro
                stopwatch.Stop();

                // Convertir el arreglo a una cadena con el formato [x] [y] [z]
                string numerosFormateados = string.Join(" ", arreglo.Select(num => $"[{num}]"));

                // Mostrar los números generados en el Label
                label3.Text = numerosFormateados;

                // Mostrar el resultado de la suma en el Label
                label5.Text =  suma.ToString();

                label7.Text = "";
                label7.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
