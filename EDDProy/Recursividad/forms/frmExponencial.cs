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
    public partial class frmExponencial : Form
    {
        public frmExponencial()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de las TextBox
                int baseNum = int.Parse(textBox1.Text);
                int exponente = int.Parse(textBox2.Text);


                // Iniciar el cronómetro
                Stopwatch stopwatch = Stopwatch.StartNew();

                // Llamar a la función de la clase Exponencial
                int resultado = Exponencial.CalcularExponente(baseNum, exponente);

                // Detener el cronómetro
                stopwatch.Stop();

                // Mostrar el resultado en el Label
                label3.Text = $"{resultado}";
                label5.Text = "";
                label5.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce números válidos en ambos campos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmExponencial_Load(object sender, EventArgs e)
        {

        }
    }
}
