using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Recursividad.Clases;
using System.Diagnostics;

namespace EDDemo.Recursividad.forms
{
    public partial class frmFibonacci : Form
    {
        private Fibonacci fibonacci;
        public frmFibonacci()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el valor desde la TextBox
                int posicion = int.Parse(textBox1.Text);

                if (posicion < 0)
                {
                    MessageBox.Show("Por favor, introduce un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Iniciar el cronómetro
                Stopwatch stopwatch = Stopwatch.StartNew();

                // Calcular el número de Fibonacci usando recursividad
                int resultado = Fibonacci.CalcularFibonacci(posicion);

                // Detener el cronómetro
                stopwatch.Stop();

                // Mostrar el resultado en el Label
                label5.Text = $"{resultado}";
                label7.Text = "";
                label7.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
