using System;
using System.Diagnostics; 
using System.Windows.Forms;
using EDDemo.Recursividad.Clases; 

namespace EDDemo.Recursividad
{
    public partial class frmFactorial : Form
    {
        private Factorial factorial;
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmFactorial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero) && numero >= 0)
            {
                // Iniciar el cronómetro
                Stopwatch stopwatch = Stopwatch.StartNew();

                long resultado = Factorial.CalcularFactorial(numero);

                // Detener el cronómetro
                stopwatch.Stop();

                label3.Text = "";
                label3.Text = $" {resultado}";
                label5.Text = "";
                label5.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            else
            {
                MessageBox.Show("Ingrese un número válido (entero positivo)");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}

